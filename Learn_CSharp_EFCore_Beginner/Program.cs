namespace Learn_CSharp_EFCore_Beginner
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
            Application.Run(new LoginForm());

            LoginForm from = new LoginForm();
            if(from.ShowDialog() == DialogResult.OK) 
            { 
                Application.Run(new CustomerForm());    
            }
            else
            {
                Application.Exit();
            }
        }
    }
}