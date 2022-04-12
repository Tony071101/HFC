using MySql.Data.MySqlClient;

namespace QLHFC
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
            //Console.WriteLine("Getting Connection ...");
            //MySqlConnection conn = DBUtils.GetDBConnection();

            //try
            //{
            //    Console.WriteLine("Openning Connection ...");

            //    conn.Open();

            //    Console.WriteLine("Connection successful!");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //}

            //Console.Read();
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}