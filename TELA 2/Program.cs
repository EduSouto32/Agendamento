using FluentScheduler;
using System;
using System.Windows.Forms;

namespace Backup
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Initialize JobManager with BackupScheduler
            JobManager.Initialize(new TELA_2.BackupScheduler());

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
