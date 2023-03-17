using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Чек
    /// </summary>
    public class Check : BaseEntity
    {
        public int SessionID { get; set; }
        public int CashBoxID { get; set; }
        
        [NotMapped]
        public string OrganizationName { get { return CashBox?.Organization?.Name; } }

        [NotMapped]
        public string OrganizationINN { get {  return CashBox?.Organization?.INN; } }

        public DateTime? Date { get; set; }
        
        /// <summary>
        /// тип операции(продажа, возврат и т.д.)
        /// </summary>
        public OrderType Type { get; set; }

        [ForeignKey("CashBoxID")]
        public CashBox CashBox { get; set; }

        //[ForeignKey("SessionID")]
        //public Session Session { get; set; }


        /// <summary>
        /// Перечень товаров в чеке
        /// </summary>
        public ICollection<CheckRow> Rows { get; set; }

        /// <summary>
        /// общая сумма чека (сумма к оплате)
        /// </summary>
        public decimal Sum { get; set; }
        
        
        /// <summary>
        /// сумма от клиента (су)
        /// </summary>
        [NotMapped]
        public decimal SumFact { get; set; }
        
        [NotMapped]
        public decimal SumSaldo { get { return SumFact - Sum; } }
        public string ResultPrintView { get; set; }

        public bool IsCashBack { get; set; }

        [NotMapped]
        public Session Session { get; private set; }

        public void Calc()
        {
            Sum = Rows.Sum(x => x.Summ);
        }

        public Check()
        {
            Rows = new List<CheckRow>();
            Date = DateTime.Now;
        }

        public Check(Session session)
        {
            SessionID = session.ID;
            Session = session;

            Rows = new List<CheckRow>();
            Date = DateTime.Now;
        }

        public string AsPrintView()
        {
            List<string> rows = new List<string>();
            rows.Add(OrganizationName);
            rows.Add("ИНН:" + OrganizationINN);
            rows.Add("Адрес:" +CashBox.Seller.Adress);
            rows.Add("Дата "+ Date?.ToLongDateString());
            rows.Add("Кассир: " + Session.User.Name);
            rows.Add("***********************************");
            rows.Add("Чек № : " + ID);

            rows.AddRange(Rows.Select((x,n) => $"{n+1}. {x.Product.Name} - {x.Count} * {x.Product.Price} р. = {x.Count* x.Product.Price}"));
            rows.Add("***********************************");
            rows.Add($"К ОПЛАТЕ:  {Sum}");
            switch (Type)
            {
                case OrderType.PayCash:
                    rows.Add("----Наличный расчет----");
                    break;
                case OrderType.PayCard:
                    rows.Add("----Безналичный расчет----");
                    rows.Add("-------Код операции-------");
                    rows.Add($"{Guid.NewGuid().ToString("N")}");
                    break;
                case OrderType.Incass:
                    break;
                case OrderType.CashBack:
                    break;
                default:
                    break;
            }
            rows.Add("***********************************");
            rows.Add("Спасибо за покупку!");
            ResultPrintView = String.Join(System.Environment.NewLine,rows);
            return ResultPrintView;
        }

    }

    /// <summary>
    /// Типы оплат
    /// </summary>
    public enum OrderType : byte
    {
        /// <summary>
        /// Оплата наличными
        /// </summary>
        PayCash = 0,

        /// <summary>
        /// Оплата банк. картой
        /// </summary>
        PayCard = 1,


        Incass = 2,
        CashBack = 3
    }
}
