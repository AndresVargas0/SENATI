namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Boton = new Button();
            email = new TextBox();
            pass = new TextBox();
            SuspendLayout();
            // 
            // Boton
            // 
            Boton.Location = new Point(132, 194);
            Boton.Name = "Boton";
            Boton.Size = new Size(142, 39);
            Boton.TabIndex = 0;
            Boton.Text = "Login";
            Boton.UseVisualStyleBackColor = true;
            Boton.Click += Boton_Click;
            // 
            // email
            // 
            email.Location = new Point(83, 89);
            email.Name = "email";
            email.Size = new Size(248, 23);
            email.TabIndex = 1;
            email.TextChanged += email_TextChanged;
            // 
            // pass
            // 
            pass.Location = new Point(83, 134);
            pass.Name = "pass";
            pass.Size = new Size(248, 23);
            pass.TabIndex = 1;
            pass.TextChanged += pass_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 290);
            Controls.Add(pass);
            Controls.Add(email);
            Controls.Add(Boton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Boton;
        private TextBox email;
        private TextBox pass;
    }
}