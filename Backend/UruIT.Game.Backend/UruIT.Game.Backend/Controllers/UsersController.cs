using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UruIT.Game.Model;
using UruIT.Game.Service.Layers.Users;

namespace UruIT.Game.Backend.Controllers
{

    [ODataRoutePrefix("users")]
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
        public IActionResult Post([FromBody]User user)
        {
            return DoCreate(user);
        }

        private IActionResult DoCreate(User user)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = _service.Add(user);
            if (result)
                return Ok("User created");
            else return BadRequest();
        }

        [HttpPut]
        public IActionResult Put([FromODataUri] int key, [FromBody] User user)
        {
            return DoUpdate(key, user);
        }

        private IActionResult DoUpdate(int key, User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            user.Id = key;
            var result = _service.Update(user);
            if (result)
                return Ok("User updated");
            else return BadRequest();

        }

    }
}