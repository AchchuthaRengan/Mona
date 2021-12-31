using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Reset Password[ALPHA] For User Module
    /// Secret key Generated and stored on DB to be used for password reset.
    /// Generated Secret key, encrypted, stored on PDF File which then used for authenticated user.
    /// PASSWORD RECOVERY KIT IN ALPHA
    /// </summary>
    public class ResetKeyFile
    {
        public bool CreatePDF(string location, string email, string key)
        {
            if (location != "" && email != "" && key != "")
            {
                PdfWriter pdfwriter = new PdfWriter(location);
                PdfDocument pdf = new PdfDocument(pdfwriter);
                Document document = new Document(pdf);
                Paragraph fields = new Paragraph("Email: " + email + "\n" + ":" + key);
                document.Add(fields);
                LineSeparator ls = new LineSeparator(new SolidLine());
                document.Add(ls);
                Image img = new Image(ImageDataFactory
                .Create(@"F:\mona_password_recovery_pic.png"))
                .SetTextAlignment(TextAlignment.CENTER);
                document.Add(img);
                document.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ReadPDF(string location)
        {
            var pdfDocument = new PdfDocument(new PdfReader(location));
            StringBuilder processed = new StringBuilder();
            var strategy = new LocationTextExtractionStrategy();
            string text = "";
            for (int i = 1; i <= pdfDocument.GetNumberOfPages(); ++i)
            {
                var page = pdfDocument.GetPage(i);
                text += PdfTextExtractor.GetTextFromPage(page, strategy);
                processed.Append(text);
            }
            return text;
        }

        private static Random random = new Random();

        public string GenerateSecretKey()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%&*+-/";
            return new string(Enumerable.Repeat(chars, 35)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

