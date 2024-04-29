using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExaminationSystems
{
    public partial class Table : Form
    {
        public Table() => InitializeComponent();

        private void Table_Load(object sender, EventArgs e)
        {
            using (SqlConnection Connect = new SqlConnection("Data Source='';Integrated Security=True"))
            {
                Connect.Open();

                using (SqlCommand Command = new SqlCommand("[ ExaminationSystems_DB].[dbo].[Get All Order]", Connect))
                {
                    Command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader Reader = Command.ExecuteReader();

                    DataTable DataTable = new DataTable(); DataTable.Load(Reader);
                    DATA.DataSource = DataTable;
                }

                Connect.Close();
            }
        }
    }
}