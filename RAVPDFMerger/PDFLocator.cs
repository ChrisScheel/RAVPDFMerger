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

        public string[] getAllPdfInDirectory()
        {
            //TODO: Add code for the case if there is no PDF at all and other checks
            string[] filePaths = Directory.GetFiles(directoryPath, "*.pdf");
            return filePaths;
        }

    }
}
