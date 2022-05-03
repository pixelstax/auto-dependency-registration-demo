using AutoDependencyRegistration.Attributes;

namespace AutoDependencyRegistrationDemo.Services;

[RegisterClassAsTransient]
public class TransientReference : ITransientReference
{
    private readonly ITransientService _transientService;

    public TransientReference(ITransientService transientService)
    {
        _transientService = transientService;
    }

    public string Demo()
    {
        return _transientService.DemoService();
    }
}