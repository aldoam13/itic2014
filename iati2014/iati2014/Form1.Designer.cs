namespace iati2014
{
    partial class Form1
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
            this.cmd_creadirectorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_creadirectorio
            // 
            this.cmd_creadirectorio.Location = new System.Drawing.Point(382, 12);
            this.cmd_creadirectorio.Name = "cmd_creadirectorio";
            this.cmd_creadirectorio.Size = new System.Drawing.Size(203, 48);
            this.cmd_creadirectorio.TabIndex = 0;
            this.cmd_creadirectorio.Text = "Crear directorio";
            this.cmd_creadirectorio.UseVisualStyleBackColor = true;
            this.cmd_creadirectorio.Click += new System.EventHandler(this.cmd_creadirectorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 378);
            this.Controls.Add(this.cmd_creadirectorio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_creadirectorio;
    }
}

