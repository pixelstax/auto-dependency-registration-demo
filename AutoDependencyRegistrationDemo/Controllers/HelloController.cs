using AutoDependencyRegistrationDemo.Business.Services;
using AutoDependencyRegistrationDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoDependencyRegistrationDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IDifferentProject _differentProject;
    private readonly ITransientService _transientService;
    private readonly ISingletonService _singletonService;
    private readonly IScopedService _scopedService;

    public WeatherForecastController(
        IDifferentProject differentProject,
        ITransientService transientService,
        ISingletonService singletonService,
        IScopedService scopedService)
    {
        _differentProject = differentProject;
        _transientService = transientService;
        _singletonService = singletonService;
        _scopedService = scopedService;
    }

    [HttpGet(Name = "Hello")]
    public string Get()
    {
        var json = _differentProject.DemoService() + _transientService.DemoService() + _singletonService.DemoService() +
               _scopedService.DemoService();
        
        var json2 = _differentProject.DemoService() + _transientService.DemoService() + _singletonService.DemoService() +
                    _scopedService.DemoService();

        return json + "\n" + json2;
    }
}