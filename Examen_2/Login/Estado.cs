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
    public partial class Estado : Form
    {
        public Estado()
        {
            InitializeComponent();
        }
        Conexiones cnn =new Conexiones();
        string qry = "";
        int estadot=0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = 0;
                using (SqlConnection sqlcon = Conexiones.conecta())
                {
                    qry = "Select top 1 cod From usuario where tiketes order by desc ";
                cod = cnn.entero(qry, sqlcon);
                if (cod == 1)
                {
                    cod =1;//ingresa el codigo 1 cuado la base de datos esta vacia
                }
          
                qry = "";
                    qry = "update Tiketes set estado="+estadot+" where id="+cod;
                    cnn.registra(qry, sqlcon);
                    MessageBox.Show("Datos Actualizados  con exito.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Abierto")
            {
                estadot = 1;
            }
            else if (comboBox3.Text == "Sin resolver")
            {
                estadot = 2;
            }
            else if(comboBox3.Text == "En espera")
            {
                estadot = 3;

            }
            else
            {
                estadot = 4;
            }
               
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable ta;

            
           
            using (SqlConnection sqlcon = Conexiones.conecta())
            {
                qry = "select Cliente, b.Nombre Tipo, c.Nombre Persona, a.instalacion, a.licencia,a.reparacion, a.Estado from Tiketes a, tipo_soporte b, Empleados c where a.cod_tipo=b.cod and c.cod=p_asignado";
                ta= cnn.table(qry, sqlcon);
                if(ta.Rows.Count>0)
                {
                    foreach(DataGridViewRow r in dataGridView1.SelectedRows)
                    {
                        textBox1.Text = r.Cells[1].Value.ToString();
                        comboBox1.ValueMember = r.Cells[2].Value.ToString();
                        comboBox2.ValueMember = r.Cells[3].Value.ToString();
                        textBox2.Text = r.Cells[4].Value.ToString();
                        checkBox1.Checked = Convert.ToBoolean(r.Cells[5].Value);
                        checkBox2.Checked = Convert.ToBoolean(r.Cells[6].Value);
                        checkBox3.Checked = Convert.ToBoolean(r.Cells[7].Value);
                        comboBox3.ValueMember = r.Cells[8].Value.ToString();
                       
                    }
                }
            }

            }

        private void Estado_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.DataSource = cargar("empleados");
                comboBox1.DisplayMember = ("nombre");
                comboBox1.ValueMember = ("cod");
                comboBox2.DataSource = cargar("tipo_soporte");
                comboBox2.DisplayMember = ("nombre");
                comboBox2.ValueMember = ("cod");
                qry = "";
                using (SqlConnection sqlcon = Conexiones.conecta())
                {
                    qry = "select Cliente, b.Nombre Tipo, c.Nombre Persona, a.instalacion, a.licencia,a.reparacion, a.Estado from Tiketes a, tipo_soporte b, Empleados c where a.cod_tipo=b.cod and c.cod=p_asignado";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(qry, sqlcon);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception)
            {

                throw;
            }
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

        
    }
}
