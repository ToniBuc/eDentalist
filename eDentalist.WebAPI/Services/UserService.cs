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

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        public List<Model.User> Get(UserSearchRequest request)
        {
            var query = _context.User.AsQueryable();

            bool isRequestNull = !string.IsNullOrWhiteSpace(request.FirstName) || !string.IsNullOrWhiteSpace(request.LastName);

            //if (!string.IsNullOrWhiteSpace(request?.Ime))
            //{
            //    query = query.Where(x => x.Ime.StartsWith(request.Ime));
            //}
            //if (!string.IsNullOrWhiteSpace(request?.Prezime))
            //{
            //    query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            //}

            if (isRequestNull)
            {
                query = query.Where(i => (!string.IsNullOrWhiteSpace(request.FirstName) && i.FirstName.StartsWith(request.FirstName)) || (!string.IsNullOrWhiteSpace(request.LastName) && i.LastName.StartsWith(request.LastName)));
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.User>>(list);
        }

        public Model.User GetById(int id)
        {
            var entity = _context.User.Find(id);
            return _mapper.Map<Model.User>(entity);
        }

        public Model.User Insert(UserUpsertRequest request)
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

            //foreach (var uloga in request.Uloge)
            //{
            //    _context.KorisniciUloge.Add(new Database.KorisniciUloge()
            //    {
            //        DatumIzmjene = DateTime.Now,
            //        KorisnikId = entity.KorisnikId,
            //        UlogaId = uloga
            //    });
            //}

           // _context.SaveChanges();

            return _mapper.Map<Model.User>(entity);
        }

        public Model.User Update(int id, UserUpsertRequest request)
        {
            var entity = _context.User.Find(id);
            _context.User.Attach(entity);
            _context.User.Update(entity);

            _mapper.Map(request, entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new UserException("The passwords do not match!");
                }
            }

            _context.SaveChanges();

            return _mapper.Map<Model.User>(entity);
        }

        public Model.User Login(UserLoginRequest request)
        {
            var entity = _context.User.Include("UserRole").FirstOrDefault(x => x.Username == request.Username);

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
    }
}
