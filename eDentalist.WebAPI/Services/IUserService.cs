using eDentalist.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Services
{
    public interface IUserService
    {
        List<Model.User> Get(UserSearchRequest request);
        List<Model.User> GetStaff(UserSearchRequest request);
        Model.User GetById(int id);
        Model.User Insert(UserInsertRequest request);
        Model.User Update(int id, UserUpdateRequest request);
        Model.User Authenticate(string username, string pass);
        Model.User Login(UserLoginRequest userLoginRequest);
        Model.User Register(UserInsertRequest request);
    }
}
