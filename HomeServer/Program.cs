using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace HomeServer
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
       // [STAThread]
        [STAThreadAttribute]

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainform main = new mainform();

            // Thread notifyThread = new Thread(
            //  delegate ()
            //  {
            var menu = new ContextMenu();
            var mnuExit = new MenuItem("Выход");
            var mnuShow = new MenuItem("Показать");
            menu.MenuItems.Add(0, mnuExit);
            menu.MenuItems.Add(0, mnuShow);

            var notificationIcon = new NotifyIcon()
            {
                Icon = Properties.Resources.globe,
                ContextMenu = menu,
                Text = "HomeServer - Media Center"
            };
            mnuExit.Click += delegate
            {
                notificationIcon.Dispose();
                Process.GetCurrentProcess().Kill();
                Application.Exit();

            };
            mnuShow.Click += delegate { main.Show(); main.start_mc.PerformClick(); };

            notificationIcon.Visible = true;
            Application.Run(main);
            //  });
            //  notifyThread.Start();


        }
    }
}
