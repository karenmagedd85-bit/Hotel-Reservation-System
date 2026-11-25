namespace HotelSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                Nav.Start();
                Application.Run(Nav.Context);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    ex.ToString(),
                    "Startup error");
            }
        }
    }
}