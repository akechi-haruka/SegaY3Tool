using System.Reflection;

namespace SegaY3Tool;

static class Program {
    public static readonly string TITLE;

    static Program() {
        string gitHash = Assembly.Load(typeof(Program).Assembly.FullName!)
            .GetCustomAttributes<AssemblyMetadataAttribute>()
            .FirstOrDefault(attr => attr.Key == "GitHash")?.Value;

        AssemblyName assemblyInfo = Assembly.GetExecutingAssembly().GetName();
        TITLE = assemblyInfo.Name + "/" + assemblyInfo.Version + "-" + gitHash + " - Akechi Haruka";
    }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new FormControl());
    }
}