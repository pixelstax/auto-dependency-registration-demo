namespace AutoDependencyRegistrationDemo.Services;

public class TransientService : ITransientService
{
    private readonly Guid _guid;

    public TransientService()
    {
        _guid = Guid.NewGuid();
    }
    
    public string DemoService()
    {
        return "\nTransient: " + _guid;
    }
}