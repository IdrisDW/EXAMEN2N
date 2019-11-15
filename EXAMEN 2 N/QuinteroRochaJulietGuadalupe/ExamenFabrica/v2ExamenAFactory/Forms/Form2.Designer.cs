namespace v2ExamenAFactory.Forms
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.nomStorelbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnEliminaGremio = new System.Windows.Forms.Button();
            this.downAsigB = new System.Windows.Forms.DomainUpDown();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(157)))), ((int)(((byte)(41)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(47, 387);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(162, 44);
            this.btnGuardar.TabIndex = 56;
            this.btnGuardar.Text = "Dar de alta";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // nomStorelbl
            // 
            this.nomStorelbl.AutoSize = true;
            this.nomStorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomStorelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nomStorelbl.Location = new System.Drawing.Point(304, 32);
            this.nomStorelbl.Name = "nomStorelbl";
            this.nomStorelbl.Size = new System.Drawing.Size(110, 24);
            this.nomStorelbl.TabIndex = 55;
            this.nomStorelbl.Text = "Transportes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 172);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Inventario";
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimina.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnElimina.Location = new System.Drawing.Point(47, 449);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(162, 42);
            this.btnElimina.TabIndex = 57;
            this.btnElimina.Text = "Eliminar";
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(157)))), ((int)(((byte)(41)))));
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAsignar.Location = new System.Drawing.Point(308, 387);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(174, 44);
            this.btnAsignar.TabIndex = 58;
            this.btnAsignar.Text = "Asignar gremio";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminaGremio
            // 
            this.btnEliminaGremio.BackColor = System.Drawing.Color.Gray;
            this.btnEliminaGremio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaGremio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaGremio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminaGremio.Location = new System.Drawing.Point(308, 449);
            this.btnEliminaGremio.Name = "btnEliminaGremio";
            this.btnEliminaGremio.Size = new System.Drawing.Size(174, 42);
            this.btnEliminaGremio.TabIndex = 59;
            this.btnEliminaGremio.Text = "Eliminar de gremio";
            this.btnEliminaGremio.UseVisualStyleBackColor = false;
            this.btnEliminaGremio.Click += new System.EventHandler(this.button3_Click);
            // 
            // downAsigB
            // 
            this.downAsigB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downAsigB.Location = new System.Drawing.Point(504, 98);
            this.downAsigB.Name = "downAsigB";
            this.downAsigB.Size = new System.Drawing.Size(133, 26);
            this.downAsigB.TabIndex = 68;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFiltrar.Location = new System.Drawing.Point(504, 142);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(143, 42);
            this.btnFiltrar.TabIndex = 69;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 518);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.downAsigB);
            this.Controls.Add(this.btnEliminaGremio);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.nomStorelbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label nomStorelbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnEliminaGremio;
        private System.Windows.Forms.DomainUpDown downAsigB;
        private System.Windows.Forms.Button btnFiltrar;
    }
}