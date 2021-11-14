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
    public partial class frmTiketes : Form
    {
        public frmTiketes()
        {
            InitializeComponent();
        }
        Conexiones cnn = new Conexiones();
        string qry = "";
        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = 0;
                using (SqlConnection sqlcon = Conexiones.conecta())
                {
                    qry = "";
                    qry = "insert into tiketes values('"+textBox1.Text+"'," + comboBox1.SelectedValue + "," + comboBox2.SelectedValue + ","+Convert.ToByte(checkBox1.Checked)+","+ Convert.ToByte(checkBox2.Checked)+","+ Convert.ToByte(checkBox3.Checked) + ", 1) ";
                    cnn.registra(qry, sqlcon);
                    MessageBox.Show("Datos almacenados con exito.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void llenar_combox()
        {
            try
            {
                using (SqlConnection sqlcon = Conexiones.conecta())
                {
                    qry = "select * from empleados";
                    DataTable dt = new DataTable();
                    SqlDataAdapter dad;
                    dad = new SqlDataAdapter(qry,sqlcon);
                    dad.Fill(dt);
                    sqlcon.Close();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         


        }
        private DataTable cargar(string tabla)
        {
            using (SqlConnection sqlcon = Conexiones.conecta())
            {
                qry = "select * from " + tabla;
                DataTable dt = new DataTable();
                dt = cnn.table(qry, sqlcon);
                return dt;
            }
        }

        private void frmTiketes_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = cargar("empleados");
            comboBox1.DisplayMember = ("nombre");
            comboBox1.ValueMember = ("cod");
            comboBox2.DataSource = cargar("tipo_soporte");
            comboBox2.DisplayMember = ("nombre");
            comboBox2.ValueMember = ("cod");
        }
    }
}
