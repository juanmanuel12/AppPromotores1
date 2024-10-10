namespace AppPromotores1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAltaProspectos = new Button();
            button1 = new Button();
            btnConsultar = new Button();
            SuspendLayout();
            // 
            // btnAltaProspectos
            // 
            btnAltaProspectos.Location = new Point(114, 104);
            btnAltaProspectos.Name = "btnAltaProspectos";
            btnAltaProspectos.Size = new Size(200, 80);
            btnAltaProspectos.TabIndex = 0;
            btnAltaProspectos.Text = "Alta Prospectos";
            btnAltaProspectos.UseVisualStyleBackColor = true;
            btnAltaProspectos.Click += btnAltaProspectos_Click;
            // 
            // button1
            // 
            button1.Location = new Point(139, 315);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(483, 104);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(200, 80);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConsultar);
            Controls.Add(button1);
            Controls.Add(btnAltaProspectos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAltaProspectos;
        private Button button1;
        private Button btnConsultar;
    }
}
