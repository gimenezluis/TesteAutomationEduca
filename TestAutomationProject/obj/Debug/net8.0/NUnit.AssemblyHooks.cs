// <auto-generated />
#pragma warning disable

using System.CodeDom.Compiler;
using System.Diagnostics;
using global::System.Runtime.CompilerServices;
using System.Threading.Tasks;

[GeneratedCode("SpecFlow", "4.0.15-beta")]
[global::NUnit.Framework.SetUpFixture]
public class TestAutomationProject_NUnitAssemblyHooks
{
    [global::NUnit.Framework.OneTimeSetUp]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public async Task AssemblyInitializeAsync()
    {
        var currentAssembly = typeof(TestAutomationProject_NUnitAssemblyHooks).Assembly;
        await global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunStartAsync(currentAssembly);
    }

    [global::NUnit.Framework.OneTimeTearDown]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public async ValueTask AssemblyCleanupAsync()
    {
        var currentAssembly = typeof(TestAutomationProject_NUnitAssemblyHooks).Assembly;
        await global::TechTalk.SpecFlow.TestRunnerManager.OnTestRunEndAsync(currentAssembly);
    }
}
#pragma warning restore
