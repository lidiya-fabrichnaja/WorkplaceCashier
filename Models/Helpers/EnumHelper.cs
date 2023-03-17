using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Models.Helpers
{
    public static class EnumHelper
    {
        /// <summary>
        /// Получить описание
        /// (возвращает значение атрибута Description для Enum)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDescription(Enum value)
        {
           
            FieldInfo fi = value.GetType().GetField(value.ToString());
           
            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }

        public static IList<EnumData> AsDataSource<T>() where T : Enum
        {
            return (from T x in Enum.GetValues(typeof(T))
                     select new EnumData{ Value = x, Name = GetDescription(x) }).ToList();
        }
    }

    public class EnumData
    {
        public object Value { get; set; }

        public string Name { get; set; }
    }
}
