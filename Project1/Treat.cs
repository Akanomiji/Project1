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

namespace Project1
{
    public partial class Treat : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Treat()
        {
            InitializeComponent();
            connectDB();
            getTreat();
        }

        public void connectDB()
        {
            conn.ConnectionString = "Data Source=Agent;Initial Catalog=CScompany;Integrated Security=True;";
            conn.Open();
            cmd.Connection = conn;
            getTreat();
        }

        public void getTreat()
        {
            cmd.CommandText = "select * from Treat";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            bindingSource1.DataSource = table;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns[0].HeaderText = "รหัสวิธีรักษา";
            dataGridView1.Columns[1].HeaderText = "รหัสการรักษา";
        }

        
        private void bNew_Click(object sender, EventArgs e)
        {
            TreatmentID.Clear();
            TreatmentMethodsID.Clear();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into Treatment values('" + TreatmentID.Text + "','" + TreatmentMethodsID.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ค่าซ้ำ");
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "update Treat set TreatmentMethodsID='" + TreatmentMethodsID.Text + "' where TreatmentID ='" + TreatmentID.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("คุณจะทำการแก้ไขข้อมูลหรือไม่", "OK", MessageBoxButtons.OKCancel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ข้อมูลซ้ำ");
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "delete from Treat where TreatmentID='" + TreatmentID.Text + "' and TreatmentMethodsID='" + TreatmentMethodsID.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("คุณต้องการที่จะลบหรือไม่", "OK", MessageBoxButtons.OKCancel);
                TreatmentID.Clear();
                TreatmentMethodsID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ไม่มีค่าให้ลบ");
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการที่จะปิดหรือไม่", "Yes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TreatmentID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd.CommandText = "select * from Treat where TreatmentID = '" + TreatmentID.Text + "' ";

                SqlDataReader rs = cmd.ExecuteReader();
                if (rs.HasRows)
                {
                    rs.Read();
                    TreatmentMethodsID.Text = rs.GetString(1);
                    
                }
                else
                {
                    TreatmentMethodsID.Clear();
                }
                rs.Close();
            }
            TreatmentMethodsID.Focus();
        }
    }
}
