using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizaYA_00
{
    public partial class FrmEmail : Form
    {
        string Path;

        public FrmEmail()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            

            DialogResult dialogResult = MessageBox.Show("¿Desea enviar el correo?", "CotizaYa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                EmailAdmin EA = new EmailAdmin();
                if(EA.sendEmail(txtUser.Text, txtPassword.Text, txtTo.Text, txtCC.Text, txtSubject.Text, txtMessage.Text, this.Path))
                    MessageBox.Show("Correo enviado", "CotizaYa");
                else
                    MessageBox.Show("Error al enviar el mensaje", "CotizaYa");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Envio cancelado");
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = true;
            openFileDialog1.InitialDirectory = "F:\\";

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                this.Path = openFileDialog1.FileName;
                lblFile.Text = this.Path;
            }  
        }

    }
}
