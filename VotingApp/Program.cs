using Core.Persistence;
using Core.Services;
using Data;

namespace VotingApp
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
            Database database = new Database();
            Application.Run(new VoterReg(new RegistrationService(new VoterRepository(database)),database));
        }
    }
}