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

        public Cotizador()
        {
            InitializeComponent();
            this.dtgwProducts.RowCount = 23;
            this.Text = "CotizaYa";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            invoiceAdmin = new InvoiceAdmin(txtName.Text, txtAddress.Text, dtpDate.Value, Int32.Parse(txtNumInvoice.Text), dtgwProducts);
            invoiceAdmin.calculateInvoice();

           this.txtSubTotal.Text = invoiceAdmin.invoice.SubTotal.ToString();
           this.txtTax.Text = invoiceAdmin.invoice.Tax.ToString();
           this.txtTotal.Text = invoiceAdmin.invoice.Total.ToString();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea enviar la cotización por correo?", "CotizaYA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                invoiceAdmin.fillWord();
            }
            
        }
    }
    
}
