using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Web;
using Winnovative.WnvHtmlConvert;

namespace Library.Tools
{
    public class ExportPdf
    {
        public static ExportPdf CreateInstant()
        {
            return new ExportPdf();
        }

        public void Export(string FileName, string Content)
        {
            PdfConverter pdfConverter = new PdfConverter();
            pdfConverter.PdfDocumentOptions.PdfPageSize = PdfPageSize.A4;
            pdfConverter.PdfDocumentOptions.PdfPageOrientation = PDFPageOrientation.Portrait;
            pdfConverter.PdfDocumentOptions.PdfCompressionLevel = PdfCompressionLevel.Normal;
            pdfConverter.PageWidth = 750;
            pdfConverter.LicenseKey = "s5iCk4KTgYCBk4adg5OAgp2CgZ2KioqK";
            pdfConverter.PdfDocumentOptions.LeftMargin = 15;
            pdfConverter.PdfDocumentOptions.RightMargin = 15;
            pdfConverter.PdfDocumentOptions.TopMargin = 15;
            pdfConverter.PdfDocumentOptions.BottomMargin = 15;
            pdfConverter.PdfDocumentOptions.LiveUrlsEnabled = true;
            pdfConverter.PdfDocumentOptions.EmbedFonts = true;
            pdfConverter.ScriptsEnabled = pdfConverter.ScriptsEnabledInImage = true;
            pdfConverter.PdfDocumentOptions.JpegCompressionEnabled = true;
            byte[] downloadBytes = pdfConverter.GetPdfBytesFromHtmlString(Content);
            
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.AddHeader("Content-Type", "binary/octet-stream");
            HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + FileName + ".pdf" + "; size=" + downloadBytes.Length.ToString());
            HttpContext.Current.Response.Flush();
            HttpContext.Current.Response.BinaryWrite(downloadBytes);
            HttpContext.Current.Response.Flush();
            HttpContext.Current.Response.End();
        }
    }
}
