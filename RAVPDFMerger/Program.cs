using System;

namespace RAVPDFMerger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the complete path of the directory which contains the PDFs ");
            string directoryPath = Console.ReadLine();

            PDFLocator tbd = new PDFLocator(directoryPath);
            string[] pdfs = tbd.getAllPDFInDirectory();
            //TODO: Rewrite. Delete tthis code later which is here just for a quick test
            Console.WriteLine("The directory contains the following PDFs: ");
            //Returns the paths of all PDFs in the directory
            foreach (string a in pdfs)
            {
                Console.WriteLine(a);
            }
        }
    }
}
