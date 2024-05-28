using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegisterStudent : Form
    {
        public int studentID = 0;
        public RegisterStudent()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (studentID == 0)
                {
                    string name = textBox1.Text;
                    string email = textBox2.Text;
                    string address = textBox3.Text;
                    string query = "insert into Student values('" + name + "', '" + email + "', '" + address + "')";
                    DBConnection db = new DBConnection();
                    db.ExecuteQuery(query);
                    MessageBox.Show("save successfully");
                }
                else
                {
                    string name = textBox1.Text;
                    string email = textBox2.Text;
                    string address = textBox3.Text;
                    string query = "update Student set name = '" + name + "', email= '" + email + "', address= '" + address + "' where id= '" + studentID + "'";
                    DBConnection db = new DBConnection();
                    db.ExecuteQuery(query);
                    MessageBox.Show("save successfully");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadDataForEditing(int studentId)
        {
            try
            {
                string query = "SELECT * FROM Student WHERE id = " + studentId;
                DBConnection db = new DBConnection();
                DataTable result = db.GetData(query);
                if (result.Rows.Count > 0)
                {
                    textBox1.Text = result.Rows[0]["Name"].ToString();
                    textBox2.Text = result.Rows[0]["Email"].ToString();
                    textBox3.Text = result.Rows[0]["Address"].ToString();
                }
                else
                {
                    MessageBox.Show("not found id: " + studentId);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
