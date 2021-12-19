namespace SyncVsAsyncBouncyBox
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            IDatabase fakeDatabaseService = new FakeDatabaseService();
            Application.Run(new FormBouncyBox(fakeDatabaseService));
        }
    }
}