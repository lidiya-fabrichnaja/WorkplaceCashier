using Models.Abstactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Abstractions
{

    /// <summary>
    /// редактор сущности
    /// </summary>
    /// <typeparam name="Tentity"></typeparam>
    public interface IEntityEditor<Tentity> where Tentity : class, IGridRow ,IEntity 
    {
        /// <summary>
        /// ссылка на форму
        /// </summary>
        Form Form { get; }

        /// <summary>
        /// метод реализующий привязку свойств сущности к элементам управления формы редактора
        /// </summary>
        /// <param name="entity"></param>
        void Bind(Tentity entity);
    }
}
