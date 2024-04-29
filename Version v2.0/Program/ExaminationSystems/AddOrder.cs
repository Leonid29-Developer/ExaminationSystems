using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystems
{
    public partial class AddOrder : Form
    {
        public AddOrder() => InitializeComponent();

        private void Create_Button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Connect = new SqlConnection("Data Source='';Integrated Security=True"))
                {
                    Connect.Open();

                    using (SqlCommand Command = new SqlCommand("[ ExaminationSystems_DB].[dbo].[AddOrder]", Connect))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.Add("@ProductName", SqlDbType.NVarChar, 50); Command.Parameters["@ProductName"].Value = Statement_Name.Text;
                        Command.Parameters.Add("@CompanyApplicantName", SqlDbType.NVarChar, 50); Command.Parameters["@CompanyApplicantName"].Value = StatementOrganization_Name.Text;
                        Command.Parameters.Add("@CompanyApplicantAddress", SqlDbType.NVarChar, 100); Command.Parameters["@CompanyApplicantAddress"].Value = StatementOrganization_Address.Text;
                        Command.Parameters.Add("@CompanyManufacturerName", SqlDbType.NVarChar, 50); Command.Parameters["@CompanyManufacturerName"].Value = ManufacturerOrganization_Name.Text;
                        Command.Parameters.Add("@CompanyManufacturerAddress", SqlDbType.NVarChar, 100); Command.Parameters["@CompanyManufacturerAddress"].Value = ManufacturerOrganization_Address.Text;

                        Command.ExecuteNonQuery();
                    }

                    Connect.Close();
                }

                throw new Exceptions.Information.Successfully();
            }
            catch (Exceptions.Information.Successfully Ex)
            {
                MessageBox.Show(Ex.Message, Ex.Data["Say"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
