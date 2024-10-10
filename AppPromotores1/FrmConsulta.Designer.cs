namespace AppPromotores1
{
    partial class FrmConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvConsulta = new DataGridView();
            Primer_Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Segundo_Apellido = new DataGridViewTextBoxColumn();
            calle = new DataGridViewTextBoxColumn();
            numero = new DataGridViewTextBoxColumn();
            colonia = new DataGridViewTextBoxColumn();
            codigo_postal = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            rfc = new DataGridViewTextBoxColumn();
            documentos = new DataGridViewTextBoxColumn();
            estatus = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // dgvConsulta
            // 
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Columns.AddRange(new DataGridViewColumn[] { Primer_Apellido, Nombre, Segundo_Apellido, calle, numero, colonia, codigo_postal, telefono, rfc, documentos, estatus });
            dgvConsulta.Location = new Point(-1, 24);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.RowHeadersWidth = 62;
            dgvConsulta.Size = new Size(1758, 252);
            dgvConsulta.TabIndex = 0;
            // 
            // Primer_Apellido
            // 
            Primer_Apellido.HeaderText = "Primer Apellido";
            Primer_Apellido.MinimumWidth = 8;
            Primer_Apellido.Name = "Primer_Apellido";
            Primer_Apellido.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Segundo_Apellido
            // 
            Segundo_Apellido.HeaderText = "Segundo Apellido";
            Segundo_Apellido.MinimumWidth = 8;
            Segundo_Apellido.Name = "Segundo_Apellido";
            Segundo_Apellido.Width = 150;
            // 
            // calle
            // 
            calle.HeaderText = "Calle";
            calle.MinimumWidth = 8;
            calle.Name = "calle";
            calle.Width = 150;
            // 
            // numero
            // 
            numero.HeaderText = "Numero";
            numero.MinimumWidth = 8;
            numero.Name = "numero";
            numero.Width = 150;
            // 
            // colonia
            // 
            colonia.HeaderText = "Colonia";
            colonia.MinimumWidth = 8;
            colonia.Name = "colonia";
            colonia.Width = 150;
            // 
            // codigo_postal
            // 
            codigo_postal.HeaderText = "Codigo Postal";
            codigo_postal.MinimumWidth = 8;
            codigo_postal.Name = "codigo_postal";
            codigo_postal.Width = 150;
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.MinimumWidth = 8;
            telefono.Name = "telefono";
            telefono.Width = 150;
            // 
            // rfc
            // 
            rfc.HeaderText = "RFC";
            rfc.MinimumWidth = 8;
            rfc.Name = "rfc";
            rfc.Width = 150;
            // 
            // documentos
            // 
            documentos.HeaderText = "Documentos";
            documentos.MinimumWidth = 8;
            documentos.Name = "documentos";
            documentos.Width = 150;
            // 
            // estatus
            // 
            estatus.HeaderText = "Estatus";
            estatus.MinimumWidth = 8;
            estatus.Name = "estatus";
            estatus.Width = 150;
            // 
            // button1
            // 
            button1.Location = new Point(1469, 560);
            button1.Name = "button1";
            button1.Size = new Size(174, 90);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(655, 316);
            button2.Name = "button2";
            button2.Size = new Size(185, 77);
            button2.TabIndex = 2;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmConsulta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1823, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvConsulta);
            Name = "FrmConsulta";
            Text = "FrmConsulta";
            Load += FrmConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvConsulta;
        private DataGridViewTextBoxColumn Primer_Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Segundo_Apellido;
        private DataGridViewTextBoxColumn calle;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn colonia;
        private DataGridViewTextBoxColumn codigo_postal;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn rfc;
        private DataGridViewTextBoxColumn documentos;
        private DataGridViewTextBoxColumn estatus;
        private Button button1;
        private Button button2;
    }
}