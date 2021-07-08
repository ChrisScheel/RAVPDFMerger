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
            //the following code creates a merged pdf and saves it with the name directory+super.pdf in a directory above.
            //TODO: Find out why?
            ravPdf.Concatenate(allPdfInDirectory, directoryPath + "super.pdf");
            //the following code doesn't create a pdf:
            //ravPdf.Concatenate(allPdfInDirectory, "super.pdf");

            Console.WriteLine("PDF merged");
        }
    }
}
