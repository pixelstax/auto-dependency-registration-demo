using AutoDependencyRegistration.Attributes;

namespace AutoDependencyRegistrationDemo.Business.Services;

[RegisterClassAsTransient]
public class DifferentProjectService : IDifferentProject
{
    private readonly Guid _guid;

    public DifferentProjectService()
    {
        _guid = Guid.NewGuid();
    }
    
    public string DemoService()
    {
        return "Different project: " + _guid;
    }
}