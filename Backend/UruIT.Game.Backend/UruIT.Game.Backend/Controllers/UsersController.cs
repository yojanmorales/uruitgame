using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
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

        [HttpPatch]
        public IActionResult Patch([FromODataUri] int key, [FromBody] Delta<User> user)
        {
            return DoUpdate(key, user);
        }

        private IActionResult DoUpdate(int key, Delta<User> user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return null;
            // _service.Add(user);
        }

    }
}