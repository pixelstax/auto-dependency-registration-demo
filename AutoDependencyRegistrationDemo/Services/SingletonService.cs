using AutoDependencyRegistration.Attributes;

namespace AutoDependencyRegistrationDemo.Services;

[RegisterClassAsSingleton]
public class SingletonService : ISingletonService
{
    private readonly Guid _guid;

    public SingletonService()
    {
        _guid = Guid.NewGuid();
    }
    
    public string DemoService()
    {
        return "\nSingleton: " + _guid;
    }
}