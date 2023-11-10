using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;

namespace ProjectPapyrus
{
    public partial class DocumentViewer : Form
    {
        string selectedFileName;

        private PdfViewer pdfViewer = new PdfViewer();

        private SqlConnection connection;

        public DocumentViewer(String fileName)
        {
            InitializeComponent();
            
            selectedFileName = fileName;

            string connectionString = "Server=tcp:projectusprotectedpapyrus.database.windows.net,1433;Initial Catalog=ProtectedPapyrus;Persist Security Info=False;User ID=reflexorigin;Password=waytoGO.1;MultipleActiveResultSets=true;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        private void HandleDocumentViewerLoad(object sender, EventArgs e)
        {
            

            byte[] binaryData = GetBinaryDataForAttachment(selectedFileName);
            string contentType = GetContentTypeForAttachment(selectedFileName);

            if (binaryData != null && binaryData.Length > 0)
            {
                if (contentType == "image/jpeg" || contentType == "image/png")
                {
                    ViewImage.Visible = true;
                    using (MemoryStream ms = new MemoryStream(binaryData))
                    {
                        Image image = Image.FromStream(ms);
                        ViewImage.Image = image;
                       // ViewImage.Image
                    }
                }

                else if (contentType == "application/pdf" )
                {
                    PdfViewer.Visible = true;

                    PdfViewer.Load += PdfViewer_Load;
                    //ViewWeb.DocumentStream = new MemoryStream(binaryData);
                }
                else

                {
                    ViewWeb.DocumentStream = new MemoryStream(binaryData);
                }
            }
            else
            {
                MessageBox.Show("Nothing to Show");
            }
        }

        private string GetContentTypeForAttachment(string fileName)
        {
            string contentType = null;

             using (SqlCommand command = new SqlCommand("SELECT ContentType FROM Attachments WHERE FileName = @FileName", connection))
             {
                 command.Parameters.AddWithValue("@FileName", fileName);
                 SqlDataReader reader = command.ExecuteReader();
                 if (reader.Read())
                 {
                     contentType = reader["ContentType"].ToString();
                 }
             }

            return contentType;
        }

        private byte[] GetBinaryDataForAttachment(string fileName)
        {
            byte[] binaryData = null;


             using (SqlCommand command = new SqlCommand("SELECT FileContent FROM Attachments WHERE FileName = @FileName", connection))
             {
                 command.Parameters.AddWithValue("@FileName", fileName);
                 SqlDataReader reader = command.ExecuteReader();
                 if (reader.Read())
                 {
                     binaryData = (byte[])reader["FileContent"];
                 }
             }

            return binaryData;
        }

        private void PdfViewer_Load(object sender, EventArgs e)
        {
            byte[] binaryData = GetBinaryDataForAttachment(selectedFileName);

            var ms = new MemoryStream(binaryData);
            PdfDocument pdfDocument = PdfDocument.Load(ms);
            PdfViewer.Document = pdfDocument;
        }
    }
}
