namespace WindowsLab
{
    partial class FormCaso2
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
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.bttnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(113, 81);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(100, 16);
            this.lblEdad.TabIndex = 0;
            this.lblEdad.Text = "Ingresa tu edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(300, 75);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 22);
            this.txtEdad.TabIndex = 1;
            // 
            // bttnInfo
            // 
            this.bttnInfo.Location = new System.Drawing.Point(297, 174);
            this.bttnInfo.Name = "bttnInfo";
            this.bttnInfo.Size = new System.Drawing.Size(110, 23);
            this.bttnInfo.TabIndex = 2;
            this.bttnInfo.Text = "Mostrar info";
            this.bttnInfo.UseVisualStyleBackColor = true;
            this.bttnInfo.Click += new System.EventHandler(this.bttnInfo_Click);
            // 
            // FormCaso2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnInfo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Name = "FormCaso2";
            this.Text = "FormCaso2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button bttnInfo;
    }
}