namespace AutoDependencyRegistrationDemo.Services;

public class TransientClass
{
    private readonly Guid _guid;

    public TransientClass()
    {
        _guid = Guid.NewGuid();
    }
    
    public string DemoService()
    {
        return _guid.ToString();
    }
}