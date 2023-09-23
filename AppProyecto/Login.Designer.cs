namespace AppProyecto
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
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtContraseña = new TextBox();
            label3 = new Label();
            checkMostrar = new CheckBox();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(183, 129);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(413, 23);
            txtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 137);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 207);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(183, 204);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(413, 23);
            txtContraseña.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(320, 47);
            label3.Name = "label3";
            label3.Size = new Size(135, 65);
            label3.TabIndex = 4;
            label3.Text = "Entra";
            // 
            // checkMostrar
            // 
            checkMostrar.AutoSize = true;
            checkMostrar.Location = new Point(504, 243);
            checkMostrar.Name = "checkMostrar";
            checkMostrar.Size = new Size(130, 19);
            checkMostrar.TabIndex = 5;
            checkMostrar.Text = "Mostrar Contraseña";
            checkMostrar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(347, 285);
            button1.Name = "button1";
            button1.Size = new Size(108, 23);
            button1.TabIndex = 6;
            button1.Text = "Acceder";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 341);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 7;
            label4.Text = "¿No estas registrado?";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(356, 372);
            button2.Name = "button2";
            button2.Size = new Size(99, 23);
            button2.TabIndex = 8;
            button2.Text = "Registrarme";
            button2.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(checkMostrar);
            Controls.Add(label3);
            Controls.Add(txtContraseña);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private TextBox txtContraseña;
        private Label label3;
        private CheckBox checkMostrar;
        private Button button1;
        private Label label4;
        private Button button2;
    }
}