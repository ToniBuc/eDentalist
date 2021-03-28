using AutoMapper;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Database;
using eDentalist.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Services
{
    public class UserService : IUserService
    {
        private readonly eDentalistDbContext _context;
        private readonly IMapper _mapper;
        public UserService(eDentalistDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.User Authenticate(string username, string pass)
        {
            var user = _context.User.Include("UserRole").FirstOrDefault(x => x.Username == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, pass);

                if (newHash == user.PasswordHash)
                {
                    return _mapper.Map<Model.User>(user);
                }
            }

            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA512");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        public List<Model.User> Get(UserSearchRequest request)
        {
            var query = _context.User.Include(i => i.UserRole).AsQueryable(); //included userrole for role checks in user retrievals, for example retrieving only staff in the staffmembers form

            bool isRequestNull = !string.IsNullOrWhiteSpace(request.FirstName) || !string.IsNullOrWhiteSpace(request.LastName);

            if (isRequestNull)
            {
                query = query.Where(i => (!string.IsNullOrWhiteSpace(request.FirstName) && i.FirstName.StartsWith(request.FirstName)) || (!string.IsNullOrWhiteSpace(request.LastName) && i.LastName.StartsWith(request.LastName)));
            }

            var list = query.ToList();

            var result = _mapper.Map<List<Model.User>>(list);

            foreach(var x in result)
            {
                x.UserRoleName = x.UserRole.Name;
            }

            return result;
        }

        public Model.User GetById(int id)
        {
            //var entity = _context.User.Find(id);

            var entity = _context.User.Where(i => i.UserID == id).Include(i => i.UserRole).Include(i => i.Gender).Include(i => i.City).FirstOrDefault();

            var result = _mapper.Map<Model.User>(entity);
            result.UserRoleName = entity.UserRole.Name;
            result.GenderName = entity.Gender.Name;
            result.CityName = entity.City.Name;
            result.FullName = entity.FirstName + " " + entity.LastName;

            return _mapper.Map<Model.User>(result);
        }

        public Model.User Insert(UserInsertRequest request)
        {
            var entity = _mapper.Map<Database.User>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("The passwords do not match!");
            }

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            _context.User.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.User>(entity);
        }

        public Model.User Update(int id, UserUpdateRequest request)
        {
            var entity = _context.User.Find(id);
            if (request.Image == null)
            {
                request.Image = entity.Image;
            }
            _context.User.Attach(entity);
            _context.User.Update(entity);

            _mapper.Map(request, entity);


            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new UserException("The passwords do not match!");
                }

                entity.PasswordSalt = GenerateSalt();
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            }

            _context.SaveChanges();

            return _mapper.Map<Model.User>(entity);
        }

        public Model.User Login(UserLoginRequest request)
        {
            var entity = _context.User.Include(i => i.UserRole).FirstOrDefault(x => x.Username == request.Username);

            if (entity == null)
            {
                throw new UserException("Wrong username or password!");
            }

            var hash = GenerateHash(entity.PasswordSalt, request.Password);

            if (hash != entity.PasswordHash)
            {
                throw new UserException("Wrong username or password!");
            }

            return _mapper.Map<Model.User>(entity);
        }

        public List<Model.User> GetStaff(UserSearchRequest request)
        {
            var query = _context.User.Include(i => i.UserRole).AsQueryable(); //included userrole for role checks in user retrievals, for example retrieving only staff in the staffmembers form

            bool isRequestNull = !string.IsNullOrWhiteSpace(request.FirstName) || !string.IsNullOrWhiteSpace(request.LastName);

            if (isRequestNull)
            {
                query = query.Where(i => (!string.IsNullOrWhiteSpace(request.FirstName) && i.FirstName.StartsWith(request.FirstName)) || (!string.IsNullOrWhiteSpace(request.LastName) && i.LastName.StartsWith(request.LastName)));
            }

            var list = query.ToList();

            var result = _mapper.Map<List<Model.User>>(list);
            var staff = new List<Model.User>();
            foreach (var x in result)
            {
                x.UserRoleName = x.UserRole.Name;
                x.FullName = x.FirstName + " " + x.LastName;
                if (x.UserRoleName != "Patient")
                {
                    staff.Add(x);
                }
                
            }

            return staff;
        }

        public Model.User Register(UserInsertRequest request)
        {
            var entity = _mapper.Map<User>(request);
            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("The passwords do not match!");
            }

            var users = _context.User.ToList();
            foreach(var x in users)
            {
                if (x.Username == request.Username)
                {
                    throw new UserException("This username is taken!");
                }
                else if (x.Email == request.Email)
                {
                    throw new UserException("This email is taken!");
                }
            }
            var roles = _context.UserRole.ToList();
            foreach (var x in roles)
            {
                if (x.Name == "Patient")
                {
                    entity.UserRoleID = x.UserRoleID;
                }
            }
            var genders = _context.Gender.ToList();
            foreach (var x in genders)
            {
                if (x.Name == "Unassigned")
                {
                    entity.GenderID = x.GenderID;
                }
            }
            var cities = _context.City.ToList();
            foreach (var x in cities)
            {
                if (x.Name == "Unassigned")
                {
                    entity.CityID = x.CityID;
                }
            }

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            _context.User.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.User>(entity);
        }
    }
}
