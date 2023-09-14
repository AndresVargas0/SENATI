namespace Proyecto_Final
{
    partial class CRUD_Estudiantes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.nombre_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.apellido_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.apoderado_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dni_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.telefono_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.grado_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.seccion_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.titulo_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.matricular = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cerrar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // TextBox5
            // 
            this.TextBox5.BorderRadius = 8;
            this.TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox5.DefaultText = "";
            this.TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox5.Location = new System.Drawing.Point(273, 231);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.PasswordChar = '\0';
            this.TextBox5.PlaceholderText = "";
            this.TextBox5.SelectedText = "";
            this.TextBox5.Size = new System.Drawing.Size(213, 33);
            this.TextBox5.TabIndex = 4;
            this.TextBox5.TextChanged += new System.EventHandler(this.telefono_TextChanged);
            // 
            // TextBox4
            // 
            this.TextBox4.BorderRadius = 8;
            this.TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox4.DefaultText = "";
            this.TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox4.Location = new System.Drawing.Point(27, 231);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.PasswordChar = '\0';
            this.TextBox4.PlaceholderText = "";
            this.TextBox4.SelectedText = "";
            this.TextBox4.Size = new System.Drawing.Size(222, 33);
            this.TextBox4.TabIndex = 3;
            this.TextBox4.TextChanged += new System.EventHandler(this.dni_TextChanged);
            // 
            // nombre_lbl
            // 
            this.nombre_lbl.BackColor = System.Drawing.Color.Transparent;
            this.nombre_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nombre_lbl.Location = new System.Drawing.Point(27, 71);
            this.nombre_lbl.Name = "nombre_lbl";
            this.nombre_lbl.Size = new System.Drawing.Size(123, 18);
            this.nombre_lbl.TabIndex = 7;
            this.nombre_lbl.Text = "Nombre del Estudiante";
            // 
            // apellido_lbl
            // 
            this.apellido_lbl.BackColor = System.Drawing.Color.Transparent;
            this.apellido_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.apellido_lbl.Location = new System.Drawing.Point(273, 71);
            this.apellido_lbl.Name = "apellido_lbl";
            this.apellido_lbl.Size = new System.Drawing.Size(141, 18);
            this.apellido_lbl.TabIndex = 8;
            this.apellido_lbl.Text = "Apellido Paterno/Materno";
            // 
            // apoderado_lbl
            // 
            this.apoderado_lbl.BackColor = System.Drawing.Color.Transparent;
            this.apoderado_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apoderado_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.apoderado_lbl.Location = new System.Drawing.Point(27, 141);
            this.apoderado_lbl.Name = "apoderado_lbl";
            this.apoderado_lbl.Size = new System.Drawing.Size(126, 18);
            this.apoderado_lbl.TabIndex = 9;
            this.apoderado_lbl.Text = "Tutor Legal/Apoderado";
            // 
            // dni_lbl
            // 
            this.dni_lbl.BackColor = System.Drawing.Color.Transparent;
            this.dni_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dni_lbl.Location = new System.Drawing.Point(27, 210);
            this.dni_lbl.Name = "dni_lbl";
            this.dni_lbl.Size = new System.Drawing.Size(100, 18);
            this.dni_lbl.TabIndex = 10;
            this.dni_lbl.Text = "DNI del Estudiante";
            // 
            // telefono_lbl
            // 
            this.telefono_lbl.BackColor = System.Drawing.Color.Transparent;
            this.telefono_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.telefono_lbl.Location = new System.Drawing.Point(273, 210);
            this.telefono_lbl.Name = "telefono_lbl";
            this.telefono_lbl.Size = new System.Drawing.Size(49, 18);
            this.telefono_lbl.TabIndex = 11;
            this.telefono_lbl.Text = "Telefono";
            // 
            // grado_lbl
            // 
            this.grado_lbl.BackColor = System.Drawing.Color.Transparent;
            this.grado_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grado_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grado_lbl.Location = new System.Drawing.Point(27, 280);
            this.grado_lbl.Name = "grado_lbl";
            this.grado_lbl.Size = new System.Drawing.Size(35, 18);
            this.grado_lbl.TabIndex = 12;
            this.grado_lbl.Text = "Grado";
            // 
            // seccion_lbl
            // 
            this.seccion_lbl.BackColor = System.Drawing.Color.Transparent;
            this.seccion_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccion_lbl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.seccion_lbl.Location = new System.Drawing.Point(273, 280);
            this.seccion_lbl.Name = "seccion_lbl";
            this.seccion_lbl.Size = new System.Drawing.Size(44, 18);
            this.seccion_lbl.TabIndex = 13;
            this.seccion_lbl.Text = "Seccion";
            // 
            // titulo_lbl
            // 
            this.titulo_lbl.BackColor = System.Drawing.Color.Transparent;
            this.titulo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_lbl.Location = new System.Drawing.Point(65, 29);
            this.titulo_lbl.Name = "titulo_lbl";
            this.titulo_lbl.Size = new System.Drawing.Size(387, 22);
            this.titulo_lbl.TabIndex = 14;
            this.titulo_lbl.Text = "Inscripcion de Estudiantes al Periodo Academico 2024";
            // 
            // matricular
            // 
            this.matricular.BorderRadius = 5;
            this.matricular.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.matricular.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.matricular.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.matricular.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.matricular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.matricular.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.matricular.FillColor2 = System.Drawing.Color.DarkGreen;
            this.matricular.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricular.ForeColor = System.Drawing.Color.White;
            this.matricular.Location = new System.Drawing.Point(27, 351);
            this.matricular.Name = "matricular";
            this.matricular.Size = new System.Drawing.Size(116, 31);
            this.matricular.TabIndex = 7;
            this.matricular.Text = "MATRICULAR";
            this.matricular.Click += new System.EventHandler(this.matricular_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.BorderRadius = 8;
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1.DefaultText = "";
            this.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.Location = new System.Drawing.Point(27, 92);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.PlaceholderText = "";
            this.TextBox1.SelectedText = "";
            this.TextBox1.Size = new System.Drawing.Size(222, 33);
            this.TextBox1.TabIndex = 0;
            // 
            // TextBox2
            // 
            this.TextBox2.BorderRadius = 8;
            this.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox2.DefaultText = "";
            this.TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox2.Location = new System.Drawing.Point(273, 92);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.PasswordChar = '\0';
            this.TextBox2.PlaceholderText = "";
            this.TextBox2.SelectedText = "";
            this.TextBox2.Size = new System.Drawing.Size(213, 33);
            this.TextBox2.TabIndex = 1;
            // 
            // TextBox3
            // 
            this.TextBox3.BorderRadius = 8;
            this.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox3.DefaultText = "";
            this.TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox3.Location = new System.Drawing.Point(27, 165);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.PasswordChar = '\0';
            this.TextBox3.PlaceholderText = "";
            this.TextBox3.SelectedText = "";
            this.TextBox3.Size = new System.Drawing.Size(459, 33);
            this.TextBox3.TabIndex = 2;
            // 
            // ComboBox1
            // 
            this.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox1.ItemHeight = 30;
            this.ComboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.ComboBox1.Location = new System.Drawing.Point(273, 304);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(213, 36);
            this.ComboBox1.TabIndex = 6;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // ComboBox2
            // 
            this.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox2.ItemHeight = 30;
            this.ComboBox2.Items.AddRange(new object[] {
            "1ro",
            "2do",
            "3ro",
            "4to",
            "5to",
            "6to"});
            this.ComboBox2.Location = new System.Drawing.Point(27, 304);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(222, 36);
            this.ComboBox2.TabIndex = 5;
            this.ComboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // cerrar
            // 
            this.cerrar.BorderRadius = 5;
            this.cerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cerrar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cerrar.FillColor = System.Drawing.Color.Crimson;
            this.cerrar.FillColor2 = System.Drawing.Color.DarkRed;
            this.cerrar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar.ForeColor = System.Drawing.Color.White;
            this.cerrar.Location = new System.Drawing.Point(370, 351);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(116, 31);
            this.cerrar.TabIndex = 8;
            this.cerrar.Text = "CERRAR";
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // CRUD_Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(709, 404);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.matricular);
            this.Controls.Add(this.titulo_lbl);
            this.Controls.Add(this.seccion_lbl);
            this.Controls.Add(this.grado_lbl);
            this.Controls.Add(this.telefono_lbl);
            this.Controls.Add(this.dni_lbl);
            this.Controls.Add(this.apoderado_lbl);
            this.Controls.Add(this.apellido_lbl);
            this.Controls.Add(this.nombre_lbl);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CRUD_Estudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Matricula_Estudiantes";
            this.Load += new System.EventHandler(this.CRUD_Estudiantes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox TextBox5;
        private Guna.UI2.WinForms.Guna2TextBox TextBox4;
        private Guna.UI2.WinForms.Guna2HtmlLabel nombre_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel apellido_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel apoderado_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel dni_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel telefono_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel grado_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel seccion_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel titulo_lbl;
        private Guna.UI2.WinForms.Guna2GradientButton matricular;
        private Guna.UI2.WinForms.Guna2TextBox TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox3;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox2;
        private Guna.UI2.WinForms.Guna2GradientButton cerrar;
    }
}

