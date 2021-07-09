using System;
using System.IO;

namespace RAVPDFMerger
{
    class PDFLocator
    {
        private string directoryPath = String.Empty;

        public PDFLocator(string directoryPath)
        {
            this.directoryPath = directoryPath;
        }

        public string[] GetAllPdfInDirectory()
        {
            //TODO: Add code for the case if there is no valid directory
            string[] filePaths = Directory.GetFiles(directoryPath, "*.pdf");

            if (filePaths == null || filePaths.Length == 0)
            {
                Console.WriteLine("\nYour chosen directory doesn't contain a PDF. The program will be closed.");
                Environment.Exit(0);
            }
            return filePaths;
        }

    }
}
