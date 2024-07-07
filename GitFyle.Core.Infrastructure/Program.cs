using GitFyle.Core.Infrastructure.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var generateScriptservice = new ScriptGenerationService();
        generateScriptservice.GenerateBuildScript();
    }
}