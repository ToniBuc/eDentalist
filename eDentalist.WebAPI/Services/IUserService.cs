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
        Model.User GetById(int id);
        Model.User Insert(UserUpsertRequest request);
        Model.User Update(int id, UserUpsertRequest request);
        Model.User Authenticate(string username, string pass);
        Model.User Login(UserLoginRequest userLoginRequest);
    }
}
