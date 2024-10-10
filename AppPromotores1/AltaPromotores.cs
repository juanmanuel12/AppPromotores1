using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;

namespace AppPromotores1
{
    public partial class AltaPromotores : Form
    {
        public AltaPromotores()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-5V8A1MMI\\SQLEXPRESS;Initial Catalog=PROMOTORES;Integrated Security=True");


        public void Limpiar() 
        {
            txtNombre.Text = "";
            txtPri_Ape.Text = "";
            txtSeg_Ape.Text = "";
            txtCalle.Text = "";
            txtNumero.Text = "";
            txtColonia.Text = "";
            txtCodigoPostal.Text = "";
            txtTelefono.Text = "";
            txtRFC.Text = "";
            txtDocumentos.Text = "";
            txtEstatus.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Salir?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();       
            }
         
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea Guardar?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {

                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPri_Ape.Text) || string.IsNullOrWhiteSpace(txtSeg_Ape.Text) || string.IsNullOrWhiteSpace(txtCalle.Text) || string.IsNullOrWhiteSpace(txtNumero.Text) || string.IsNullOrWhiteSpace(txtColonia.Text) || string.IsNullOrWhiteSpace(txtCodigoPostal.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtRFC.Text) || string.IsNullOrWhiteSpace(txtDocumentos.Text) || string.IsNullOrWhiteSpace(txtEstatus.Text)  ) //|| cmbEstatus.SelectedIndex == -1)   


                {
                    MessageBox.Show("Información Faltante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }




                string Nombre = txtNombre.Text;
                string Primer_Apellido = txtPri_Ape.Text;
                string Segundo_Apellido = txtSeg_Ape.Text;
                string Calle = txtCalle.Text;
                // int Numero = int.Parse(txtNumero);
                int Numero = Convert.ToInt32(txtNumero.Text);
                string Colonia = txtColonia.Text;
                int Codigo_Postal = Convert.ToInt32(txtCodigoPostal.Text);
                string Telefono = txtTelefono.Text;
                string RFC = txtRFC.Text;
                string Documentos = txtDocumentos.Text;
                string Estatus = txtEstatus.Text;

                //SqlConnection

                string strCon = "Data Source=LAPTOP-5V8A1MMI\\SQLEXPRESS1;Initial Catalog=PROMOTORES;Integrated Security=True";
                SqlConnection conn = UsoDB.ConectaBD(strCon);
                if (conn == null)
                {
                    MessageBox.Show("Imposible Conectar con BD");
                    return;
                }
                string strComandoSQL = "insert into Prospectos (Nombre,Primer_Apellido,Segundo_Apellido,Calle,Numero,Colonia,Codigo_Postal,Telefono,RFC,Documentos,Estatus)";
                strComandoSQL += " values('" + txtNombre.Text + "','" + txtPri_Ape.Text + "','" + txtSeg_Ape.Text + "','" + txtCalle.Text + 
                    "'," + txtNumero.Text + ",'" + txtColonia.Text + "'," + txtCodigoPostal.Text + ",'" + txtTelefono.Text + "', '" 
                    + txtRFC.Text + "', '" + txtDocumentos.Text + "',' " + txtEstatus.Text + " ' )";
               
                
                
                SqlCommand cmd = new SqlCommand(strComandoSQL, conn);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Primer_Apellido", Primer_Apellido);
                cmd.Parameters.AddWithValue("@Segundo_Apellido", Segundo_Apellido);
                cmd.Parameters.AddWithValue("@Calle", Calle);
                cmd.Parameters.AddWithValue("@Numero", Numero);
                cmd.Parameters.AddWithValue("@Colonia", Colonia);
                cmd.Parameters.AddWithValue("@Codigo_Postal", Codigo_Postal);
                cmd.Parameters.AddWithValue("@Telefono", Telefono);
                cmd.Parameters.AddWithValue("@RFC", RFC);
                cmd.Parameters.AddWithValue("@Documentos",Documentos);
                cmd.Parameters.AddWithValue("@Estatus",Estatus);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cuenta dada de alta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Limpiar();


                

            }


        }
    }
}
