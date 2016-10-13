namespace CotizaYA_00
{
    partial class Cotizador
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnPlantillas = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCorreo = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgwProducts = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumInvoice = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgwProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblError);
            this.panel3.Controls.Add(this.btnWord);
            this.panel3.Controls.Add(this.btnPlantillas);
            this.panel3.Controls.Add(this.btnPDF);
            this.panel3.Controls.Add(this.btnImprimir);
            this.panel3.Controls.Add(this.btnCorreo);
            this.panel3.Controls.Add(this.btnCalcular);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.txtTax);
            this.panel3.Controls.Add(this.txtSubTotal);
            this.panel3.Controls.Add(this.lblTax);
            this.panel3.Controls.Add(this.lblSubTotal);
            this.panel3.Location = new System.Drawing.Point(27, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 163);
            this.panel3.TabIndex = 10;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(353, 124);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 14;
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(489, 51);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(119, 23);
            this.btnWord.TabIndex = 13;
            this.btnWord.Text = "Crear Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnPlantillas
            // 
            this.btnPlantillas.Location = new System.Drawing.Point(489, 22);
            this.btnPlantillas.Name = "btnPlantillas";
            this.btnPlantillas.Size = new System.Drawing.Size(119, 23);
            this.btnPlantillas.TabIndex = 12;
            this.btnPlantillas.Text = "Plantillas";
            this.btnPlantillas.UseVisualStyleBackColor = true;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(351, 74);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(119, 23);
            this.btnPDF.TabIndex = 11;
            this.btnPDF.Text = "Crear  PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(351, 48);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(119, 23);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnCorreo
            // 
            this.btnCorreo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCorreo.Location = new System.Drawing.Point(351, 22);
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(119, 23);
            this.btnCorreo.TabIndex = 9;
            this.btnCorreo.Text = "Enviar por correo";
            this.btnCorreo.UseVisualStyleBackColor = true;
            this.btnCorreo.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCalcular.Location = new System.Drawing.Point(72, 114);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(72, 77);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(199, 20);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotal.Location = new System.Drawing.Point(33, 84);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(72, 51);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(199, 20);
            this.txtTax.TabIndex = 5;
            this.txtTax.Text = "0";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(71, 22);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(200, 20);
            this.txtSubTotal.TabIndex = 4;
            this.txtSubTotal.Text = "0";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTax.Location = new System.Drawing.Point(30, 58);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(36, 13);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "I.V.A.:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSubTotal.Location = new System.Drawing.Point(18, 29);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgwProducts);
            this.panel2.Location = new System.Drawing.Point(27, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 341);
            this.panel2.TabIndex = 9;
            // 
            // dtgwProducts
            // 
            this.dtgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgwProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Description,
            this.Quantity,
            this.UnitPrice});
            this.dtgwProducts.Location = new System.Drawing.Point(3, 4);
            this.dtgwProducts.Name = "dtgwProducts";
            this.dtgwProducts.Size = new System.Drawing.Size(623, 380);
            this.dtgwProducts.TabIndex = 0;
            // 
            // Code
            // 
            this.Code.HeaderText = "Código";
            this.Code.Name = "Code";
            this.Code.Width = 60;
            // 
            // Description
            // 
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            this.Description.Width = 300;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Cantidad";
            this.Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Precio Unitario";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 103;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNumInvoice);
            this.panel1.Controls.Add(this.lblNumber);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(27, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 81);
            this.panel1.TabIndex = 8;
            // 
            // txtNumInvoice
            // 
            this.txtNumInvoice.Location = new System.Drawing.Point(394, 45);
            this.txtNumInvoice.Name = "txtNumInvoice";
            this.txtNumInvoice.Size = new System.Drawing.Size(200, 20);
            this.txtNumInvoice.TabIndex = 11;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNumber.Location = new System.Drawing.Point(324, 48);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(64, 13);
            this.lblNumber.TabIndex = 10;
            this.lblNumber.Text = "Factura Nº: ";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(394, 11);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDate.Location = new System.Drawing.Point(348, 17);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Fecha:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(71, 41);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddress.Location = new System.Drawing.Point(7, 48);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Ubicación:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(18, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nombre:";
            // 
            // Cotizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 643);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Cotizador";
            this.Text = "Cotizador";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgwProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCorreo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgwProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNumInvoice;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPlantillas;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Label lblError;
    }
}