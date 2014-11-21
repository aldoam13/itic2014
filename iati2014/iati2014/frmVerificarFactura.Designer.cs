namespace iati2014
{
    partial class frmVerificarFactura
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcadena = new System.Windows.Forms.TextBox();
            this.cmd_revisa_factura = new System.Windows.Forms.Button();
            this.lbl_notificacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factura";
            // 
            // txtcadena
            // 
            this.txtcadena.Location = new System.Drawing.Point(16, 57);
            this.txtcadena.Name = "txtcadena";
            this.txtcadena.Size = new System.Drawing.Size(521, 20);
            this.txtcadena.TabIndex = 1;
            // 
            // cmd_revisa_factura
            // 
            this.cmd_revisa_factura.Location = new System.Drawing.Point(566, 41);
            this.cmd_revisa_factura.Name = "cmd_revisa_factura";
            this.cmd_revisa_factura.Size = new System.Drawing.Size(111, 36);
            this.cmd_revisa_factura.TabIndex = 2;
            this.cmd_revisa_factura.Text = "button1";
            this.cmd_revisa_factura.UseVisualStyleBackColor = true;
            this.cmd_revisa_factura.Click += new System.EventHandler(this.cmd_revisa_factura_Click);
            // 
            // lbl_notificacion
            // 
            this.lbl_notificacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_notificacion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_notificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notificacion.Location = new System.Drawing.Point(16, 133);
            this.lbl_notificacion.Name = "lbl_notificacion";
            this.lbl_notificacion.Size = new System.Drawing.Size(739, 76);
            this.lbl_notificacion.TabIndex = 3;
            this.lbl_notificacion.Text = "label2";
            // 
            // frmVerificarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 363);
            this.Controls.Add(this.lbl_notificacion);
            this.Controls.Add(this.cmd_revisa_factura);
            this.Controls.Add(this.txtcadena);
            this.Controls.Add(this.label1);
            this.Name = "frmVerificarFactura";
            this.Text = "frmVerificarFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcadena;
        private System.Windows.Forms.Button cmd_revisa_factura;
        private System.Windows.Forms.Label lbl_notificacion;
    }
}