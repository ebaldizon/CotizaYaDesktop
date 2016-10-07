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
    public partial class CotizaYa : Form
    {
        public CotizaYa()
        {
            InitializeComponent();
           
            this.dtgwProducts.RowCount = 23;
            this.Text = "CotizaYa";
        }

    }
}
