using AutoDependencyRegistration.Attributes;

namespace AutoDependencyRegistrationDemo.Services;

[RegisterClassAsSingleton]
public class SingletonReference : ISingletonReference
{
    private readonly ISingletonService _singletonService;

    public SingletonReference(ISingletonService singletonService)
    {
        _singletonService = singletonService;
    }

    public string Demo()
    {
        return _singletonService.DemoService();
    }
}