using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NumberCrunch.Business;
using NumberCrunch.Business.DataModels;

namespace NumberCrunchAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CrunchController : ControllerBase
    {
        private readonly ILogger<CrunchController> _logger;
        private readonly ICrunchLogic _logic;

        public CrunchController(ILogger<CrunchController> logger, ICrunchLogic logic)
        {
            _logger = logger;
            _logic = logic;
        }

        [HttpGet]
        public CrunchDataModel Get()
        {
            return new CrunchDataModel();
        }

        [HttpPost]
        public ScoreDataModel Post(CrunchDataModel data)
        {
            return _logic.CrunchNumbers(data);
        }
    }
}
