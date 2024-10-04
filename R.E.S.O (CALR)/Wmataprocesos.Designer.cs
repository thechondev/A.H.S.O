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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wmataprocesos));
            this.lblNomproceso = new System.Windows.Forms.Label();
            this.cmdcerrar = new System.Windows.Forms.Button();
            this.cmdObtenerpro = new System.Windows.Forms.Button();
            this.cboprocesos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNomproceso
            // 
            this.lblNomproceso.AutoSize = true;
            this.lblNomproceso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomproceso.Location = new System.Drawing.Point(99, 9);
            this.lblNomproceso.Name = "lblNomproceso";
            this.lblNomproceso.Size = new System.Drawing.Size(111, 19);
            this.lblNomproceso.TabIndex = 1;
            this.lblNomproceso.Text = "IM del proceso";
            // 
            // cmdcerrar
            // 
            this.cmdcerrar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcerrar.Location = new System.Drawing.Point(12, 91);
            this.cmdcerrar.Name = "cmdcerrar";
            this.cmdcerrar.Size = new System.Drawing.Size(284, 29);
            this.cmdcerrar.TabIndex = 5;
            this.cmdcerrar.Text = "Cerrar proceso";
            this.cmdcerrar.UseVisualStyleBackColor = true;
            this.cmdcerrar.Click += new System.EventHandler(this.cmdcerrar_Click);
            // 
            // cmdObtenerpro
            // 
            this.cmdObtenerpro.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdObtenerpro.Location = new System.Drawing.Point(82, 189);
            this.cmdObtenerpro.Name = "cmdObtenerpro";
            this.cmdObtenerpro.Size = new System.Drawing.Size(142, 83);
            this.cmdObtenerpro.TabIndex = 3;
            this.cmdObtenerpro.Text = "Actualizar Procesos";
            this.cmdObtenerpro.UseVisualStyleBackColor = true;
            this.cmdObtenerpro.Click += new System.EventHandler(this.cmdObtenerpro_Click);
            // 
            // cboprocesos
            // 
            this.cboprocesos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboprocesos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboprocesos.FormattingEnabled = true;
            this.cboprocesos.Location = new System.Drawing.Point(12, 47);
            this.cboprocesos.Name = "cboprocesos";
            this.cboprocesos.Size = new System.Drawing.Size(284, 29);
            this.cboprocesos.Sorted = true;
            this.cboprocesos.TabIndex = 6;
            // 
            // Wmataprocesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 387);
            this.Controls.Add(this.cboprocesos);
            this.Controls.Add(this.cmdObtenerpro);
            this.Controls.Add(this.lblNomproceso);
            this.Controls.Add(this.cmdcerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Wmataprocesos";
            this.Text = "mataprocesos";
            this.Load += new System.EventHandler(this.Wmataprocesos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomproceso;
        private System.Windows.Forms.Button cmdcerrar;
        private System.Windows.Forms.Button cmdObtenerpro;
        private System.Windows.Forms.ComboBox cboprocesos;
    }
}