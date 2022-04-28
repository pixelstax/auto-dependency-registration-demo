namespace AutoDependencyRegistrationDemo.Services;

public class SingletonService : ISingletonService
{
    private readonly Guid _guid;

    public SingletonService()
    {
        _guid = Guid.NewGuid();
    }
    
    public string DemoService()
    {
        return " Singleton: " + _guid.ToString();
    }
}