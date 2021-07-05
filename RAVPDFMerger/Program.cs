using Aspose.Pdf;
using Aspose.Pdf.Facades;
using System;

namespace RAVPDFMerger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the complete path of the directory which contains the PDFs ");
            string directoryPath = Console.ReadLine();

            PDFLocator pdfLocator = new PDFLocator(directoryPath);
            string[] allPdfInDirectory = pdfLocator.getAllPdfInDirectory();

            PdfFileEditor ravPdf = new PdfFileEditor();
            ravPdf.Concatenate(allPdfInDirectory, "merged.pdf");
            Document final = new Document();
            //TODO: Find out how to save the merged pdf
            final = ravPdf;
            final.Save(directoryPath);
        }
    }
}
