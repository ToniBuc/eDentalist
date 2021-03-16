using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eDentalist.Model.Requests;
using eDentalist.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eDentalist.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.User> Get([FromQuery]UserSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("GetStaff")]
        public List<Model.User> GetStaff([FromQuery]UserSearchRequest request)
        {
            return _service.GetStaff(request);
        }
        [HttpGet("{id}")]
        public Model.User GetById(int id)
        {
            return _service.GetById(id);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public Model.User Insert(UserInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.User Update(int id, [FromBody]UserUpdateRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpPost("Login")]
        public Model.User Login(UserLoginRequest request)
        {
            return _service.Login(request);
        }
    }
}