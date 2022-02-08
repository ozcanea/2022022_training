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

namespace _2022022_training
{
    public partial class Form1 : Form
    {
        //query formun altında
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=.; database=northwind; UID=sa; PWD=admin");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText="sp_Shippers";   
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                int effected = cmd.ExecuteNonQuery();
                MessageBox.Show(effected + " Row Effected");
            }
            catch (InvalidCastException ice)
            {
                MessageBox.Show(ice.Message);
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBÜrün.Items.Add("... ile başlayanlar");
            cBÜrün.Items.Add("... içerenler");
            cBÜrün.Items.Add("... ile bitenler");
            cBÜrün.SelectedIndex = 0;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            lBUrun.Items.Clear();
            try
            {
                cmd.CommandText = "sp_UrunAra";
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                switch (cBÜrün.SelectedIndex)
                {
                    case 0:
                        cmd.Parameters.AddWithValue("@Name", txtArama.Text + "%");
                        break;
                    case 1:
                        cmd.Parameters.AddWithValue("@Name", "%" + txtArama.Text + "%");
                        break;
                    case 2:
                        cmd.Parameters.AddWithValue("@Name", "%" + txtArama.Text);
                        break;
                }
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                 dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lBUrun.Items.Add(dr["ProductName"].ToString());
                    }
                    MessageBox.Show(lBUrun.Items.Count.ToString());
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cmd.Dispose();
                cmd.Parameters.Clear();// parametreleri clearlamazsak programı kapatmadan tekrar kullanmak istersek exeption veriyor.!!!
                conn.Close();
               
            }

            //
            /* CREATE OR ALTER PROC sp_Shippers
            @CompanyName NVARCHAR(40),
@PHONE NVARCHAR(24)
AS
BEGIN
IF EXISTS(SELECT* FROM Shippers WHERE CompanyName= @CompanyName AND Phone = @PHONE)
BEGIN
--UPDATE Shippers
--SET Phone = @PHONE
--WHERE CompanyName = @CompanyName
Print 'BU Şirket Bulunmaktadır'
END
BEGIN
INSERT INTO Shippers
VALUES(@CompanyName, @PHONE)
END
END;


            CREATE OR ALTER PROC UrunAra
            @Name NVARCHAR(40)
            as
            BEGIN
SELECT ProductName FROM Products WHERE ProductName LIKE @Name
END

            */


        }
    }
}
