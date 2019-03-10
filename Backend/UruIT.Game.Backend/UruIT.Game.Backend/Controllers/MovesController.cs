using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UruIT.Game.Model;
using UruIT.Game.Service.Layers.Moves;

namespace UruIT.Game.Backend.Controllers
{
    [ODataRoutePrefix("moves")]
    public class MovesController : ODataController
    {
        private ODataValidationSettings _validationSettings = new ODataValidationSettings();

        public IMovesService _service;

        public MovesController(IMovesService service)
        {
            _service = service;
        }

        [HttpGet]
        [EnableQuery]
        public IQueryable<Move> Get()
        {
            return _service.Get();
        }
    }
}