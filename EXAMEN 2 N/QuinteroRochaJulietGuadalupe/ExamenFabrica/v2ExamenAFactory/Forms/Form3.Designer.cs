namespace v2ExamenAFactory.Forms
{
    partial class Form3
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
            this.lblTcombustible = new System.Windows.Forms.Label();
            this.lblCpasajeros = new System.Windows.Forms.Label();
            this.lblMatri = new System.Windows.Forms.Label();
            this.lblanio = new System.Windows.Forms.Label();
            this.lblPasaje = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblAsign = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtMatric = new System.Windows.Forms.TextBox();
            this.txtanio = new System.Windows.Forms.TextBox();
            this.txtPasaje = new System.Windows.Forms.TextBox();
            this.dupDownTcombus = new System.Windows.Forms.DomainUpDown();
            this.downAsig = new System.Windows.Forms.DomainUpDown();
            this.dupDownTipoV = new System.Windows.Forms.DomainUpDown();
            this.lblTipoV = new System.Windows.Forms.Label();
            this.txtCpasajeros = new System.Windows.Forms.TextBox();
            this.nomStorelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(157)))), ((int)(((byte)(41)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(369, 374);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 50);
            this.btnGuardar.TabIndex = 56;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // lblTcombustible
            // 
            this.lblTcombustible.AutoSize = true;
            this.lblTcombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTcombustible.Location = new System.Drawing.Point(64, 286);
            this.lblTcombustible.Name = "lblTcombustible";
            this.lblTcombustible.Size = new System.Drawing.Size(153, 18);
            this.lblTcombustible.TabIndex = 48;
            this.lblTcombustible.Text = "Tipo de combustible : ";
            // 
            // lblCpasajeros
            // 
            this.lblCpasajeros.AutoSize = true;
            this.lblCpasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpasajeros.Location = new System.Drawing.Point(38, 212);
            this.lblCpasajeros.Name = "lblCpasajeros";
            this.lblCpasajeros.Size = new System.Drawing.Size(179, 18);
            this.lblCpasajeros.TabIndex = 46;
            this.lblCpasajeros.Text = "Capacidad de pasajeros : ";
            // 
            // lblMatri
            // 
            this.lblMatri.AutoSize = true;
            this.lblMatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatri.Location = new System.Drawing.Point(137, 175);
            this.lblMatri.Name = "lblMatri";
            this.lblMatri.Size = new System.Drawing.Size(80, 18);
            this.lblMatri.TabIndex = 45;
            this.lblMatri.Text = "Matrícula : ";
            // 
            // lblanio
            // 
            this.lblanio.AutoSize = true;
            this.lblanio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanio.Location = new System.Drawing.Point(171, 145);
            this.lblanio.Name = "lblanio";
            this.lblanio.Size = new System.Drawing.Size(46, 18);
            this.lblanio.TabIndex = 44;
            this.lblanio.Text = "Año : ";
            // 
            // lblPasaje
            // 
            this.lblPasaje.AutoSize = true;
            this.lblPasaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasaje.Location = new System.Drawing.Point(152, 107);
            this.lblPasaje.Name = "lblPasaje";
            this.lblPasaje.Size = new System.Drawing.Size(65, 18);
            this.lblPasaje.TabIndex = 43;
            this.lblPasaje.Text = "Pasaje : ";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(155, 74);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(62, 18);
            this.lblMarca.TabIndex = 42;
            this.lblMarca.Text = "Marca : ";
            // 
            // lblAsign
            // 
            this.lblAsign.AutoSize = true;
            this.lblAsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsign.Location = new System.Drawing.Point(124, 37);
            this.lblAsign.Name = "lblAsign";
            this.lblAsign.Size = new System.Drawing.Size(93, 18);
            this.lblAsign.TabIndex = 40;
            this.lblAsign.Text = "Asignado a : ";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(224, 71);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(132, 20);
            this.txtMarca.TabIndex = 57;
            // 
            // txtMatric
            // 
            this.txtMatric.Location = new System.Drawing.Point(224, 176);
            this.txtMatric.Name = "txtMatric";
            this.txtMatric.Size = new System.Drawing.Size(132, 20);
            this.txtMatric.TabIndex = 58;
            // 
            // txtanio
            // 
            this.txtanio.Location = new System.Drawing.Point(223, 146);
            this.txtanio.Name = "txtanio";
            this.txtanio.Size = new System.Drawing.Size(52, 20);
            this.txtanio.TabIndex = 59;
            // 
            // txtPasaje
            // 
            this.txtPasaje.Location = new System.Drawing.Point(223, 105);
            this.txtPasaje.Name = "txtPasaje";
            this.txtPasaje.Size = new System.Drawing.Size(97, 20);
            this.txtPasaje.TabIndex = 60;
            // 
            // dupDownTcombus
            // 
            this.dupDownTcombus.Location = new System.Drawing.Point(223, 284);
            this.dupDownTcombus.Name = "dupDownTcombus";
            this.dupDownTcombus.Size = new System.Drawing.Size(120, 20);
            this.dupDownTcombus.TabIndex = 65;
            // 
            // downAsig
            // 
            this.downAsig.Location = new System.Drawing.Point(223, 35);
            this.downAsig.Name = "downAsig";
            this.downAsig.Size = new System.Drawing.Size(133, 20);
            this.downAsig.TabIndex = 66;
            // 
            // dupDownTipoV
            // 
            this.dupDownTipoV.Location = new System.Drawing.Point(225, 241);
            this.dupDownTipoV.Name = "dupDownTipoV";
            this.dupDownTipoV.Size = new System.Drawing.Size(120, 20);
            this.dupDownTipoV.TabIndex = 64;
            // 
            // lblTipoV
            // 
            this.lblTipoV.AutoSize = true;
            this.lblTipoV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoV.Location = new System.Drawing.Point(92, 243);
            this.lblTipoV.Name = "lblTipoV";
            this.lblTipoV.Size = new System.Drawing.Size(127, 18);
            this.lblTipoV.TabIndex = 47;
            this.lblTipoV.Text = "Tipo de vehiculo : ";
            // 
            // txtCpasajeros
            // 
            this.txtCpasajeros.Location = new System.Drawing.Point(225, 210);
            this.txtCpasajeros.Name = "txtCpasajeros";
            this.txtCpasajeros.Size = new System.Drawing.Size(52, 20);
            this.txtCpasajeros.TabIndex = 67;
            // 
            // nomStorelbl
            // 
            this.nomStorelbl.AutoSize = true;
            this.nomStorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomStorelbl.Location = new System.Drawing.Point(409, 35);
            this.nomStorelbl.Name = "nomStorelbl";
            this.nomStorelbl.Size = new System.Drawing.Size(0, 25);
            this.nomStorelbl.TabIndex = 68;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 461);
            this.Controls.Add(this.nomStorelbl);
            this.Controls.Add(this.txtCpasajeros);
            this.Controls.Add(this.downAsig);
            this.Controls.Add(this.dupDownTcombus);
            this.Controls.Add(this.dupDownTipoV);
            this.Controls.Add(this.txtPasaje);
            this.Controls.Add(this.txtanio);
            this.Controls.Add(this.txtMatric);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTcombustible);
            this.Controls.Add(this.lblTipoV);
            this.Controls.Add(this.lblCpasajeros);
            this.Controls.Add(this.lblMatri);
            this.Controls.Add(this.lblanio);
            this.Controls.Add(this.lblPasaje);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblAsign);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dar de alta";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTcombustible;
        private System.Windows.Forms.Label lblCpasajeros;
        private System.Windows.Forms.Label lblMatri;
        private System.Windows.Forms.Label lblanio;
        private System.Windows.Forms.Label lblPasaje;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblAsign;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtMatric;
        private System.Windows.Forms.TextBox txtanio;
        private System.Windows.Forms.TextBox txtPasaje;
        private System.Windows.Forms.DomainUpDown dupDownTcombus;
        private System.Windows.Forms.DomainUpDown downAsig;
        private System.Windows.Forms.DomainUpDown dupDownTipoV;
        private System.Windows.Forms.Label lblTipoV;
        private System.Windows.Forms.TextBox txtCpasajeros;
        private System.Windows.Forms.Label nomStorelbl;
    }
}