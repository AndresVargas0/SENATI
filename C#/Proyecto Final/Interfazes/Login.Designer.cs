namespace Proyecto_Final.Interfazes
{
    partial class Login
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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.correo = new Guna.UI2.WinForms.Guna2TextBox();
            this.contraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.correo_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.contaseña_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ingresar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.salir = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Proyecto_Final.Properties.Resources.colegio;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(57, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(219, 198);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // correo
            // 
            this.correo.BorderColor = System.Drawing.Color.Gray;
            this.correo.BorderRadius = 8;
            this.correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.correo.DefaultText = "";
            this.correo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.correo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.correo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.correo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.correo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.correo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.correo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.correo.Location = new System.Drawing.Point(36, 236);
            this.correo.Name = "correo";
            this.correo.PasswordChar = '\0';
            this.correo.PlaceholderText = "";
            this.correo.SelectedText = "";
            this.correo.Size = new System.Drawing.Size(255, 32);
            this.correo.TabIndex = 1;
            // 
            // contraseña
            // 
            this.contraseña.BorderColor = System.Drawing.Color.Gray;
            this.contraseña.BorderRadius = 8;
            this.contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contraseña.DefaultText = "";
            this.contraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contraseña.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contraseña.Location = new System.Drawing.Point(36, 311);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.PlaceholderText = "";
            this.contraseña.SelectedText = "";
            this.contraseña.Size = new System.Drawing.Size(255, 32);
            this.contraseña.TabIndex = 2;
            // 
            // correo_lbl
            // 
            this.correo_lbl.BackColor = System.Drawing.Color.Transparent;
            this.correo_lbl.Location = new System.Drawing.Point(36, 215);
            this.correo_lbl.Name = "correo_lbl";
            this.correo_lbl.Size = new System.Drawing.Size(34, 15);
            this.correo_lbl.TabIndex = 3;
            this.correo_lbl.Text = "Correo";
            // 
            // contaseña_lbl
            // 
            this.contaseña_lbl.BackColor = System.Drawing.Color.Transparent;
            this.contaseña_lbl.Location = new System.Drawing.Point(36, 290);
            this.contaseña_lbl.Name = "contaseña_lbl";
            this.contaseña_lbl.Size = new System.Drawing.Size(57, 15);
            this.contaseña_lbl.TabIndex = 4;
            this.contaseña_lbl.Text = "Contraseña";
            // 
            // ingresar
            // 
            this.ingresar.BackColor = System.Drawing.Color.Transparent;
            this.ingresar.BorderRadius = 5;
            this.ingresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ingresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ingresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ingresar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ingresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ingresar.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.ingresar.FillColor2 = System.Drawing.Color.DarkGreen;
            this.ingresar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar.ForeColor = System.Drawing.Color.White;
            this.ingresar.Location = new System.Drawing.Point(36, 366);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(116, 31);
            this.ingresar.TabIndex = 8;
            this.ingresar.Text = "INGRESAR";
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.BorderRadius = 5;
            this.salir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.salir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.salir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salir.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.salir.FillColor = System.Drawing.Color.Crimson;
            this.salir.FillColor2 = System.Drawing.Color.DarkRed;
            this.salir.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.White;
            this.salir.Location = new System.Drawing.Point(175, 366);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(116, 31);
            this.salir.TabIndex = 9;
            this.salir.Text = "SALIR";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 417);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.contaseña_lbl);
            this.Controls.Add(this.correo_lbl);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox correo;
        private Guna.UI2.WinForms.Guna2TextBox contraseña;
        private Guna.UI2.WinForms.Guna2HtmlLabel correo_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel contaseña_lbl;
        private Guna.UI2.WinForms.Guna2GradientButton ingresar;
        private Guna.UI2.WinForms.Guna2GradientButton salir;
    }
}