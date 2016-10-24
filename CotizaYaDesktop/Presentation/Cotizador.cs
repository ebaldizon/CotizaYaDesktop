using CotizaYA_00.Business;
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
    public partial class Cotizador : Form
    {
        InvoiceAdmin invoiceAdmin;
        bool calculate;

        public Cotizador()
        {
            InitializeComponent();
            this.dtgwProducts.RowCount = 23;
            this.Text = "CotizaYa";
            this.calculate = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            invoiceAdmin = new InvoiceAdmin(txtName.Text, txtAddress.Text, dtpDate.Value, Int32.Parse(txtNumInvoice.Text), dtgwProducts);
            invoiceAdmin.calculateInvoice();

           this.txtSubTotal.Text = invoiceAdmin.invoice.SubTotal.ToString();
           this.txtTax.Text = invoiceAdmin.invoice.Tax.ToString();
           this.txtTotal.Text = invoiceAdmin.invoice.Total.ToString();
           this.calculate = true;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FrmEmail frmE = new FrmEmail();
            frmE.Show();
        }

        public bool crearPDF()
        {
            if (allValidators())
            {
                if (this.invoiceAdmin.wordToPDF())
                {
                    MessageBox.Show("El PDF se ha creado exitosamente", "CotizaYa");
                    return true;
                }
                else
                {
                    MessageBox.Show("No se pudo crear el PDF");
                    return false;
                }
            }
            return false;
        }


        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (allValidators())
            {
                if (this.invoiceAdmin.wordToPDF())
                    MessageBox.Show("El PDF se ha creado exitosamente", "CotizaYa");
                else
                    MessageBox.Show("No se pudo crear el PDF");
            }
                
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            if (allValidators())
            {
                if(invoiceAdmin.fillWord())
                {
                    MessageBox.Show("Documento Word creado exitosamente","CotizaYa");
                }
                else
                {
                    MessageBox.Show("No se pudo crear el documento en Word", "CotizaYa");
                }
            }
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (allValidators())
            {
                invoiceAdmin.printWord();
            }
        }

        private bool validate_txtName()
        {
            if(txtName.Text == "")
            {
                lblError.Text = "* Hace falta rellenar el campo Nombre";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validate_txtAddress()
        {
            if (txtAddress.Text == "")
            {
                lblError.Text = "* Hace falta rellenar el campo Ubicacion";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validate_txtNumInvoice()
        {
            if (txtNumInvoice.Text == "")
            {
                lblError.Text = "* Hace falta rellenar el campo Factura Nº";
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validate_calculate()
        {
            if(this.calculate)
            {
                return true;
            }
            else
            {
                lblError.Text = "* Se necesita calcular.";
                return false;
            }
        }

        private bool allValidators()
        {
            if(validate_txtName() && validate_txtAddress() && validate_txtNumInvoice() && validate_calculate())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
