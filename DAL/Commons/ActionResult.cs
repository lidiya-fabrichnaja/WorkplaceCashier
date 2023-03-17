using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Commons
{
    /// <summary>
    /// класс описывает результат действия
    /// </summary>
    public class ActionResult
    {
        /// <summary>
        /// статус действия
        /// </summary>
        public ActionStatus Status { get; set; }
        /// <summary>
        /// сообщение
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// по умолчанию результат = ОК
        /// </summary>
        public ActionResult()
        {
            Status = ActionStatus.Ok;
        }
        /// <summary>
        /// принимает сообщение об ошибке, результат равен ошибке
        /// </summary>
        public ActionResult(string message = "")
        {
            Status = ActionStatus.Error;
            Message = message;
        }
       
        public ActionResult(ActionStatus status, string message = "")
        {
            Status = status;
            Message = message;
        }
    }


}
