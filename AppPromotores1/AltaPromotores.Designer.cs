namespace AppPromotores1
{
    partial class AltaPromotores
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
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnGuardar = new Button();
            lblTelefono = new Label();
            lblRFC = new Label();
            lblDocumentos = new Label();
            label6 = new Label();
            lblColonia = new Label();
            lblCodigoPostal = new Label();
            lblNombre = new Label();
            lblPri_Ape = new Label();
            lblSeg_Ape = new Label();
            lblCalle = new Label();
            lblNumero = new Label();
            txtCodigoPostal = new TextBox();
            txtColonia = new TextBox();
            txtNumero = new TextBox();
            txtCalle = new TextBox();
            txtSeg_Ape = new TextBox();
            txtPri_Ape = new TextBox();
            txtNombre = new TextBox();
            txtRFC = new TextBox();
            txtTelefono = new TextBox();
            txtDocumentos = new TextBox();
            txtEstatus = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(63, 360);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 58);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(562, 360);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 58);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(995, 360);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 58);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(477, 170);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(79, 25);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono";
            // 
            // lblRFC
            // 
            lblRFC.AutoSize = true;
            lblRFC.Location = new Point(477, 233);
            lblRFC.Name = "lblRFC";
            lblRFC.Size = new Size(43, 25);
            lblRFC.TabIndex = 6;
            lblRFC.Text = "RFC";
            lblRFC.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDocumentos
            // 
            lblDocumentos.AutoSize = true;
            lblDocumentos.Location = new Point(477, 300);
            lblDocumentos.Name = "lblDocumentos";
            lblDocumentos.Size = new Size(114, 25);
            lblDocumentos.TabIndex = 7;
            lblDocumentos.Text = "Documentos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(925, 47);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 8;
            label6.Text = "Estatus";
            // 
            // lblColonia
            // 
            lblColonia.AutoSize = true;
            lblColonia.Location = new Point(477, 33);
            lblColonia.Name = "lblColonia";
            lblColonia.Size = new Size(72, 25);
            lblColonia.TabIndex = 9;
            lblColonia.Text = "Colonia";
            // 
            // lblCodigoPostal
            // 
            lblCodigoPostal.AutoSize = true;
            lblCodigoPostal.Location = new Point(477, 103);
            lblCodigoPostal.Name = "lblCodigoPostal";
            lblCodigoPostal.Size = new Size(123, 25);
            lblCodigoPostal.TabIndex = 10;
            lblCodigoPostal.Text = "Codigo Postal";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nombre";
            // 
            // lblPri_Ape
            // 
            lblPri_Ape.AutoSize = true;
            lblPri_Ape.Location = new Point(23, 103);
            lblPri_Ape.Name = "lblPri_Ape";
            lblPri_Ape.Size = new Size(134, 25);
            lblPri_Ape.TabIndex = 12;
            lblPri_Ape.Text = "Primer Apellido";
            // 
            // lblSeg_Ape
            // 
            lblSeg_Ape.AutoSize = true;
            lblSeg_Ape.Location = new Point(23, 170);
            lblSeg_Ape.Name = "lblSeg_Ape";
            lblSeg_Ape.Size = new Size(155, 25);
            lblSeg_Ape.TabIndex = 13;
            lblSeg_Ape.Text = "Segundo Apellido";
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(24, 236);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(49, 25);
            lblCalle.TabIndex = 14;
            lblCalle.Text = "Calle";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(23, 303);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(77, 25);
            lblNumero.TabIndex = 15;
            lblNumero.Text = "Numero";
            // 
            // txtCodigoPostal
            // 
            txtCodigoPostal.Location = new Point(616, 103);
            txtCodigoPostal.Name = "txtCodigoPostal";
            txtCodigoPostal.Size = new Size(253, 31);
            txtCodigoPostal.TabIndex = 17;
            // 
            // txtColonia
            // 
            txtColonia.Location = new Point(616, 41);
            txtColonia.Name = "txtColonia";
            txtColonia.Size = new Size(253, 31);
            txtColonia.TabIndex = 18;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(173, 297);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(253, 31);
            txtNumero.TabIndex = 19;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(173, 230);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(253, 31);
            txtCalle.TabIndex = 20;
            // 
            // txtSeg_Ape
            // 
            txtSeg_Ape.Location = new Point(173, 170);
            txtSeg_Ape.Name = "txtSeg_Ape";
            txtSeg_Ape.Size = new Size(253, 31);
            txtSeg_Ape.TabIndex = 21;
            // 
            // txtPri_Ape
            // 
            txtPri_Ape.Location = new Point(173, 103);
            txtPri_Ape.Name = "txtPri_Ape";
            txtPri_Ape.Size = new Size(253, 31);
            txtPri_Ape.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(173, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 31);
            txtNombre.TabIndex = 23;
            // 
            // txtRFC
            // 
            txtRFC.Location = new Point(616, 227);
            txtRFC.Name = "txtRFC";
            txtRFC.Size = new Size(253, 31);
            txtRFC.TabIndex = 24;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(616, 164);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(253, 31);
            txtTelefono.TabIndex = 25;
            // 
            // txtDocumentos
            // 
            txtDocumentos.Location = new Point(618, 279);
            txtDocumentos.Multiline = true;
            txtDocumentos.Name = "txtDocumentos";
            txtDocumentos.Size = new Size(251, 43);
            txtDocumentos.TabIndex = 26;
            // 
            // txtEstatus
            // 
            txtEstatus.Location = new Point(925, 103);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(253, 31);
            txtEstatus.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(925, 297);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 28;
            label1.Text = "Rechazado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(925, 176);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 29;
            label4.Text = "Enviado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(925, 236);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 30;
            label5.Text = "Autorizado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(982, 151);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 31;
            label2.Text = "Tipos de Estatus";
            // 
            // AltaPromotores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 450);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtEstatus);
            Controls.Add(txtDocumentos);
            Controls.Add(txtTelefono);
            Controls.Add(txtRFC);
            Controls.Add(txtNombre);
            Controls.Add(txtPri_Ape);
            Controls.Add(txtSeg_Ape);
            Controls.Add(txtCalle);
            Controls.Add(txtNumero);
            Controls.Add(txtColonia);
            Controls.Add(txtCodigoPostal);
            Controls.Add(lblNumero);
            Controls.Add(lblCalle);
            Controls.Add(lblSeg_Ape);
            Controls.Add(lblPri_Ape);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigoPostal);
            Controls.Add(lblColonia);
            Controls.Add(label6);
            Controls.Add(lblDocumentos);
            Controls.Add(lblRFC);
            Controls.Add(lblTelefono);
            Controls.Add(btnGuardar);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Name = "AltaPromotores";
            Text = "AltaPromotores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnGuardar;
        private Label lblTelefono;
        private Label label2;
        private Label label3;
        private Label lblRFC;
        private Label lblDocumentos;
        private Label label6;
        private Label lblColonia;
        private Label lblCodigoPostal;
        private Label lblNombre;
        private Label lblPri_Ape;
        private Label lblSeg_Ape;
        private Label lblCalle;
        private Label lblNumero;
        private TextBox txtCodigoPostal;
        private TextBox txtColonia;
        private TextBox txtNumero;
        private TextBox txtCalle;
        private TextBox txtSeg_Ape;
        private TextBox txtPri_Ape;
        private TextBox txtNombre;
        private TextBox txtRFC;
        private TextBox txtTelefono;
        private TextBox txtDocumentos;
        private TextBox txtEstatus;
        private Label label1;
        private Label label4;
        private Label label5;
    }
}