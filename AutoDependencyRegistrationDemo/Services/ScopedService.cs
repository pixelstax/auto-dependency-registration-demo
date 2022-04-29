﻿namespace AutoDependencyRegistrationDemo.Services;

public class ScopedService : IScopedService
{
    private readonly Guid _guid;

    public ScopedService()
    {
        _guid = Guid.NewGuid();
    }
    
    public string DemoService()
    {
        return "\nScoped: " + _guid.ToString();
    }
}