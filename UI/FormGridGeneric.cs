using DAL.Repositories;
using Models.Abstactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Abstractions;

namespace UI
{
    public class FormGrid<T> : FormGrid where T : class, IGridRow, IEntity, new()
    {
        CommonRepository<T> _repository;

        IEntityEditor<T> _editor;
 
        BindingSource _bs;

        public T Current
        {
            get
            {
                if (_bs == null) return null;
                return _bs.Current as T;
            }
        }

        public FormGrid(IEntityEditor<T> editor)
        {
            _repository = new CommonRepository<T>();
            _editor = editor;


       //     InitializeComponent();

            dgv.AutoGenerateColumns = false;
            dgv.AllowDrop = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToAddRows = false;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        /// <summary>
        /// Метод добавляет новую колонку к табличному представлентю
        /// </summary>
        /// <param name="text">текст закголовка колонки</param>
        /// <param name="fieldName">имя свойства сущности</param>
        public void AddColumn(string text, string fieldName)
        {
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = text,
                Name = "col_" + fieldName,
                DataPropertyName = fieldName
            });
        }

        public void UpdateGrid()
        {
            int? index = dgv.CurrentRow?.Index;

            _bs = new BindingSource { DataSource = _repository.GetAll().ToList() };
            dgv.DataSource = _bs;

            if (index != null)
            {

                if (dgv.Rows.GetRowCount(DataGridViewElementStates.Visible) > index && index != default(int))
                {
                    dgv.FirstDisplayedScrollingRowIndex = index.Value;

                    dgv.CurrentCell = dgv.Rows[index.Value].Cells[0];
                }
            }
        }

        internal override void btnAdd_Click(object sender, EventArgs e)
        {
            T entity = _repository.New();

            _editor.Bind(entity);

            if (_editor.Form.ShowDialog() == DialogResult.OK)
            {
                _repository.Add(entity);

                UpdateGrid();
            }
        }

        internal override void btnDel_Click(object sender, EventArgs e)
        {
            if (Current == null) return;

            if (MessageBox.Show("Удалить выбранный объект:" + Current.Name, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _repository.Remove(Current);

                UpdateGrid();
            }
        }

        internal override void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (Current == null) return;


            _editor.Bind(Current);
            if (_editor.Form.ShowDialog() == DialogResult.OK)
            {
                _repository.Update(Current);
                UpdateGrid();
            }
            else
            {
                  _repository.RollBack();
                UpdateGrid();
            }
        }

        internal override void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(null, null);
        }
    }
}
