using AutoDependencyRegistration.Attributes;

namespace AutoDependencyRegistrationDemo.Services;

[RegisterClassAsTransient]
public class TransientService : ITransientService
{
    public TransientService()
    {
        _guid = Guid.NewGuid();
    }
    
    private readonly Guid _guid;
    public string DemoService()
    {
        return "\nTransient: " + _guid;
    }
}