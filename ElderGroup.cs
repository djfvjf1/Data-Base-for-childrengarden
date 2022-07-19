using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ChildrenDB
{
    public partial class ElderGroup : Form
    {
       
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Detishki.mdb";
        private OleDbConnection myConnection;
       // private OleDbCommand command;

        public ElderGroup()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void ElderGroup_Load(object sender, EventArgs e)
        {
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "detishkiDataSet2.Data2". При необходимости она может быть перемещена или удалена.
            this.data2TableAdapter.Fill(this.detishkiDataSet2.Data2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "detishkiDataSet.Attendance2". При необходимости она может быть перемещена или удалена.
            this.attendance2TableAdapter.Fill(this.detishkiDataSet2.Attendance2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "detishkiDataSet.FIO2". При необходимости она может быть перемещена или удалена.
            this.fIO2TableAdapter.Fill(this.detishkiDataSet2.FIO2);

        }

        private void ElderGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ID2 = Convert.ToInt32(textBox1.Text);
                string query = "DELETE FROM FIO2 WHERE [ID2] = " + ID2;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Данные о ребенке удалены");
                this.fIO2TableAdapter.Fill(this.detishkiDataSet2.FIO2);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Введите ID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                data2FIO2BindingSource.ResetBindings(false);
            }
            
        }*/

        

        private void button4_Click(object sender, EventArgs e)
        {
            this.fIO2TableAdapter.Fill(this.detishkiDataSet2.FIO2);
        }

        private void фамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Surname2 f5 = new Surname2();
            f5.Owner = this;
            f5.Show();
        }

        private void формаОплатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayForm2 f6 = new PayForm2();
            f6.Owner = this;
            f6.Show();
        }


        private void ElderGroup_Activated(object sender, EventArgs e)
        {
            this.fIO2TableAdapter.Fill(this.detishkiDataSet2.FIO2);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.data2TableAdapter.Update(this.detishkiDataSet2);
                this.fIO2TableAdapter.Update(this.detishkiDataSet2);
                this.attendance2TableAdapter.Update(this.detishkiDataSet2);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}















