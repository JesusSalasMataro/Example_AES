using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProgramaAlgoritmoAES
{
    public partial class Ventana : Form
    {
        private String archivo = "";
        private AES algoritmoAES;

        public Ventana()
        {
            InitializeComponent();

            algoritmoAES = new AES();

            btnCifrar.Enabled = false;
            btnDescifrar.Enabled = false;
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {

            String strNombreFicheroCifrado;
            String salt = txbSalt.Text;

            try
            {
                txbContenido.Text = algoritmoAES.Cifrar(txbContenido.Text, txbPassword.Text, salt);
                strNombreFicheroCifrado = archivo.Substring(0, archivo.Length - 4) + ".aes";
                lblContenido.Text = Path.GetFileName(strNombreFicheroCifrado);

                System.IO.File.WriteAllText(strNombreFicheroCifrado, txbContenido.Text);

                btnCifrar.Enabled = false;
                btnDescifrar.Enabled = true;
                archivo = strNombreFicheroCifrado;
            }
            catch
            {
                lblContenido.Text = "El password es incorrecto";
            }


        }

        private void btnDescifrar_Click(object sender, EventArgs e)
        {

            String strNombreFicheroDescifrado;
            String salt = txbSalt.Text;

            try
            {
                txbContenido.Text = algoritmoAES.Descifrar(txbContenido.Text, txbPassword.Text, salt);
                strNombreFicheroDescifrado = archivo.Substring(0, archivo.Length - 4) + ".txt";
                lblContenido.Text = Path.GetFileName(strNombreFicheroDescifrado);

                System.IO.File.WriteAllText(strNombreFicheroDescifrado, txbContenido.Text);

                btnCifrar.Enabled = true;
                btnDescifrar.Enabled = false;
                archivo = strNombreFicheroDescifrado;
            }
            catch
            {
                lblContenido.Text = "El password es incorrecto";
            }

        }

        private void btnSeleccionarFichero_Click(object sender, EventArgs e)
        {
            if (ofdNavegadorArchivos.ShowDialog() == DialogResult.OK) {
                archivo = ofdNavegadorArchivos.FileName;
                lblContenido.Text = Path.GetFileName(archivo);
                txbContenido.Text = System.IO.File.ReadAllText(archivo);
                if (archivo.Substring(archivo.Length - 4, 4).Equals(".aes")) {
                    btnCifrar.Enabled = false;
                    btnDescifrar.Enabled = true;
                }
                else {
                    btnCifrar.Enabled = true;
                    btnDescifrar.Enabled = false;
                }
            }
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked)
                txbPassword.PasswordChar = '\0';
            else
                txbPassword.PasswordChar = '*';
        }

        private void chkSalt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSalt.Checked)
                txbSalt.PasswordChar = '\0';
            else
                txbSalt.PasswordChar = '*';
        }

    }

   
}
