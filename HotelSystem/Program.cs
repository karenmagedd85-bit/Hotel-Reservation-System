namespace HotelSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Nav.Start();                    // opens the login page
            Application.Run(Nav.Context);   // the app stays alive while pages switch
        }
    }
}
