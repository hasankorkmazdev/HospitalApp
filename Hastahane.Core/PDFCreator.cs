using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using Hastahane.Data.EntityFramework.DataAccesLayer.Concrete;
using System.Diagnostics;
using System.Drawing.Printing;

namespace Hastahane.Core
{
    public class PDFCreator
    {
        BaseFont arial;
        Document document;
        TransactionDAL transactiondal = new TransactionDAL();
        PatientDocumentDAL patientdal = new PatientDocumentDAL();
        public void WritePDF(string documentNumber, string path)
        {
            decimal total = 0;
            document = new iTextSharp.text.Document();
            //İsim pdf eklenecek
            PdfWriter.GetInstance(document, new FileStream(path + ".pdf", FileMode.Create));
            arial = BaseFont.CreateFont("C:\\windows\\fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font font = new Font(arial, 12, Font.NORMAL);
            if (document.IsOpen() == false)
            {
                document.Open();
                Data.EntityFramework.Models.Staff ms = new Data.EntityFramework.Models.Staff();
                PdfPTable table = new PdfPTable(5);
                PdfPCell cell1 = new PdfPCell(new Phrase(patientdal.Find(x => x.PatientDocumentID == documentNumber).Patient.Name + " " + patientdal.Find(x => x.PatientDocumentID == documentNumber).Patient.Surname));
                cell1.Colspan = 5;
                cell1.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                table.AddCell(cell1);
                PdfPCell title1 = new PdfPCell(new Phrase("İşlem Tarihi", font));
                PdfPCell title2 = new PdfPCell(new Phrase("İşlem Adı", font));
                PdfPCell title3 = new PdfPCell(new Phrase("Miktar", font));
                PdfPCell title4 = new PdfPCell(new Phrase("Doktor", font));
                PdfPCell title5 = new PdfPCell(new Phrase("Birim Fiyat", font));
                table.AddCell(title1);
                table.AddCell(title2);
                table.AddCell(title3);
                table.AddCell(title4);
                table.AddCell(title5);

                foreach (var item in transactiondal.FindAll(x => x.PatientDocumentID == documentNumber))
                {
                    table.AddCell(new Phrase(item.ProccesDate.ToString(), font));
                    table.AddCell(new Phrase(item.Procces.ProccesName, font));
                    table.AddCell(new Phrase(item.Piece.ToString() + " Adet", font));
                    table.AddCell(new Phrase(item.Staff.Name + item.Staff.Surname, font));
                    table.AddCell(new Phrase(item.Price.ToString() + " TL", font));
                    ms = item.Staff;
                    
                    total += item.Piece * item.Price;
                }
                
                PdfPTable tableright = new PdfPTable(1);
                tableright.SpacingBefore = 30;
                PdfPCell totalCell = new PdfPCell(new Phrase("Toplam Tutar : " + total.ToString() + " TL", font));
                PdfPCell totalCell2 = new PdfPCell(new Phrase(ms.Name+" "+ms.Surname, font));
                totalCell2.Border = Rectangle.NO_BORDER;
                totalCell2.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
                totalCell.Border = Rectangle.NO_BORDER;
                totalCell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
                tableright.AddCell(totalCell);
                tableright.AddCell(totalCell2);
                document.Add(table);
                document.Add(tableright);
                document.Close();
                Process.Start(path + ".pdf");

            }
        }

        public void Print()
        {
         
        }

    }
}
