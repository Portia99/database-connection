using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB1Project
{
    public partial class mainForm : Form
    {
        
        public mainForm()
        {
            InitializeComponent();            
            
        }
      
        private void mainForm_Load(object sender, EventArgs e)
        {
            string sqlQuery = "select * from titles";

            DataTable dt = DataBaseConnection.dataAdapterSelect(sqlQuery);

            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr["title_id"], dr["title"]);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Column1"].Value.ToString());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addForm aForm = new addForm();
            aForm.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
