namespace WindowsLab
{
    partial class FormCaso4
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
            this.chkCirculo = new System.Windows.Forms.CheckBox();
            this.chkTrapecio = new System.Windows.Forms.CheckBox();
            this.chkCuadrado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaseMenor = new System.Windows.Forms.TextBox();
            this.txtBaseMayor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bttnCalcularArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkCirculo
            // 
            this.chkCirculo.AutoSize = true;
            this.chkCirculo.Location = new System.Drawing.Point(115, 65);
            this.chkCirculo.Name = "chkCirculo";
            this.chkCirculo.Size = new System.Drawing.Size(70, 20);
            this.chkCirculo.TabIndex = 0;
            this.chkCirculo.Text = "Circulo";
            this.chkCirculo.UseVisualStyleBackColor = true;
            // 
            // chkTrapecio
            // 
            this.chkTrapecio.AutoSize = true;
            this.chkTrapecio.Location = new System.Drawing.Point(252, 65);
            this.chkTrapecio.Name = "chkTrapecio";
            this.chkTrapecio.Size = new System.Drawing.Size(84, 20);
            this.chkTrapecio.TabIndex = 1;
            this.chkTrapecio.Text = "Trapecio";
            this.chkTrapecio.UseVisualStyleBackColor = true;
            // 
            // chkCuadrado
            // 
            this.chkCuadrado.AutoSize = true;
            this.chkCuadrado.Location = new System.Drawing.Point(407, 65);
            this.chkCuadrado.Name = "chkCuadrado";
            this.chkCuadrado.Size = new System.Drawing.Size(89, 20);
            this.chkCuadrado.TabIndex = 2;
            this.chkCuadrado.Text = "Cuadrado";
            this.chkCuadrado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecciona la Figura";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBaseMenor
            // 
            this.txtBaseMenor.Location = new System.Drawing.Point(115, 253);
            this.txtBaseMenor.Name = "txtBaseMenor";
            this.txtBaseMenor.Size = new System.Drawing.Size(164, 22);
            this.txtBaseMenor.TabIndex = 4;
            // 
            // txtBaseMayor
            // 
            this.txtBaseMayor.Location = new System.Drawing.Point(332, 253);
            this.txtBaseMayor.Name = "txtBaseMayor";
            this.txtBaseMayor.Size = new System.Drawing.Size(164, 22);
            this.txtBaseMayor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Complete los datos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Base menor o radio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Base mayor";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(547, 253);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(164, 22);
            this.txtAltura.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Altura";
            // 
            // bttnCalcularArea
            // 
            this.bttnCalcularArea.Location = new System.Drawing.Point(115, 348);
            this.bttnCalcularArea.Name = "bttnCalcularArea";
            this.bttnCalcularArea.Size = new System.Drawing.Size(75, 23);
            this.bttnCalcularArea.TabIndex = 11;
            this.bttnCalcularArea.Text = "Calcular Area";
            this.bttnCalcularArea.UseVisualStyleBackColor = true;
            this.bttnCalcularArea.Click += new System.EventHandler(this.bttnCalcularArea_Click);
            // 
            // FormCaso4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnCalcularArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBaseMayor);
            this.Controls.Add(this.txtBaseMenor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkCuadrado);
            this.Controls.Add(this.chkTrapecio);
            this.Controls.Add(this.chkCirculo);
            this.Name = "FormCaso4";
            this.Text = "FormCaso4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCirculo;
        private System.Windows.Forms.CheckBox chkTrapecio;
        private System.Windows.Forms.CheckBox chkCuadrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaseMenor;
        private System.Windows.Forms.TextBox txtBaseMayor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttnCalcularArea;
    }
}