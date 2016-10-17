using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace CotizaYA_00.Business
{
    class PDFAdmin
    {
        public Microsoft.Office.Interop.Word.Document wordDocument { get; set; }
        private void WordToPDF(string pathWord, string pathPDF)
        {
            Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
            wordDocument = appWord.Documents.Open(@pathWord);
            wordDocument.ExportAsFixedFormat(@pathPDF, WdExportFormat.wdExportFormatPDF);

            //wordDocument = appWord.Documents.Open(@"F:\\BALRY.docx");
            //wordDocument.ExportAsFixedFormat(@"F:\DocTo.pdf", WdExportFormat.wdExportFormatPDF);
        }


    }
}
