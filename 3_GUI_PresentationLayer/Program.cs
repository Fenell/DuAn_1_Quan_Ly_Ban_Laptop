using _3_GUI_PresentationLayer.View;

namespace _3_GUI_PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            FrmMain f = new FrmMain();
            Application.Run(f);

           
        }
    }
}