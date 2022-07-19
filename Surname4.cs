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
    public partial class Surname4 : Form
    {

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Detishki.mdb";
        private OleDbConnection myConnection;

        public Surname4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            string Surname = textSearch2.Text;
            string query = "Select Name1, Surname, Patronymic, PayForm FROM FIO4 WHERE Surname LIKE '%" + Surname + "%'";
            OleDbDataAdapter command = new OleDbDataAdapter(query, myConnection);
            DataTable dt = new DataTable();
            command.Fill(dt);
            dataGridView2.DataSource = dt;
            myConnection.Close();
        }
    }
}
