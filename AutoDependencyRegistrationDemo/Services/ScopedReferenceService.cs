namespace AutoDependencyRegistrationDemo.Services;

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