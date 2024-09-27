namespace R.E.S.O__CALR_
{
    partial class Wmataprocesos
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
            this.lblNomproceso = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cmdcerrar = new System.Windows.Forms.Button();
            this.rtxtProcesos = new System.Windows.Forms.RichTextBox();
            this.cmdObtenerpro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomproceso
            // 
            this.lblNomproceso.AutoSize = true;
            this.lblNomproceso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomproceso.Location = new System.Drawing.Point(12, 11);
            this.lblNomproceso.Name = "lblNomproceso";
            this.lblNomproceso.Size = new System.Drawing.Size(111, 19);
            this.lblNomproceso.TabIndex = 1;
            this.lblNomproceso.Text = "IM del proceso";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(12, 36);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(284, 29);
            this.txtContraseña.TabIndex = 2;
            // 
            // cmdcerrar
            // 
            this.cmdcerrar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcerrar.Location = new System.Drawing.Point(12, 82);
            this.cmdcerrar.Name = "cmdcerrar";
            this.cmdcerrar.Size = new System.Drawing.Size(280, 23);
            this.cmdcerrar.TabIndex = 5;
            this.cmdcerrar.Text = "Cerrar proceso";
            this.cmdcerrar.UseVisualStyleBackColor = true;
            // 
            // rtxtProcesos
            // 
            this.rtxtProcesos.Location = new System.Drawing.Point(343, 11);
            this.rtxtProcesos.Name = "rtxtProcesos";
            this.rtxtProcesos.Size = new System.Drawing.Size(528, 364);
            this.rtxtProcesos.TabIndex = 4;
            this.rtxtProcesos.Text = "";
            // 
            // cmdObtenerpro
            // 
            this.cmdObtenerpro.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdObtenerpro.Location = new System.Drawing.Point(80, 152);
            this.cmdObtenerpro.Name = "cmdObtenerpro";
            this.cmdObtenerpro.Size = new System.Drawing.Size(142, 83);
            this.cmdObtenerpro.TabIndex = 3;
            this.cmdObtenerpro.Text = "Obtener  Procesos";
            this.cmdObtenerpro.UseVisualStyleBackColor = true;
            this.cmdObtenerpro.Click += new System.EventHandler(this.cmdObtenerpro_Click);
            // 
            // mataprocesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 387);
            this.Controls.Add(this.cmdObtenerpro);
            this.Controls.Add(this.rtxtProcesos);
            this.Controls.Add(this.lblNomproceso);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.cmdcerrar);
            this.Name = "mataprocesos";
            this.Text = "mataprocesos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomproceso;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button cmdcerrar;
        private System.Windows.Forms.RichTextBox rtxtProcesos;
        private System.Windows.Forms.Button cmdObtenerpro;
    }
}