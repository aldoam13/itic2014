namespace clase
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtmateria = new System.Windows.Forms.TextBox();
            this.txtnivel = new System.Windows.Forms.TextBox();
            this.cmd_agregar = new System.Windows.Forms.Button();
            this.cmd_limpiar = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcolumna = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.materia,
            this.nivel});
            this.dataGridView1.Location = new System.Drawing.Point(26, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MATERIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NIVEL";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(26, 35);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(196, 20);
            this.txtnombre.TabIndex = 4;
            // 
            // txtmateria
            // 
            this.txtmateria.Location = new System.Drawing.Point(248, 35);
            this.txtmateria.Name = "txtmateria";
            this.txtmateria.Size = new System.Drawing.Size(196, 20);
            this.txtmateria.TabIndex = 5;
            // 
            // txtnivel
            // 
            this.txtnivel.Location = new System.Drawing.Point(467, 35);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(196, 20);
            this.txtnivel.TabIndex = 6;
            // 
            // cmd_agregar
            // 
            this.cmd_agregar.Location = new System.Drawing.Point(681, 31);
            this.cmd_agregar.Name = "cmd_agregar";
            this.cmd_agregar.Size = new System.Drawing.Size(121, 23);
            this.cmd_agregar.TabIndex = 7;
            this.cmd_agregar.Text = "Agregar";
            this.cmd_agregar.UseVisualStyleBackColor = true;
            this.cmd_agregar.Click += new System.EventHandler(this.cmd_agregar_Click);
            // 
            // cmd_limpiar
            // 
            this.cmd_limpiar.Location = new System.Drawing.Point(681, 70);
            this.cmd_limpiar.Name = "cmd_limpiar";
            this.cmd_limpiar.Size = new System.Drawing.Size(121, 23);
            this.cmd_limpiar.TabIndex = 8;
            this.cmd_limpiar.Text = "Cancelar";
            this.cmd_limpiar.UseVisualStyleBackColor = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // materia
            // 
            this.materia.HeaderText = "materia";
            this.materia.Name = "materia";
            // 
            // nivel
            // 
            this.nivel.HeaderText = "nivel";
            this.nivel.Name = "nivel";
            // 
            // txtcolumna
            // 
            this.txtcolumna.Location = new System.Drawing.Point(26, 102);
            this.txtcolumna.Name = "txtcolumna";
            this.txtcolumna.Size = new System.Drawing.Size(100, 20);
            this.txtcolumna.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "NUEVA COLUMNA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcolumna);
            this.Controls.Add(this.cmd_limpiar);
            this.Controls.Add(this.cmd_agregar);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.txtmateria);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtmateria;
        private System.Windows.Forms.TextBox txtnivel;
        private System.Windows.Forms.Button cmd_agregar;
        private System.Windows.Forms.Button cmd_limpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivel;
        private System.Windows.Forms.TextBox txtcolumna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}