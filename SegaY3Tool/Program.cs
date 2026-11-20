using System.Reflection;
using Haruka.Arcade.SEGA835Lib.Devices;
using Haruka.Arcade.SEGA835Lib.Devices.Misc;

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
    
    public static void ReportBoardErrorUi(Form parent, DeviceStatus ret, Y3 y3, String message = null) {
        uint errorCode = y3.GetBoardErrorCode();
        String errorMessage = errorCode > 0 ? y3.GetBoardErrorMessage(errorCode) : "---";
        Y3.Status status = y3.GetStatus();
        MessageBox.Show(parent, "Error during " + (message ?? "operation") + ":\n\nOperation Result: " + ret + "\nBoard Status: " + status + " (0x" + ((int)status).ToString("X") + ")" + "\nOperation Error: " + errorCode + " / " + errorMessage, Program.TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}