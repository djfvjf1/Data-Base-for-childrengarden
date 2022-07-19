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

    public partial class Form1 : Form
    {

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Detishki.mdb";
        private OleDbConnection myConnection;
        //private OleDbCommand command;
        

        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "detishkiDataSet2.Attendance". При необходимости она может быть перемещена или удалена.
            this.attendanceTableAdapter.Fill(this.detishkiDataSet2.Attendance);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "detishkiDataSet2.FIO". При необходимости она может быть перемещена или удалена.
            this.fIOTableAdapter.Fill(this.detishkiDataSet2.FIO);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "detishkiDataSet2.Data". При необходимости она может быть перемещена или удалена.
            this.dataTableAdapter.Fill(this.detishkiDataSet2.Data);
            

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(textBox1.Text);
                string query = "DELETE FROM FIO WHERE [ID] = " + ID;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Данные о ребенке удалены");
                this.fIOTableAdapter.Fill(this.detishkiDataSet2.FIO);
            }
            catch(Exception ex)
            {
                
                dataFIOBindingSource.ResetBindings(false);
            }
            
        }*/



        private void button4_Click(object sender, EventArgs e)
        {
            this.fIOTableAdapter.Fill(this.detishkiDataSet2.FIO);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void формаОплатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.fIOTableAdapter.Fill(this.detishkiDataSet2.FIO);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void фамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Owner = this;
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTableAdapter.Update(this.detishkiDataSet2);
                this.fIOTableAdapter.Update(this.detishkiDataSet2);
                this.attendanceTableAdapter.Update(this.detishkiDataSet2);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
