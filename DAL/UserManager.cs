using DAL.Commons;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class UserManager
    {
        /// <summary>
        /// валидация данных, введенных пользователем
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static ActionResult Validate(string login, string password)
        {

            if (string.IsNullOrEmpty(login)) return new ActionResult("Не указан логин");

            if (string.IsNullOrEmpty(password)) return new ActionResult("Не указан пароль");

            if (IsContainsBrokenChar(login)) return new ActionResult("В поле логин имеются недопустимые символы ...");

            if (IsContainsBrokenChar(password)) return new ActionResult("В поле password имеются недопустимые символы ...");

            return new ActionResult();
        }

        /// <summary>
        /// аутентификация пользвоателя
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static User Login(string login, string password) 
        {
           
            using (var _ctx = new Context()) {
                return _ctx.Users.AsNoTracking().FirstOrDefault(x => x.Login == login && x.Password == password);
            }
        }
        /// <summary>
        /// проверка на запрещенные символы
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsContainsBrokenChar(string value)
        {
           
            char[] brokenChars = new char[] {
                '\'',
                '%'
            };
            int fl= value.IndexOfAny(brokenChars);
            if (fl != -1)
                return true;

            return false;
        }
    }
}
