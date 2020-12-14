using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sashca
{
    public partial class voiti : Form
    {
        public static voiti vo { get; set; }
        public static Users us { get; set; }
        readonly Model1 db = new Model1();
        public voiti()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль!");
                return;
            }
            Users usr = db.Users.Find(textBox1.Text);
            if ((usr != null) && (usr.Psw == textBox2.Text))
            {
                us = usr;
                vo = this;
                if (usr.Role == "Менеджер по продажам")
                {
                    manProd m = new manProd();
                    m.Show();
                    this.Hide();
                }
                if (usr.Role == "Директор")
                {
                    dir d = new dir();
                    d.Show();
                    this.Hide();
                }
                if (usr.Role == "Мастер")
                {
                    master m = new master();
                    m.Show();
                    this.Hide();
                }
                if (usr.Role == "Менеджер по закупкам")
                {
                    manZak m = new manZak();
                    m.Show();
                    this.Hide();
                }
                if (usr.Role == "Заказчик")
                {
                    zakazchik z = new zakazchik();
                    this.Hide();
                    z.Show();
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином и паролем нет в системе!");
                return;
            }

        }

        private void voiti_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reg f = new reg();
            f.Show();
            this.Hide();

        }
    }
}

