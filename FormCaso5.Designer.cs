namespace WindowsLab
{
    partial class FormCaso5
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkMasculino = new System.Windows.Forms.CheckBox();
            this.chkFemenino = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.chkEstandar = new System.Windows.Forms.CheckBox();
            this.chkInvitado = new System.Windows.Forms.CheckBox();
            this.bttnValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(289, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(219, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese su nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione su Genero";
            // 
            // chkMasculino
            // 
            this.chkMasculino.AutoSize = true;
            this.chkMasculino.Location = new System.Drawing.Point(289, 133);
            this.chkMasculino.Name = "chkMasculino";
            this.chkMasculino.Size = new System.Drawing.Size(90, 20);
            this.chkMasculino.TabIndex = 3;
            this.chkMasculino.Text = "Masculino";
            this.chkMasculino.UseVisualStyleBackColor = true;
            // 
            // chkFemenino
            // 
            this.chkFemenino.AutoSize = true;
            this.chkFemenino.Location = new System.Drawing.Point(419, 129);
            this.chkFemenino.Name = "chkFemenino";
            this.chkFemenino.Size = new System.Drawing.Size(89, 20);
            this.chkFemenino.TabIndex = 4;
            this.chkFemenino.Text = "Femenino";
            this.chkFemenino.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione su rol";
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(289, 184);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(112, 20);
            this.chkAdmin.TabIndex = 6;
            this.chkAdmin.Text = "Administrador";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // chkEstandar
            // 
            this.chkEstandar.AutoSize = true;
            this.chkEstandar.Location = new System.Drawing.Point(425, 184);
            this.chkEstandar.Name = "chkEstandar";
            this.chkEstandar.Size = new System.Drawing.Size(83, 20);
            this.chkEstandar.TabIndex = 7;
            this.chkEstandar.Text = "Estandar";
            this.chkEstandar.UseVisualStyleBackColor = true;
            // 
            // chkInvitado
            // 
            this.chkInvitado.AutoSize = true;
            this.chkInvitado.Location = new System.Drawing.Point(558, 184);
            this.chkInvitado.Name = "chkInvitado";
            this.chkInvitado.Size = new System.Drawing.Size(76, 20);
            this.chkInvitado.TabIndex = 8;
            this.chkInvitado.Text = "Invitado";
            this.chkInvitado.UseVisualStyleBackColor = true;
            // 
            // bttnValidar
            // 
            this.bttnValidar.Location = new System.Drawing.Point(491, 261);
            this.bttnValidar.Name = "bttnValidar";
            this.bttnValidar.Size = new System.Drawing.Size(143, 25);
            this.bttnValidar.TabIndex = 9;
            this.bttnValidar.Text = "Validar";
            this.bttnValidar.UseVisualStyleBackColor = true;
            this.bttnValidar.Click += new System.EventHandler(this.bttnValidar_Click);
            // 
            // FormCaso5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnValidar);
            this.Controls.Add(this.chkInvitado);
            this.Controls.Add(this.chkEstandar);
            this.Controls.Add(this.chkAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkFemenino);
            this.Controls.Add(this.chkMasculino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Name = "FormCaso5";
            this.Text = "FormCaso5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkMasculino;
        private System.Windows.Forms.CheckBox chkFemenino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.CheckBox chkEstandar;
        private System.Windows.Forms.CheckBox chkInvitado;
        private System.Windows.Forms.Button bttnValidar;
    }
}