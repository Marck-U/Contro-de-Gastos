namespace prueba
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_registro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_entrar
            // 
            this.btn_entrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_entrar.Location = new System.Drawing.Point(110, 103);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(100, 23);
            this.btn_entrar.TabIndex = 2;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rut:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(110, 40);
            this.txt_name.Name = "txt_name";
            this.txt_name.ShortcutsEnabled = false;
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_name, "Ingrese rut sin guion");
            this.txt_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // btn_registro
            // 
            this.btn_registro.Location = new System.Drawing.Point(110, 146);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(100, 23);
            this.btn_registro.TabIndex = 3;
            this.btn_registro.Text = "Registrarse";
            this.btn_registro.UseVisualStyleBackColor = true;
            this.btn_registro.Click += new System.EventHandler(this.btn_registro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(110, 67);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.ShortcutsEnabled = false;
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_entrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_registro);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_entrar);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_registro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

