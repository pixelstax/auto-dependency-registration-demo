using AutoDependencyRegistration.Attributes;

namespace AutoDependencyRegistrationDemo.Services;

[RegisterClassAsScoped]
public class ScopedReferenceService : IScopedReference
{
    private readonly IScopedService _scopedService;

    public ScopedReferenceService(IScopedService scopedService)
    {
        _scopedService = scopedService;
    }

    public string Demo()
    {
        return _scopedService.DemoService();
    }
}