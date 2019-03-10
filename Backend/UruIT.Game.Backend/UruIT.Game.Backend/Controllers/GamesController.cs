using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UruIT.Game.Service.Layers.Games;

namespace UruIT.Game.Backend.Controllers
{
    [ODataRoutePrefix("games")]
    public class GamesController : ODataController
    {
        private ODataValidationSettings _validationSettings = new ODataValidationSettings();

        public IGamesService _service;

        public GamesController(IGamesService service)
        {
            _service = service;
        }

        [HttpGet]
        [EnableQuery]
        public IQueryable<Game.Model.Game> Get()
        {
            return _service.Get();
        }
    }
}