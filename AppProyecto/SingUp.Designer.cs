namespace AppProyecto
{
    partial class SingUp
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
            label1 = new Label();
            txtCrearUsuario = new TextBox();
            label2 = new Label();
            txtCrearContraseña = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 227);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txtCrearUsuario
            // 
            txtCrearUsuario.Location = new Point(272, 219);
            txtCrearUsuario.Name = "txtCrearUsuario";
            txtCrearUsuario.Size = new Size(276, 23);
            txtCrearUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 298);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txtCrearContraseña
            // 
            txtCrearContraseña.Location = new Point(272, 295);
            txtCrearContraseña.Name = "txtCrearContraseña";
            txtCrearContraseña.Size = new Size(276, 23);
            txtCrearContraseña.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(356, 353);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 4;
            button1.Text = "Crear Cuenta";
            button1.UseVisualStyleBackColor = true;
            // 
            // SingUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtCrearContraseña);
            Controls.Add(label2);
            Controls.Add(txtCrearUsuario);
            Controls.Add(label1);
            Name = "SingUp";
            Text = "SingUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCrearUsuario;
        private Label label2;
        private TextBox txtCrearContraseña;
        private Button button1;
    }
}