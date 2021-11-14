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
    public partial class frmDetalle : Form
    {
        public frmDetalle()
        {
            InitializeComponent();
        }
        Conexiones cnn = new Conexiones();
        string qry;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            try
            {
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
    }
}
