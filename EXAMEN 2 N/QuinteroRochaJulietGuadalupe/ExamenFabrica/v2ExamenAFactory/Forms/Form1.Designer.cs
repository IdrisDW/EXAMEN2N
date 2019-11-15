namespace v2ExamenAFactory.Forms
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
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnBlanco = new System.Windows.Forms.Button();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerde.ForeColor = System.Drawing.Color.Transparent;
            this.btnVerde.Location = new System.Drawing.Point(132, 355);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(206, 54);
            this.btnVerde.TabIndex = 11;
            this.btnVerde.Text = "Verde";
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.BtnVerde_Click_1);
            // 
            // btnBlanco
            // 
            this.btnBlanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBlanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlanco.ForeColor = System.Drawing.Color.Transparent;
            this.btnBlanco.Location = new System.Drawing.Point(132, 267);
            this.btnBlanco.Name = "btnBlanco";
            this.btnBlanco.Size = new System.Drawing.Size(206, 54);
            this.btnBlanco.TabIndex = 10;
            this.btnBlanco.Text = "Blanco";
            this.btnBlanco.UseVisualStyleBackColor = false;
            this.btnBlanco.Click += new System.EventHandler(this.BtnBlanco_Click_1);
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRojo.ForeColor = System.Drawing.Color.Transparent;
            this.btnRojo.Location = new System.Drawing.Point(132, 190);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(206, 54);
            this.btnRojo.TabIndex = 9;
            this.btnRojo.Text = "Rojo";
            this.btnRojo.UseVisualStyleBackColor = false;
            this.btnRojo.Click += new System.EventHandler(this.BtnRojo_Click_1);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdmin.Location = new System.Drawing.Point(132, 66);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(206, 54);
            this.btnAdmin.TabIndex = 8;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 452);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnBlanco);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.btnAdmin);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loggin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnBlanco;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnAdmin;
    }
}