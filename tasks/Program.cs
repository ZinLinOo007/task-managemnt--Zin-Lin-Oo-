using System.Configuration;

namespace tasks
{
    internal static class Program
    {
        public static String conntionString = ConfigurationManager.ConnectionStrings["Task"].ConnectionString;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TaskForm());
        }
    }
}