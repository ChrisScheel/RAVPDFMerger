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
            string[] allPdfInDirectory = pdfLocator.GetAllPdfInDirectory();

            PdfFileEditor ravPdf = new PdfFileEditor();
            //the following code creates a merged pdf and saves it with the name "directory+_RAV.pdf" in the superior directory.
            //the trial version of aspose.pdf creates a watermark in the upper left corner of every page.
            ravPdf.Concatenate(allPdfInDirectory, directoryPath + "_RAV.pdf");

            Console.WriteLine("\nPDF documents merged into one");
        }
    }
}
