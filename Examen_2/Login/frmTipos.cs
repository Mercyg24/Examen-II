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
    public partial class frmTipos : Form
    {
        public frmTipos()
        {
            InitializeComponent();
        }
        Conexiones cnn=new Conexiones();
        string qry="";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = 0;
                using (SqlConnection sqlcon = Conexiones.conecta())
                {
                    qry = "Select cod From usuario where usuario = '" + textBox1.Text + "' and contraseña = '" + textBox2.Text + "'";
                    cod = cnn.entero(qry, sqlcon);
                    if (cod == 1)
                    {
                        textBox1.Text = "1";//ingresa el codigo 1 cuado la base de datos esta vacia
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(cod + 1);
                    }
                    qry = "";
                    qry = "insert into tipo_soporte values('"+textBox2.Text+"','"+textBox3.Text+"') ";
                    cnn.registra(qry, sqlcon);
                    MessageBox.Show("Datos almacenados con exito.");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
