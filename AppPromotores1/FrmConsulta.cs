using LibreriaBD;
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
using System.Data.SqlClient;
using LibreriaBD;

namespace AppPromotores1
{
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            string strCon = "Data Source=LAPTOP-5V8A1MMI\\SQLEXPRESS1;Initial Catalog=PROMOTORES;Integrated Security=True";
            SqlConnection conn = UsoDB.ConectaBD(strCon);
            if (conn == null)
            {
                MessageBox.Show("Imposible Conectar con BD");
                return;
            }

            SqlDataReader lector = null;
            string strComando = "SELECT Nombre,Primer_Apellido,Segundo_Apellido,Calle,Numero,Colonia,Codigo_Postal,Telefono,RFC,Documentos,Estatus from Prospectos";
            lector = UsoDB.Consulta(strComando, conn);

            if (lector == null)
            {
                MessageBox.Show("Error en Consulta");
            }

            else
            {
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        dgvConsulta.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString(), lector.GetValue(6).ToString(), lector.GetValue(7).ToString(), lector.GetValue(8).ToString(), lector.GetValue(9).ToString(), lector.GetValue(10).ToString());
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
