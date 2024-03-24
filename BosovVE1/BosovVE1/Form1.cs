using _2;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BosovVE1
{
    public partial class Form1 : Form
    {
        DB dB =  new DB();
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID", "id");
            dataGridView1.Columns.Add("Title", "название");
            dataGridView1.Columns.Add("cost", "цена");




        }
        private void readsinglerouse(DataGridView dgw,IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1),record.GetInt32(2));
           
        }
        private void refereh(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string qeri = $" select *from dbo.Product ";
            SqlCommand command = new SqlCommand(qeri,dB.GetConnection());
            dB.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                readsinglerouse(dgw, reader);


            }
            reader.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CreateColumns();
            refereh(dataGridView1);
        }
    }
}
