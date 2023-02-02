using System.IO;
using iTextSharp.text.pdf;

namespace PoC_Pdf {
    internal class Program {

        public static void Main(string[] args) {
            string inputFile = @"D:\Escritorio\Work\test.pdf";
            string outputFile = @"D:\Escritorio\Work\testOut.pdf";
            string password = "rE3@xno6pfTK8gKjHy&@M@9m7CjyjT@";

            using(Stream input = new FileStream(inputFile, FileMode.Open, FileAccess.Read, FileShare.Read)) {
                using(Stream output = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None)) {
                    var reader = new PdfReader(input);
                    PdfEncryptor.Encrypt(reader, output, true, password, password, PdfWriter.ALLOW_PRINTING);
                }
            }
        }
    }
}
