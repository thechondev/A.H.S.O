namespace R.E.S.O__CALR_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdLeerSeri = new System.Windows.Forms.Button();
            this.cmdComponentes = new System.Windows.Forms.Button();
            this.cmdUnidades = new System.Windows.Forms.Button();
            this.cmdClaves = new System.Windows.Forms.Button();
            this.rtxtdatos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmdLeerSeri
            // 
            this.cmdLeerSeri.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLeerSeri.Location = new System.Drawing.Point(12, 33);
            this.cmdLeerSeri.Name = "cmdLeerSeri";
            this.cmdLeerSeri.Size = new System.Drawing.Size(134, 36);
            this.cmdLeerSeri.TabIndex = 0;
            this.cmdLeerSeri.Text = "Leer serial";
            this.cmdLeerSeri.UseVisualStyleBackColor = true;
            this.cmdLeerSeri.Click += new System.EventHandler(this.cmdLeerSeri_Click);
            // 
            // cmdComponentes
            // 
            this.cmdComponentes.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComponentes.Location = new System.Drawing.Point(12, 159);
            this.cmdComponentes.Name = "cmdComponentes";
            this.cmdComponentes.Size = new System.Drawing.Size(134, 36);
            this.cmdComponentes.TabIndex = 1;
            this.cmdComponentes.Text = "Componentes";
            this.cmdComponentes.UseVisualStyleBackColor = true;
            this.cmdComponentes.Click += new System.EventHandler(this.cmdComponentes_Click);
            // 
            // cmdUnidades
            // 
            this.cmdUnidades.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUnidades.Location = new System.Drawing.Point(12, 96);
            this.cmdUnidades.Name = "cmdUnidades";
            this.cmdUnidades.Size = new System.Drawing.Size(134, 36);
            this.cmdUnidades.TabIndex = 2;
            this.cmdUnidades.Text = "Unidades";
            this.cmdUnidades.UseVisualStyleBackColor = true;
            this.cmdUnidades.Click += new System.EventHandler(this.cmdUnidades_Click);
            // 
            // cmdClaves
            // 
            this.cmdClaves.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClaves.Location = new System.Drawing.Point(12, 222);
            this.cmdClaves.Name = "cmdClaves";
            this.cmdClaves.Size = new System.Drawing.Size(134, 36);
            this.cmdClaves.TabIndex = 3;
            this.cmdClaves.Text = "Claves";
            this.cmdClaves.UseVisualStyleBackColor = true;
            this.cmdClaves.Click += new System.EventHandler(this.cmdClaves_Click);
            // 
            // rtxtdatos
            // 
            this.rtxtdatos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtdatos.Location = new System.Drawing.Point(171, 33);
            this.rtxtdatos.Name = "rtxtdatos";
            this.rtxtdatos.Size = new System.Drawing.Size(508, 351);
            this.rtxtdatos.TabIndex = 4;
            this.rtxtdatos.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.rtxtdatos);
            this.Controls.Add(this.cmdClaves);
            this.Controls.Add(this.cmdUnidades);
            this.Controls.Add(this.cmdComponentes);
            this.Controls.Add(this.cmdLeerSeri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdLeerSeri;
        private System.Windows.Forms.Button cmdComponentes;
        private System.Windows.Forms.Button cmdUnidades;
        private System.Windows.Forms.Button cmdClaves;
        private System.Windows.Forms.RichTextBox rtxtdatos;
    }
}

