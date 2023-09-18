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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.correo = new Guna.UI2.WinForms.Guna2TextBox();
            this.contraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.correo_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.contaseña_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ingresar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.salir = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_img = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Proyecto_Final.Properties.Resources.colegio;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(57, 8);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(219, 198);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // correo
            // 
            this.correo.BackColor = System.Drawing.Color.Transparent;
            this.correo.BorderColor = System.Drawing.Color.White;
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
            this.correo.IconLeft = ((System.Drawing.Image)(resources.GetObject("correo.IconLeft")));
            this.correo.Location = new System.Drawing.Point(36, 218);
            this.correo.Name = "correo";
            this.correo.PasswordChar = '\0';
            this.correo.PlaceholderText = "";
            this.correo.SelectedText = "";
            this.correo.Size = new System.Drawing.Size(255, 32);
            this.correo.TabIndex = 1;
            // 
            // contraseña
            // 
            this.contraseña.BackColor = System.Drawing.Color.Transparent;
            this.contraseña.BorderColor = System.Drawing.Color.White;
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
            this.contraseña.IconLeft = ((System.Drawing.Image)(resources.GetObject("contraseña.IconLeft")));
            this.contraseña.Location = new System.Drawing.Point(36, 293);
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
            this.correo_lbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.correo_lbl.Location = new System.Drawing.Point(36, 197);
            this.correo_lbl.Name = "correo_lbl";
            this.correo_lbl.Size = new System.Drawing.Size(65, 18);
            this.correo_lbl.TabIndex = 3;
            this.correo_lbl.Text = "Docente";
            // 
            // contaseña_lbl
            // 
            this.contaseña_lbl.BackColor = System.Drawing.Color.Transparent;
            this.contaseña_lbl.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contaseña_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.contaseña_lbl.Location = new System.Drawing.Point(36, 272);
            this.contaseña_lbl.Name = "contaseña_lbl";
            this.contaseña_lbl.Size = new System.Drawing.Size(88, 18);
            this.contaseña_lbl.TabIndex = 4;
            this.contaseña_lbl.Text = "Contraseña";
            // 
            // ingresar
            // 
            this.ingresar.Animated = true;
            this.ingresar.BackColor = System.Drawing.Color.Transparent;
            this.ingresar.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.ingresar.BorderRadius = 5;
            this.ingresar.BorderThickness = 1;
            this.ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresar.DefaultAutoSize = true;
            this.ingresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ingresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ingresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ingresar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ingresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ingresar.FillColor = System.Drawing.Color.Transparent;
            this.ingresar.FillColor2 = System.Drawing.Color.Transparent;
            this.ingresar.FocusedColor = System.Drawing.Color.Transparent;
            this.ingresar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar.ForeColor = System.Drawing.Color.White;
            this.ingresar.Image = ((System.Drawing.Image)(resources.GetObject("ingresar.Image")));
            this.ingresar.Location = new System.Drawing.Point(36, 344);
            this.ingresar.Name = "ingresar";
            this.ingresar.Padding = new System.Windows.Forms.Padding(2);
            this.ingresar.Size = new System.Drawing.Size(117, 30);
            this.ingresar.TabIndex = 8;
            this.ingresar.Text = "INGRESAR";
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // salir
            // 
            this.salir.Animated = true;
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.salir.BorderRadius = 5;
            this.salir.BorderThickness = 1;
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.DefaultAutoSize = true;
            this.salir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.salir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.salir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salir.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.salir.FillColor = System.Drawing.Color.Transparent;
            this.salir.FillColor2 = System.Drawing.Color.Transparent;
            this.salir.FocusedColor = System.Drawing.Color.Transparent;
            this.salir.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.White;
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(175, 344);
            this.salir.Name = "salir";
            this.salir.Padding = new System.Windows.Forms.Padding(2);
            this.salir.Size = new System.Drawing.Size(89, 30);
            this.salir.TabIndex = 9;
            this.salir.Text = "SALIR";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(537, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Time";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Login_Load);
            // 
            // timer_img
            // 
            this.timer_img.Enabled = true;
            this.timer_img.Interval = 3000;
            this.timer_img.Tick += new System.EventHandler(this.timer_img_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.Tag = "";
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "4.jpg");
            this.imageList1.Images.SetKeyName(1, "3.jpg");
            this.imageList1.Images.SetKeyName(2, "2.jpg");
            this.imageList1.Images.SetKeyName(3, "1.jpg");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ImageKey = "1.jpg";
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(325, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 256);
            this.label2.TabIndex = 13;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(611, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.contaseña_lbl);
            this.Controls.Add(this.correo_lbl);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.guna2PictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colegio EOH I.E.D.";
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
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer_img;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
    }
}