using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_project.GlobalClasses
{
    public partial class CustomDataGridView : UserControl
    {       
        private int _selectedColumnIndex = -1;
        private int _selectedRowIndex = -1;
        public CustomDataGridView()
        {
            InitializeComponent();
            ApplyStyle();
            dgvBindData.CellClick += dgvBindData_CellClick_1;
            dgvBindData.CellMouseEnter += dgvBindData_CellMouseEnter;
            dgvBindData.CellMouseLeave += dgvBindData_CellMouseLeave;
        }
        public DataGridView InnerGrid => dgvBindData;

        public object GetSelectedCellValue(int columnIndex)
        {
            if (_selectedRowIndex >= 0 && columnIndex >= 0 && columnIndex < InnerGrid.Columns.Count)
            {
                return InnerGrid.Rows[_selectedRowIndex].Cells[columnIndex].Value;
            }
            return null;
        }
        public void refreshGrid()
        {
            dgvBindData.Refresh();
        }
        public void BindData(DataTable table)
        {
            if (table.Columns.Count > 0)
            {
                //dgvBindData.Columns.Clear();
                //dgvBindData.DataSource = table;
                if (table == null || table.Columns.Count == 0)
                    return;

                _selectedColumnIndex = -1;
                _selectedRowIndex = -1;

                dgvBindData.DataSource = null;
                dgvBindData.Columns.Clear();
                dgvBindData.DataSource = table;

                dgvBindData.Refresh(); // Force visual update
                dgvBindData.ClearSelection(); // Optional: remove selection
            }
        }
        private void dgvBindData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                      
        }
        private void HighlightSelectedColumn()
        {
            Color orangeBackColor = Color.FromArgb(255, 230, 200);
            Color orangeForeColor = Color.FromArgb(255, 100, 0);
            foreach (DataGridViewRow row in dgvBindData.Rows)
            {
                for (int i = 0; i < dgvBindData.Columns.Count; i++)
                {
                    var cell = row.Cells[i];
                    if (i == _selectedColumnIndex)
                    {
                        cell.Style.BackColor = orangeBackColor;
                        cell.Style.ForeColor = Color.Black;
                        cell.Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    }
                    else
                    {
                        cell.Style.BackColor = Color.White;
                        cell.Style.ForeColor = Color.Black;
                        cell.Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    }
                }
            }
        }
        private void ApplyStyle()
        {           
            // Grid background
            dgvBindData.BackgroundColor = Color.FromArgb(255, 230, 200); // soft orange-like color

            // Header Style
            dgvBindData.EnableHeadersVisualStyles = false;
            dgvBindData.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange; // Header in orange
            dgvBindData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvBindData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvBindData.ColumnHeadersHeight = 35;

            // Row Style
            dgvBindData.DefaultCellStyle.BackColor = Color.White;
            dgvBindData.DefaultCellStyle.ForeColor = Color.Black;
            dgvBindData.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvBindData.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dgvBindData.DefaultCellStyle.SelectionForeColor = Color.FromArgb(23, 21, 32);

            // Alternating rows
            dgvBindData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 240, 220);

            // Grid lines
            dgvBindData.GridColor = Color.Orange;

            // Border and layout
            dgvBindData.BorderStyle = BorderStyle.None;
            dgvBindData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBindData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBindData.RowHeadersVisible = false;
            dgvBindData.RowTemplate.Height = 30;
        }
        private void dgvBindData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            _selectedColumnIndex = e.ColumnIndex;
            _selectedRowIndex = e.RowIndex;
            HighlightSelectedColumn();
        }
        private void dgvBindData_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dgvBindData.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(230, 240, 255);

        }
        private void dgvBindData_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                dgvBindData.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;

        }
        public int GetSelectedRowFirstColumnValue()
        {
            try
            {
                if (_selectedRowIndex >= 0 && InnerGrid.Rows.Count > _selectedRowIndex)
                {
                    object value = InnerGrid.Rows[_selectedRowIndex].Cells[0].Value;
                    if (value != null && int.TryParse(value.ToString(), out int result))
                    {
                        return result;
                    }
                }
            }
            catch
            {
                return -1;
            }
            return -1;
        }
        
    }
}
