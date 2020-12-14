using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sashca
{
    public partial class reg: Form
    {
        Model1 db = new Model1();
        public reg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Нужно заполнить все данные!");
                return;
            }
            Users usr = db.Users.Find(textBox2.Text);
            if (usr != null)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!");
                return;
            }
            usr = new Users();
            usr.FIO = textBox1.Text;
            usr.Login = textBox3.Text;
            usr.Psw = textBox4.Text;
            usr.Role = textBox2.Text;

            db.Users.Add(usr);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Пользователь " + usr.Login + "уже зарегистрирован!");
            voiti s = new voiti();
            s.Show();
            this.Close();
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
