using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using UruIT.Game.Bll;
using UruIT.Game.Model;
using UruIT.Game.Service.Layers.Users;

namespace UruIT.Game.Backend.Controllers
{
    public class UsersController : ODataController
    {
        private ODataValidationSettings _validationSettings = new ODataValidationSettings();

        public IUserService _service;



        public UsersController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        [EnableQuery]
        public IQueryable<User> Get()
        {
            return _service.Get();
        }

        [HttpPost]
        public bool Post([FromBody]User user)
        {
            DoCreate(user);
            return true;
        }

        private void DoCreate(User user)
        {
            if (user == null)
                throw new Exception("User is not null");
            _service.Add(user);
        }

    }
}