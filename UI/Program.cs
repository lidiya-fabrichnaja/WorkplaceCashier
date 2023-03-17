using Models;
using Models.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    static class Program
    {
        public static User User;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            Application.SetCompatibleTextRenderingDefault(false);

            DAL.DataContainer.Init();

// Если запуск в отладчике, запускаем интерфейс администратора
#if DEBUG
            User = DAL.DataContainer.GetContext().Users.FirstOrDefault(x => x.Type == UserType.Administrator);
            Application.Run(new FormAdminWorkspace());
#else
            //Иначе бросаем на форму аутентификации

             var frm = new FormAuthorization();
            if (frm.ShowDialog() == DialogResult.OK)
            {
               
                User = frm.User;

                switch (frm.User.Type)
                {
                    case Models.UserType.Salesman:
                        var frmSession = new FormSession(User);
                        if (frmSession.ShowDialog() == DialogResult.OK)
                        {
                            Application.Run(new FormSellerWorkspace(frmSession.Session));
                        }
                        break;
                    case Models.UserType.Administrator:
                        Application.Run(new FormAdminWorkspace());
                        break;
                    default:
                        MessageBox.Show($"Для роли {EnumHelper.GetDescription(frm.User.Type)} не реализовано поведение");
                        break;
                }
            }
#endif

        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {

            // Показываем текст сообщения и ожидаем действие пользователя
            DialogResult result = MessageBox.Show("В приложении произошла ошибка:\r\n" + e.Exception.Message + "\r\nДля продолжения работы нажмите (Да)", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            // Если пользователь отказался от продолжения работы - запускаем приложение в новом окне и завершаем в текущем
            if (result == DialogResult.No)
            {
                Process.Start(Application.ExecutablePath);
                var prc = Process.GetCurrentProcess();
                prc.Kill();
            }

        }
    }
}
