namespace ProgramaAlgoritmoAES
{
    partial class Ventana
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana));
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbContenido = new System.Windows.Forms.TextBox();
            this.btnDescifrar = new System.Windows.Forms.Button();
            this.lblContenido = new System.Windows.Forms.Label();
            this.ofdNavegadorArchivos = new System.Windows.Forms.OpenFileDialog();
            this.btnSeleccionarFichero = new System.Windows.Forms.Button();
            this.lblSalt = new System.Windows.Forms.Label();
            this.txbSalt = new System.Windows.Forms.TextBox();
            this.chkPassword = new System.Windows.Forms.CheckBox();
            this.chkSalt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(49, 126);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // btnCifrar
            // 
            this.btnCifrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCifrar.Location = new System.Drawing.Point(52, 357);
            this.btnCifrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(148, 66);
            this.btnCifrar.TabIndex = 2;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(53, 147);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(332, 23);
            this.txbPassword.TabIndex = 5;
            // 
            // txbContenido
            // 
            this.txbContenido.Location = new System.Drawing.Point(461, 71);
            this.txbContenido.Margin = new System.Windows.Forms.Padding(4);
            this.txbContenido.Multiline = true;
            this.txbContenido.Name = "txbContenido";
            this.txbContenido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbContenido.Size = new System.Drawing.Size(695, 352);
            this.txbContenido.TabIndex = 6;
            // 
            // btnDescifrar
            // 
            this.btnDescifrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescifrar.Location = new System.Drawing.Point(237, 357);
            this.btnDescifrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescifrar.Name = "btnDescifrar";
            this.btnDescifrar.Size = new System.Drawing.Size(148, 66);
            this.btnDescifrar.TabIndex = 7;
            this.btnDescifrar.Text = "Descifrar";
            this.btnDescifrar.UseVisualStyleBackColor = true;
            this.btnDescifrar.Click += new System.EventHandler(this.btnDescifrar_Click);
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(458, 45);
            this.lblContenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(0, 17);
            this.lblContenido.TabIndex = 8;
            // 
            // ofdNavegadorArchivos
            // 
            this.ofdNavegadorArchivos.Filter = "Archivos de texto (*.txt)|*.txt|Archivos cifrados (*.aes)|*.aes|Todos los archivo" +
    "s (*.*)|*.*";
            // 
            // btnSeleccionarFichero
            // 
            this.btnSeleccionarFichero.Location = new System.Drawing.Point(52, 26);
            this.btnSeleccionarFichero.Name = "btnSeleccionarFichero";
            this.btnSeleccionarFichero.Size = new System.Drawing.Size(159, 55);
            this.btnSeleccionarFichero.TabIndex = 9;
            this.btnSeleccionarFichero.Text = "Seleccionar fichero...";
            this.btnSeleccionarFichero.UseVisualStyleBackColor = true;
            this.btnSeleccionarFichero.Click += new System.EventHandler(this.btnSeleccionarFichero_Click);
            // 
            // lblSalt
            // 
            this.lblSalt.AutoSize = true;
            this.lblSalt.Location = new System.Drawing.Point(50, 228);
            this.lblSalt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalt.Name = "lblSalt";
            this.lblSalt.Size = new System.Drawing.Size(36, 17);
            this.lblSalt.TabIndex = 10;
            this.lblSalt.Text = "Salt:";
            // 
            // txbSalt
            // 
            this.txbSalt.Location = new System.Drawing.Point(52, 249);
            this.txbSalt.Margin = new System.Windows.Forms.Padding(4);
            this.txbSalt.Name = "txbSalt";
            this.txbSalt.PasswordChar = '*';
            this.txbSalt.Size = new System.Drawing.Size(332, 23);
            this.txbSalt.TabIndex = 11;
            this.txbSalt.Text = "Po34gt_a0";
            // 
            // chkPassword
            // 
            this.chkPassword.AutoSize = true;
            this.chkPassword.Location = new System.Drawing.Point(53, 177);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.Size = new System.Drawing.Size(159, 21);
            this.chkPassword.TabIndex = 12;
            this.chkPassword.Text = "Visualizar carácteres";
            this.chkPassword.UseVisualStyleBackColor = true;
            this.chkPassword.CheckedChanged += new System.EventHandler(this.chkPassword_CheckedChanged);
            // 
            // chkSalt
            // 
            this.chkSalt.AutoSize = true;
            this.chkSalt.Location = new System.Drawing.Point(52, 279);
            this.chkSalt.Name = "chkSalt";
            this.chkSalt.Size = new System.Drawing.Size(159, 21);
            this.chkSalt.TabIndex = 13;
            this.chkSalt.Text = "Visualizar carácteres";
            this.chkSalt.UseVisualStyleBackColor = true;
            this.chkSalt.CheckedChanged += new System.EventHandler(this.chkSalt_CheckedChanged);
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 461);
            this.Controls.Add(this.chkSalt);
            this.Controls.Add(this.chkPassword);
            this.Controls.Add(this.txbSalt);
            this.Controls.Add(this.lblSalt);
            this.Controls.Add(this.btnSeleccionarFichero);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.btnDescifrar);
            this.Controls.Add(this.txbContenido);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.lblPassword);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ventana";
            this.Text = "Cifrado - descifrado AES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbContenido;
        private System.Windows.Forms.Button btnDescifrar;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.OpenFileDialog ofdNavegadorArchivos;
        private System.Windows.Forms.Button btnSeleccionarFichero;
        private System.Windows.Forms.Label lblSalt;
        private System.Windows.Forms.TextBox txbSalt;
        private System.Windows.Forms.CheckBox chkPassword;
        private System.Windows.Forms.CheckBox chkSalt;
    }
}

