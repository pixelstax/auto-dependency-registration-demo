using AutoDependencyRegistrationDemo.Business.Services;
using AutoDependencyRegistrationDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoDependencyRegistrationDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class ServiceExampleController : ControllerBase
{
    private readonly IDifferentProject _differentProject;
    private readonly ITransientService _transientService;
    private readonly ISingletonService _singletonService;
    private readonly IScopedService _scopedService;
    
    private readonly IScopedReference _scopedReference;
    private readonly ITransientReference _transientReference;

    public ServiceExampleController(
        IDifferentProject differentProject,
        ITransientService transientService,
        ISingletonService singletonService,
        IScopedService scopedService,
        IScopedReference scopedReference, ITransientReference transientReference)
    {
        _differentProject = differentProject;
        _transientService = transientService;
        _singletonService = singletonService;
        _scopedService = scopedService;
        _scopedReference = scopedReference;
        _transientReference = transientReference;
    }

    [HttpGet]
    [Route("demo")]
    public string Get()
    {
        return _differentProject.DemoService() + _transientService.DemoService() + _singletonService.DemoService() +
               _scopedService.DemoService() + "\n\n" + _scopedReference.Demo() + _transientReference.Demo();
    }
}