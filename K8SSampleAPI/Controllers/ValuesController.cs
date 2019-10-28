namespace K8SSampleAPI.Controllers
{
    using K8SSampleAPI.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly ApplicationInfo applicationInfo;

        public ValuesController(IConfiguration configuration, ApplicationInfo applicationInfo)
        {
            this.configuration = configuration;
            this.applicationInfo = applicationInfo;
        }

        [HttpGet]
        public ActionResult<ApplicationResponse> Get()
        {
            return new ApplicationResponse
            {
                ApplicationId = applicationInfo.Id,
                APIKey = configuration.GetValue<string>("APIKey"),
                APISecret = configuration.GetValue<string>("APISecret")
            };
        }
    }
}
