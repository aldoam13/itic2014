namespace iati2014
{
    partial class frm_grid
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
            this.cmd_limpiar = new System.Windows.Forms.Button();
            this.cmd_agregar = new System.Windows.Forms.Button();
            this.txtnivel = new System.Windows.Forms.TextBox();
            this.txtmateria = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIVEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmd_archivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_limpiar
            // 
            this.cmd_limpiar.Location = new System.Drawing.Point(675, 87);
            this.cmd_limpiar.Name = "cmd_limpiar";
            this.cmd_limpiar.Size = new System.Drawing.Size(121, 23);
            this.cmd_limpiar.TabIndex = 16;
            this.cmd_limpiar.Text = "Cancelar";
            this.cmd_limpiar.UseVisualStyleBackColor = true;
            // 
            // cmd_agregar
            // 
            this.cmd_agregar.Location = new System.Drawing.Point(675, 48);
            this.cmd_agregar.Name = "cmd_agregar";
            this.cmd_agregar.Size = new System.Drawing.Size(121, 23);
            this.cmd_agregar.TabIndex = 15;
            this.cmd_agregar.Text = "Agregar";
            this.cmd_agregar.UseVisualStyleBackColor = true;
            this.cmd_agregar.Click += new System.EventHandler(this.cmd_agregar_Click);
            // 
            // txtnivel
            // 
            this.txtnivel.Location = new System.Drawing.Point(461, 52);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(196, 20);
            this.txtnivel.TabIndex = 14;
            // 
            // txtmateria
            // 
            this.txtmateria.Location = new System.Drawing.Point(242, 52);
            this.txtmateria.Name = "txtmateria";
            this.txtmateria.Size = new System.Drawing.Size(196, 20);
            this.txtmateria.TabIndex = 13;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(20, 52);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(196, 20);
            this.txtnombre.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "NIVEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "MATERIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "NOMBRE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE,
            this.MATERIA,
            this.NIVEL});
            this.dataGridView1.Location = new System.Drawing.Point(20, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 192);
            this.dataGridView1.TabIndex = 17;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // MATERIA
            // 
            this.MATERIA.HeaderText = "MATERIA";
            this.MATERIA.Name = "MATERIA";
            // 
            // NIVEL
            // 
            this.NIVEL.HeaderText = "NIVEL";
            this.NIVEL.Name = "NIVEL";
            // 
            // cmd_archivo
            // 
            this.cmd_archivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_archivo.Location = new System.Drawing.Point(20, 128);
            this.cmd_archivo.Name = "cmd_archivo";
            this.cmd_archivo.Size = new System.Drawing.Size(171, 33);
            this.cmd_archivo.TabIndex = 18;
            this.cmd_archivo.Text = "Carga desde Archivo";
            this.cmd_archivo.UseVisualStyleBackColor = true;
            this.cmd_archivo.Click += new System.EventHandler(this.cmd_archivo_Click);
            // 
            // frm_grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 395);
            this.Controls.Add(this.cmd_archivo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmd_limpiar);
            this.Controls.Add(this.cmd_agregar);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.txtmateria);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_grid";
            this.Text = "frm_grid";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_limpiar;
        private System.Windows.Forms.Button cmd_agregar;
        private System.Windows.Forms.TextBox txtnivel;
        private System.Windows.Forms.TextBox txtmateria;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIVEL;
        private System.Windows.Forms.Button cmd_archivo;
    }
}