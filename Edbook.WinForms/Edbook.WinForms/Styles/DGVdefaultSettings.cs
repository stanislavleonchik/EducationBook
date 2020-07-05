using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Edbook.WinForms.Styles
{
    class DGVdefaultSettings
    {
        public static void FormationDGV(DataGridView DGV)
        {
            #region DataGridView - привилегии
            // Запрещаем пользователю непосредственное редактирование DataGridView
            DGV.AllowUserToAddRows =    false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AllowUserToResizeRows = false;
            DGV.MultiSelect =           false;
            DGV.ReadOnly =              true;
            DGV.SelectionMode = 
                DataGridViewSelectionMode.FullRowSelect;
            #endregion

            #region DataGridView - дизайн
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Содержимое DGV будет растягиваться
            DGV.RowHeadersVisible = false;                                  // Отключаем левый header
            DGV.ForeColor = Color.Gray;                                     // Цвет текста - Серый
            DGV.BackgroundColor = Color.Gainsboro;                          // Цвет заднего фона - Gainsboro
            DGV.BorderStyle = BorderStyle.None;                             // Убираем границы

            // Стиль выделенных ячеек
            // DGV.DefaultCellStyle.SelectionForeColor = Color.White;
            // DGV.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;

            // DGV.DefaultCellStyle.BackColor = Color.White;
            // DGV.DefaultCellStyle.SelectionBackColor =
            //    DGV.DefaultCellStyle.BackColor;
            // DGV.AlternatingRowsDefaultCellStyle.
            //    BackColor = Color.Gainsboro;
            // DGV.AlternatingRowsDefaultCellStyle.
            //     SelectionBackColor = DGV.AlternatingRowsDefaultCellStyle.
            //     BackColor;
            //DGV.CellBorderStyle = DataGridViewCellBorderStyle.None;

            //DGV.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 200, 66, 66);

            // Заголовок
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV.ColumnHeadersHeight = 40;
            #endregion
        }
    }
}
