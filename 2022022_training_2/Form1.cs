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

namespace _2022022_training_2
{
    public partial class Form1 : Form
    {
        SqlConnection con=ConnectionProvider.SqlConnection;
        SqlCommand cmd = new SqlCommand();
        SqlTransaction trns ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                cmd.CommandText = "SELECT FirstName,LastName From Client";
                cmd.Connection = con;
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        cBGonderen.Items.Add(reader.GetString(0) + " " + reader.GetString(1));
                        cBAlan.Items.Add(reader.GetString(0) + " " + reader.GetString(1));
                    }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
                cBGonderen.SelectedIndex = 0;
                cBAlan.SelectedIndex = 1;
                con.Close();
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand com = new SqlCommand();
                decimal para = Convert.ToDecimal(txtMiktar.Text);
                com.Dispose();
                com.Parameters.Clear();
                CommandSend(cmd, para, cBGonderen);
                CommandGet(com, para, cBAlan);
                
                if (con.State == ConnectionState.Closed)
                    con.Open();
                trns = con.BeginTransaction();

                cmd.Transaction = trns;
                cmd.ExecuteNonQuery();
                com.Transaction = trns;
                com.ExecuteNonQuery();
                trns.Commit();
                com.Dispose();
                com.Parameters.Clear();
            }
            catch (Exception ex)
            {
                trns.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
                cmd.Parameters.Clear();
                cmd.Dispose();
            }
        }
        void CommandSend(SqlCommand c, decimal p, ComboBox cb)
        {
            c.CommandText = "UPDATE Client SET Balance -= @Amount WHERE FirstName+' ' + LastName = @Name";
            c.Connection = con;
            c.Parameters.AddWithValue("@Name", cb.SelectedItem);
            c.Parameters.AddWithValue("@Amount", p);
        }
        void CommandGet(SqlCommand c,decimal p,ComboBox cb)
        {
            c.CommandText = "UPDATE Client SET Balance += @Amount WHERE FirstName+' ' + LastName = @Name";
            c.Connection = con;
            c.Parameters.AddWithValue("@Name", cb.SelectedItem);
            c.Parameters.AddWithValue("@Amount", p);
        }
        
        //void Execute(SqlCommand c)
        //{
        //    c.ExecuteNonQuery();
        //}

        //  CREATE TABLE[dbo].[Client]
        //  (


        // [ClientID][int] IDENTITY(1,1) NOT NULL,


        //[FirstName] [nvarchar] (20) NOT NULL,


        // [LastName] [nvarchar] (20) NOT NULL,


        //  [Balance] [money]
        //  NOT NULL
        //  ) ON[PRIMARY]

//        INSERT INTO Client(FirstName, LastName, Balance)
//VALUES('Ekin Anıl','ÖZCAN',5643235)
//INSERT INTO Client(FirstName, LastName, Balance)
//VALUES('Enes','BİLGİLİ',95643235215)
//INSERT INTO Client(FirstName, LastName, Balance)
//VALUES('Mahir','KARABULUT',5661643235)
    }
}
