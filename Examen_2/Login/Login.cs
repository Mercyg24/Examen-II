using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Conexiones cnn = new Conexiones();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo;
                using (SqlConnection sqlcon = Conexiones.conecta())
                {
                    string qry = "Select 1 From usuario where usuario = '" + textBox1.Text + "' and contraseña = '" + textBox2.Text + "'";
                    codigo = cnn.entero(qry, sqlcon);
                    if (codigo == 1)
                    {
                        frmmenu frm = new frmmenu();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos");
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = text;

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox2.Text = text;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;// convierte el texto en contraseña
        }
    }
}
