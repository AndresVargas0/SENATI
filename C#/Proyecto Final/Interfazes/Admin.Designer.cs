namespace Proyecto_Final.Interfazes
{
    partial class Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.tabla = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apoderadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estudiantesMatriculadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new Proyecto_Final.BDDataSet();
            this.estudiantes_MatriculadosTableAdapter = new Proyecto_Final.BDDataSetTableAdapters.Estudiantes_MatriculadosTableAdapter();
            this.actualizar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.eliminar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.matricular = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.seccion_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.grado_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.telefono_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dni_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.apoderado_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.apellido_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nombre_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.salir = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Editar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.informe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesMatriculadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabla.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla.ColumnHeadersHeight = 15;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.apoderadoDataGridViewTextBoxColumn,
            this.dNIDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.gradoDataGridViewTextBoxColumn,
            this.seccionDataGridViewTextBoxColumn});
            this.tabla.DataSource = this.estudiantesMatriculadosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.tabla.Location = new System.Drawing.Point(23, 303);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersVisible = false;
            this.tabla.Size = new System.Drawing.Size(609, 191);
            this.tabla.TabIndex = 0;
            this.tabla.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.tabla.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tabla.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tabla.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tabla.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tabla.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tabla.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tabla.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.tabla.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tabla.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabla.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabla.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tabla.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tabla.ThemeStyle.HeaderStyle.Height = 15;
            this.tabla.ThemeStyle.ReadOnly = false;
            this.tabla.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.tabla.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabla.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabla.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabla.ThemeStyle.RowsStyle.Height = 22;
            this.tabla.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.tabla.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellContentClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // apoderadoDataGridViewTextBoxColumn
            // 
            this.apoderadoDataGridViewTextBoxColumn.DataPropertyName = "Apoderado";
            this.apoderadoDataGridViewTextBoxColumn.HeaderText = "Apoderado";
            this.apoderadoDataGridViewTextBoxColumn.Name = "apoderadoDataGridViewTextBoxColumn";
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // gradoDataGridViewTextBoxColumn
            // 
            this.gradoDataGridViewTextBoxColumn.DataPropertyName = "Grado";
            this.gradoDataGridViewTextBoxColumn.HeaderText = "Grado";
            this.gradoDataGridViewTextBoxColumn.Name = "gradoDataGridViewTextBoxColumn";
            // 
            // seccionDataGridViewTextBoxColumn
            // 
            this.seccionDataGridViewTextBoxColumn.DataPropertyName = "Seccion";
            this.seccionDataGridViewTextBoxColumn.HeaderText = "Seccion";
            this.seccionDataGridViewTextBoxColumn.Name = "seccionDataGridViewTextBoxColumn";
            // 
            // estudiantesMatriculadosBindingSource
            // 
            this.estudiantesMatriculadosBindingSource.DataMember = "Estudiantes_Matriculados";
            this.estudiantesMatriculadosBindingSource.DataSource = this.bDDataSet;
            this.estudiantesMatriculadosBindingSource.CurrentChanged += new System.EventHandler(this.estudiantesMatriculadosBindingSource_CurrentChanged);
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudiantes_MatriculadosTableAdapter
            // 
            this.estudiantes_MatriculadosTableAdapter.ClearBeforeFill = true;
            // 
            // actualizar
            // 
            this.actualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.actualizar.Animated = true;
            this.actualizar.BackColor = System.Drawing.Color.Transparent;
            this.actualizar.BackgroundImage = global::Proyecto_Final.Properties.Resources._2546705;
            this.actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actualizar.BorderRadius = 5;
            this.actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.actualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.actualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.actualizar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.actualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.actualizar.FillColor = System.Drawing.Color.Transparent;
            this.actualizar.FillColor2 = System.Drawing.Color.Transparent;
            this.actualizar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.actualizar.ForeColor = System.Drawing.Color.White;
            this.actualizar.Location = new System.Drawing.Point(530, 194);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(34, 34);
            this.actualizar.TabIndex = 9;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eliminar.Animated = true;
            this.eliminar.BackColor = System.Drawing.Color.Transparent;
            this.eliminar.BorderRadius = 5;
            this.eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminar.DefaultAutoSize = true;
            this.eliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.eliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.eliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.eliminar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.eliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.eliminar.FillColor = System.Drawing.Color.Transparent;
            this.eliminar.FillColor2 = System.Drawing.Color.Silver;
            this.eliminar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.ForeColor = System.Drawing.Color.White;
            this.eliminar.Image = global::Proyecto_Final.Properties.Resources.eliminar;
            this.eliminar.Location = new System.Drawing.Point(516, 141);
            this.eliminar.Name = "eliminar";
            this.eliminar.Padding = new System.Windows.Forms.Padding(2);
            this.eliminar.Size = new System.Drawing.Size(113, 30);
            this.eliminar.TabIndex = 10;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // matricular
            // 
            this.matricular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.matricular.Animated = true;
            this.matricular.BackColor = System.Drawing.Color.Transparent;
            this.matricular.BorderRadius = 5;
            this.matricular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matricular.DefaultAutoSize = true;
            this.matricular.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.matricular.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.matricular.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.matricular.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.matricular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.matricular.FillColor = System.Drawing.Color.Transparent;
            this.matricular.FillColor2 = System.Drawing.Color.LimeGreen;
            this.matricular.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matricular.ForeColor = System.Drawing.Color.White;
            this.matricular.Image = global::Proyecto_Final.Properties.Resources.matricular;
            this.matricular.Location = new System.Drawing.Point(495, 48);
            this.matricular.Name = "matricular";
            this.matricular.Padding = new System.Windows.Forms.Padding(2);
            this.matricular.Size = new System.Drawing.Size(133, 30);
            this.matricular.TabIndex = 11;
            this.matricular.Text = "MATRICULAR";
            this.matricular.Click += new System.EventHandler(this.matricular_Click);
            // 
            // ComboBox2
            // 
            this.ComboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox2.BorderRadius = 8;
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
            this.ComboBox2.Location = new System.Drawing.Point(23, 251);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(222, 36);
            this.ComboBox2.TabIndex = 19;
            // 
            // ComboBox1
            // 
            this.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox1.BorderRadius = 8;
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
            this.ComboBox1.Location = new System.Drawing.Point(269, 251);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(213, 36);
            this.ComboBox1.TabIndex = 20;
            // 
            // TextBox3
            // 
            this.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox3.BackColor = System.Drawing.Color.Transparent;
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
            this.TextBox3.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextBox3.IconLeft")));
            this.TextBox3.IconLeftSize = new System.Drawing.Size(15, 15);
            this.TextBox3.Location = new System.Drawing.Point(23, 118);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.PasswordChar = '\0';
            this.TextBox3.PlaceholderText = "";
            this.TextBox3.SelectedText = "";
            this.TextBox3.Size = new System.Drawing.Size(459, 33);
            this.TextBox3.TabIndex = 16;
            // 
            // TextBox2
            // 
            this.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox2.BackColor = System.Drawing.Color.Transparent;
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
            this.TextBox2.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextBox2.IconLeft")));
            this.TextBox2.IconLeftSize = new System.Drawing.Size(15, 15);
            this.TextBox2.Location = new System.Drawing.Point(269, 45);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.PasswordChar = '\0';
            this.TextBox2.PlaceholderText = "";
            this.TextBox2.SelectedText = "";
            this.TextBox2.Size = new System.Drawing.Size(213, 33);
            this.TextBox2.TabIndex = 15;
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox1.BackColor = System.Drawing.Color.Transparent;
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
            this.TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextBox1.IconLeft")));
            this.TextBox1.IconLeftSize = new System.Drawing.Size(15, 15);
            this.TextBox1.Location = new System.Drawing.Point(23, 45);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.PlaceholderText = "";
            this.TextBox1.SelectedText = "";
            this.TextBox1.Size = new System.Drawing.Size(222, 33);
            this.TextBox1.TabIndex = 14;
            // 
            // seccion_lbl
            // 
            this.seccion_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.seccion_lbl.BackColor = System.Drawing.Color.Transparent;
            this.seccion_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccion_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.seccion_lbl.Location = new System.Drawing.Point(269, 227);
            this.seccion_lbl.Name = "seccion_lbl";
            this.seccion_lbl.Size = new System.Drawing.Size(46, 18);
            this.seccion_lbl.TabIndex = 27;
            this.seccion_lbl.Text = "Seccion";
            // 
            // grado_lbl
            // 
            this.grado_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grado_lbl.BackColor = System.Drawing.Color.Transparent;
            this.grado_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grado_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.grado_lbl.Location = new System.Drawing.Point(23, 227);
            this.grado_lbl.Name = "grado_lbl";
            this.grado_lbl.Size = new System.Drawing.Size(37, 18);
            this.grado_lbl.TabIndex = 26;
            this.grado_lbl.Text = "Grado";
            // 
            // telefono_lbl
            // 
            this.telefono_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telefono_lbl.BackColor = System.Drawing.Color.Transparent;
            this.telefono_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.telefono_lbl.Location = new System.Drawing.Point(269, 163);
            this.telefono_lbl.Name = "telefono_lbl";
            this.telefono_lbl.Size = new System.Drawing.Size(53, 18);
            this.telefono_lbl.TabIndex = 25;
            this.telefono_lbl.Text = "Telefono";
            // 
            // dni_lbl
            // 
            this.dni_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dni_lbl.BackColor = System.Drawing.Color.Transparent;
            this.dni_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.dni_lbl.Location = new System.Drawing.Point(23, 163);
            this.dni_lbl.Name = "dni_lbl";
            this.dni_lbl.Size = new System.Drawing.Size(106, 18);
            this.dni_lbl.TabIndex = 24;
            this.dni_lbl.Text = "DNI del Estudiante";
            // 
            // apoderado_lbl
            // 
            this.apoderado_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apoderado_lbl.BackColor = System.Drawing.Color.Transparent;
            this.apoderado_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apoderado_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.apoderado_lbl.Location = new System.Drawing.Point(23, 94);
            this.apoderado_lbl.Name = "apoderado_lbl";
            this.apoderado_lbl.Size = new System.Drawing.Size(132, 18);
            this.apoderado_lbl.TabIndex = 23;
            this.apoderado_lbl.Text = "Tutor Legal/Apoderado";
            // 
            // apellido_lbl
            // 
            this.apellido_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apellido_lbl.BackColor = System.Drawing.Color.Transparent;
            this.apellido_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.apellido_lbl.Location = new System.Drawing.Point(269, 24);
            this.apellido_lbl.Name = "apellido_lbl";
            this.apellido_lbl.Size = new System.Drawing.Size(148, 18);
            this.apellido_lbl.TabIndex = 22;
            this.apellido_lbl.Text = "Apellido Paterno/Materno";
            // 
            // nombre_lbl
            // 
            this.nombre_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombre_lbl.BackColor = System.Drawing.Color.Transparent;
            this.nombre_lbl.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.nombre_lbl.Location = new System.Drawing.Point(23, 24);
            this.nombre_lbl.Name = "nombre_lbl";
            this.nombre_lbl.Size = new System.Drawing.Size(130, 18);
            this.nombre_lbl.TabIndex = 21;
            this.nombre_lbl.Text = "Nombre del Estudiante";
            // 
            // TextBox4
            // 
            this.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox4.BackColor = System.Drawing.Color.Transparent;
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
            this.TextBox4.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextBox4.IconLeft")));
            this.TextBox4.IconLeftSize = new System.Drawing.Size(15, 15);
            this.TextBox4.Location = new System.Drawing.Point(23, 184);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.PasswordChar = '\0';
            this.TextBox4.PlaceholderText = "";
            this.TextBox4.SelectedText = "";
            this.TextBox4.Size = new System.Drawing.Size(222, 33);
            this.TextBox4.TabIndex = 17;
            // 
            // TextBox5
            // 
            this.TextBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox5.BackColor = System.Drawing.Color.Transparent;
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
            this.TextBox5.IconLeft = ((System.Drawing.Image)(resources.GetObject("TextBox5.IconLeft")));
            this.TextBox5.IconLeftSize = new System.Drawing.Size(15, 15);
            this.TextBox5.Location = new System.Drawing.Point(269, 184);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.PasswordChar = '\0';
            this.TextBox5.PlaceholderText = "";
            this.TextBox5.SelectedText = "";
            this.TextBox5.Size = new System.Drawing.Size(213, 33);
            this.TextBox5.TabIndex = 18;
            // 
            // salir
            // 
            this.salir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.salir.Animated = true;
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.BackgroundImage = global::Proyecto_Final.Properties.Resources._1486564399_close_81512;
            this.salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salir.BorderRadius = 5;
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.salir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.salir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salir.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.salir.FillColor = System.Drawing.Color.Transparent;
            this.salir.FillColor2 = System.Drawing.Color.Transparent;
            this.salir.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.salir.ForeColor = System.Drawing.Color.White;
            this.salir.Location = new System.Drawing.Point(582, 195);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(34, 34);
            this.salir.TabIndex = 28;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Editar
            // 
            this.Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Editar.Animated = true;
            this.Editar.BackColor = System.Drawing.Color.Transparent;
            this.Editar.BorderRadius = 5;
            this.Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editar.DefaultAutoSize = true;
            this.Editar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Editar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Editar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Editar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Editar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Editar.FillColor = System.Drawing.Color.Transparent;
            this.Editar.FillColor2 = System.Drawing.Color.MediumTurquoise;
            this.Editar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.ForeColor = System.Drawing.Color.White;
            this.Editar.Image = global::Proyecto_Final.Properties.Resources.editar;
            this.Editar.Location = new System.Drawing.Point(530, 95);
            this.Editar.Name = "Editar";
            this.Editar.Padding = new System.Windows.Forms.Padding(2);
            this.Editar.Size = new System.Drawing.Size(98, 30);
            this.Editar.TabIndex = 29;
            this.Editar.Text = "EDITAR";
            // 
            // informe
            // 
            this.informe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.informe.BackColor = System.Drawing.Color.Transparent;
            this.informe.BackgroundImage = global::Proyecto_Final.Properties.Resources.campos;
            this.informe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.informe.Location = new System.Drawing.Point(553, 235);
            this.informe.Name = "informe";
            this.informe.Size = new System.Drawing.Size(34, 35);
            this.informe.TabIndex = 30;
            this.informe.UseVisualStyleBackColor = false;
            this.informe.Click += new System.EventHandler(this.informe_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Final.Properties.Resources.bg_icon_box5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 515);
            this.Controls.Add(this.informe);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.ComboBox2);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.seccion_lbl);
            this.Controls.Add(this.grado_lbl);
            this.Controls.Add(this.telefono_lbl);
            this.Controls.Add(this.dni_lbl);
            this.Controls.Add(this.apoderado_lbl);
            this.Controls.Add(this.apellido_lbl);
            this.Controls.Add(this.nombre_lbl);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.matricular);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.tabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesMatriculadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView tabla;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource estudiantesMatriculadosBindingSource;
        private BDDataSetTableAdapters.Estudiantes_MatriculadosTableAdapter estudiantes_MatriculadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apoderadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccionDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2GradientButton actualizar;
        private Guna.UI2.WinForms.Guna2GradientButton eliminar;
        private Guna.UI2.WinForms.Guna2GradientButton matricular;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox2;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel seccion_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel grado_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel telefono_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel dni_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel apoderado_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel apellido_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel nombre_lbl;
        private Guna.UI2.WinForms.Guna2TextBox TextBox4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox5;
        private Guna.UI2.WinForms.Guna2GradientButton salir;
        private Guna.UI2.WinForms.Guna2GradientButton Editar;
        private System.Windows.Forms.Button informe;
    }
}