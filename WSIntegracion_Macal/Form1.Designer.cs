namespace WSIntegracion_Macal
{
    partial class FormMacal
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
            this.Btn_Magico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Rut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Celular = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Magico
            // 
            this.Btn_Magico.Location = new System.Drawing.Point(386, 358);
            this.Btn_Magico.Name = "Btn_Magico";
            this.Btn_Magico.Size = new System.Drawing.Size(217, 50);
            this.Btn_Magico.TabIndex = 0;
            this.Btn_Magico.Text = "CREAR";
            this.Btn_Magico.UseVisualStyleBackColor = true;
            this.Btn_Magico.Click += new System.EventHandler(this.Btn_Magico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar Nombre";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(162, 54);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresar Apellido";
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(162, 104);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_Apellido.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingresar Rut";
            // 
            // txt_Rut
            // 
            this.txt_Rut.Location = new System.Drawing.Point(162, 162);
            this.txt_Rut.Name = "txt_Rut";
            this.txt_Rut.Size = new System.Drawing.Size(100, 20);
            this.txt_Rut.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingresar Direccion";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(450, 51);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_Direccion.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ingresar Celular";
            // 
            // txt_Celular
            // 
            this.txt_Celular.Location = new System.Drawing.Point(450, 107);
            this.txt_Celular.Name = "txt_Celular";
            this.txt_Celular.Size = new System.Drawing.Size(100, 20);
            this.txt_Celular.TabIndex = 10;
            // 
            // FormMacal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 468);
            this.Controls.Add(this.txt_Celular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Rut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Magico);
            this.Name = "FormMacal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMacal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Magico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Rut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Celular;
    }
}

