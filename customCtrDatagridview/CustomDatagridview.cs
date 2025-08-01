using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace customCtrDatagridview
{
    public partial class CustomDatagridview: DataGridView
    {
    
        private int _selectedColumnIndex = -1;

        public CustomDatagridview()
        {
            InitializeComponent();
            ApplyStyle();
        }

        private void ApplyStyle()
        {
            // Header Style
            dgvBindData.EnableHeadersVisualStyles = false;
            dgvBindData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30); // Dark header
            dgvBindData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBindData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvBindData.ColumnHeadersHeight = 35;

            // Row Style
            dgvBindData.DefaultCellStyle.BackColor = Color.White;
            dgvBindData.DefaultCellStyle.ForeColor = Color.Black;
            dgvBindData.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvBindData.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 100, 250); // hover/select color
            dgvBindData.DefaultCellStyle.SelectionForeColor = Color.White;

            // Grid style
            dgvBindData.BorderStyle = BorderStyle.None;
            dgvBindData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBindData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBindData.RowHeadersVisible = false;

            // Row height
            dgvBindData.RowTemplate.Height = 30;

            // Optional: alternating row colors
            dgvBindData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            //dgvBindData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            // Reset all cells to default style
            foreach (DataGridViewRow row in dgvBindData.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                    cell.Style.ForeColor = Color.Black;
                }
            }

            // Highlight selected column
            foreach (DataGridViewRow row in dgvBindData.Rows)
            {
                row.Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
                row.Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
            }
        }



        public void BindData(DataTable table)
        {
            if(table.Columns.Count > 0)
            {
                dgvBindData.Columns.Clear();
                dgvBindData.DataSource=table;
            }
        }

        private void dgvBindData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            _selectedColumnIndex = e.ColumnIndex;
            HighlightSelectedColumn();
        }

        private void HighlightSelectedColumn()
        {
            foreach (DataGridViewRow row in dgvBindData.Rows)
            {
                for (int i = 0; i < dgvBindData.Columns.Count; i++)
                {
                    var cell = row.Cells[i];
                    if (i == _selectedColumnIndex)
                    {
                        cell.Style.BackColor = Color.LightBlue;
                        cell.Style.ForeColor = Color.Black;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.White;
                        cell.Style.ForeColor = Color.Black;
                    }
                }
            }
        }

    }
}
