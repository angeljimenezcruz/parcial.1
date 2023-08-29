namespace parcial._1
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
            this.btnCerrarProgramaDeConversor = new System.Windows.Forms.Button();
            this.lbl4RespuestaDeConversor = new System.Windows.Forms.Label();
            this.btn1Convertir = new System.Windows.Forms.Button();
            this.txt1CantidadAconvertir = new System.Windows.Forms.TextBox();
            this.lbl3cantidadDeConversor = new System.Windows.Forms.Label();
            this.cboDeConversores = new System.Windows.Forms.ComboBox();
            this.cboAConversores = new System.Windows.Forms.ComboBox();
            this.lb2AConversor = new System.Windows.Forms.Label();
            this.lbl1DeConversor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrarProgramaDeConversor
            // 
            this.btnCerrarProgramaDeConversor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarProgramaDeConversor.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarProgramaDeConversor.Location = new System.Drawing.Point(316, 342);
            this.btnCerrarProgramaDeConversor.Name = "btnCerrarProgramaDeConversor";
            this.btnCerrarProgramaDeConversor.Size = new System.Drawing.Size(89, 57);
            this.btnCerrarProgramaDeConversor.TabIndex = 20;
            this.btnCerrarProgramaDeConversor.Text = "Cerrar";
            this.btnCerrarProgramaDeConversor.UseVisualStyleBackColor = true;
            this.btnCerrarProgramaDeConversor.Click += new System.EventHandler(this.btnCerrarProgramaDeConversor_Click);
            // 
            // lbl4RespuestaDeConversor
            // 
            this.lbl4RespuestaDeConversor.AutoSize = true;
            this.lbl4RespuestaDeConversor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4RespuestaDeConversor.Location = new System.Drawing.Point(102, 320);
            this.lbl4RespuestaDeConversor.Name = "lbl4RespuestaDeConversor";
            this.lbl4RespuestaDeConversor.Size = new System.Drawing.Size(123, 22);
            this.lbl4RespuestaDeConversor.TabIndex = 19;
            this.lbl4RespuestaDeConversor.Text = "Respuesta: ?";
            // 
            // btn1Convertir
            // 
            this.btn1Convertir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Convertir.Location = new System.Drawing.Point(106, 238);
            this.btn1Convertir.Name = "btn1Convertir";
            this.btn1Convertir.Size = new System.Drawing.Size(119, 55);
            this.btn1Convertir.TabIndex = 18;
            this.btn1Convertir.Text = "Convertir";
            this.btn1Convertir.UseVisualStyleBackColor = true;
            this.btn1Convertir.Click += new System.EventHandler(this.btn1Convertir_Click);
            // 
            // txt1CantidadAconvertir
            // 
            this.txt1CantidadAconvertir.Location = new System.Drawing.Point(156, 187);
            this.txt1CantidadAconvertir.Name = "txt1CantidadAconvertir";
            this.txt1CantidadAconvertir.Size = new System.Drawing.Size(108, 20);
            this.txt1CantidadAconvertir.TabIndex = 17;
            // 
            // lbl3cantidadDeConversor
            // 
            this.lbl3cantidadDeConversor.AutoSize = true;
            this.lbl3cantidadDeConversor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3cantidadDeConversor.Location = new System.Drawing.Point(60, 187);
            this.lbl3cantidadDeConversor.Name = "lbl3cantidadDeConversor";
            this.lbl3cantidadDeConversor.Size = new System.Drawing.Size(90, 22);
            this.lbl3cantidadDeConversor.TabIndex = 16;
            this.lbl3cantidadDeConversor.Text = "Cantidad:";
            // 
            // cboDeConversores
            // 
            this.cboDeConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeConversores.FormattingEnabled = true;
            this.cboDeConversores.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana",
            "Hectárea"});
            this.cboDeConversores.Location = new System.Drawing.Point(106, 97);
            this.cboDeConversores.Name = "cboDeConversores";
            this.cboDeConversores.Size = new System.Drawing.Size(133, 21);
            this.cboDeConversores.TabIndex = 15;
            // 
            // cboAConversores
            // 
            this.cboAConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAConversores.FormattingEnabled = true;
            this.cboAConversores.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana",
            "Hectárea"});
            this.cboAConversores.Location = new System.Drawing.Point(106, 132);
            this.cboAConversores.Name = "cboAConversores";
            this.cboAConversores.Size = new System.Drawing.Size(133, 21);
            this.cboAConversores.TabIndex = 14;
            // 
            // lb2AConversor
            // 
            this.lb2AConversor.AutoSize = true;
            this.lb2AConversor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2AConversor.Location = new System.Drawing.Point(60, 132);
            this.lb2AConversor.Name = "lb2AConversor";
            this.lb2AConversor.Size = new System.Drawing.Size(28, 22);
            this.lb2AConversor.TabIndex = 13;
            this.lb2AConversor.Text = "A:";
            // 
            // lbl1DeConversor
            // 
            this.lbl1DeConversor.AutoSize = true;
            this.lbl1DeConversor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1DeConversor.Location = new System.Drawing.Point(60, 93);
            this.lbl1DeConversor.Name = "lbl1DeConversor";
            this.lbl1DeConversor.Size = new System.Drawing.Size(40, 22);
            this.lbl1DeConversor.TabIndex = 12;
            this.lbl1DeConversor.Text = "De:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.btnCerrarProgramaDeConversor);
            this.Controls.Add(this.lbl4RespuestaDeConversor);
            this.Controls.Add(this.btn1Convertir);
            this.Controls.Add(this.txt1CantidadAconvertir);
            this.Controls.Add(this.lbl3cantidadDeConversor);
            this.Controls.Add(this.cboDeConversores);
            this.Controls.Add(this.cboAConversores);
            this.Controls.Add(this.lb2AConversor);
            this.Controls.Add(this.lbl1DeConversor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarProgramaDeConversor;
        private System.Windows.Forms.Label lbl4RespuestaDeConversor;
        private System.Windows.Forms.Button btn1Convertir;
        private System.Windows.Forms.TextBox txt1CantidadAconvertir;
        private System.Windows.Forms.Label lbl3cantidadDeConversor;
        private System.Windows.Forms.ComboBox cboDeConversores;
        private System.Windows.Forms.ComboBox cboAConversores;
        private System.Windows.Forms.Label lb2AConversor;
        private System.Windows.Forms.Label lbl1DeConversor;
    }
}

