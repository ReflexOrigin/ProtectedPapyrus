using ProtectedPapyrus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.IO;
using MimeMapping;
using PdfiumViewer;
using System.Net.Mime;
using System.Net.NetworkInformation;


namespace ProjectPapyrus
{
    public partial class Menu : Form
    {
        private SqlConnection connection;

        public Menu()
        {
            InitializeComponent();

            string connectionString = "Server=tcp:projectusprotectedpapyrus.database.windows.net,1433;Initial Catalog=ProtectedPapyrus;Persist Security Info=False;User ID=reflexorigin;Password=waytoGO.1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
                Environment.Exit(1);
        }
        int clicks = 0;
        private void btnChoices_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
            if (clicks % 2 == 0)
            {
                clicks++;
                btnChoices.BackgroundImage = Properties.Resources.choice2;

            }
            else
            {
                clicks--;
                btnChoices.BackgroundImage = Properties.Resources.choice;

            }
        }
        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 50)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 250)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }
        int mov, movX, movY;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
            this.Opacity = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            control.DoMaximize(this, btn);
        }

        private Guid actualNoteID = Guid.Empty;

        private void New_Click(object sender, EventArgs e)
        {

            save.Text = "Save";
            btnCopy.Text = "Copy";
            panelNew.Visible = true;
            outKey.Visible = false;
            btnCopy.Visible = false;
            panelView.Visible = false;
            pnlOkView.Visible = false;
            if (viewBar.Height > 150)
            {
                viewBarTransition.Start();
            }

            actualNoteID = Guid.NewGuid(); // Generate a new Guid

            string insertQuery = "INSERT INTO creation (NoteID) VALUES (@NoteID)";

            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
            {
                insertCommand.Parameters.Add(new SqlParameter("@NoteID", SqlDbType.UniqueIdentifier) { Value = actualNoteID });
                insertCommand.ExecuteNonQuery();
            }
            
        }



        private void verifybtn_Click(object sender, EventArgs e)
        {
            //type code here
            outKey.Text = "Encryption Key Here";
            outKey.Visible = true;
            btnCopy.Visible = true;

            if (actualNoteID == Guid.Empty)
            {
                MessageBox.Show("No Note to save.");
                return;
            }

            string connectionString = "Server=tcp:projectusprotectedpapyrus.database.windows.net,1433;Initial Catalog=ProtectedPapyrus;Persist Security Info=False;User ID=reflexorigin;Password=waytoGO.1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Notes (NoteID, NoteContent, CreatedDate) VALUES (@NoteID, @NoteContent, GETDATE())", connection, transaction))
                        {
                            insertCommand.Parameters.Add(new SqlParameter("@NoteID", SqlDbType.UniqueIdentifier) { Value = actualNoteID });
                            insertCommand.Parameters.AddWithValue("@NoteContent", NoteText.Text);

                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {

                                string selectKeyQuery = "SELECT EncryptionKey FROM EncryptionKeys WHERE NoteID = @NoteID";
                                using (SqlCommand selectKeyCommand = new SqlCommand(selectKeyQuery, connection, transaction))
                                {
                                    selectKeyCommand.Parameters.Add(new SqlParameter("@NoteID", SqlDbType.UniqueIdentifier) { Value = actualNoteID });


                                    using (SqlDataReader reader = selectKeyCommand.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            if (reader["EncryptionKey"] != DBNull.Value)
                                            {
                                                string encryptionKey = reader.GetString(0);
                                                outKey.Text = encryptionKey;
                                            }
                                        }
                                    }
                                }

                                MessageBox.Show("Note has been saved successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Save operation failed.");
                            }
                        }

                        if (attachmentQueue.Any())
                        {
                            Upload(this, EventArgs.Empty);
                        }


                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred while saving the note: " + ex.Message);
                    }
                }
            }
        }



        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outKey.Text);
            btnCopy.Text = "Copied";

            Home.PerformClick();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelNew.Visible = false;
            panelView.Visible = false;
            pnlOkView.Visible = false;
            if (viewBar.Height > 150)
            {
                viewBarTransition.Start();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            viewBarTransition.Start();
            viewSave.Text = "Save";
            ViewCopy.Text = "Copy";
            panelNew.Visible = false;
            panelView.Visible = false;
            pnlOkView.Visible = false;
        }
        bool viewBarExpand = false;
        private void viewBarTransition_Tick(object sender, EventArgs e)
        {
            if (viewBarExpand == false)
            {
                viewBar.Height += 10;
                if (viewBar.Height >= 151)
                {
                    viewBarTransition.Stop();
                    viewBarExpand = true;
                }

            }
            else
            {
                viewBar.Height -= 10;
                if (viewBar.Height <= 51)
                {
                    viewBarTransition.Stop();
                    viewBarExpand = false;
                }
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            panelNew.Visible = false;
            panelView.Visible = false;
            pnlOkView.Visible = false;
            if (viewBar.Height > 150)
            {
                viewBarTransition.Start();
            }
        }



        private void btnByKey_Click(object sender, EventArgs e)
        {
            panelView.Visible = true;
            pnlViewAction.Visible = true;
            GridView.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //if database disconnect success then
            this.Hide();
            var login = new Login();
            login.Show();
        }



        private void Choose_Click(object sender, EventArgs e)
        {
            panelView.Visible = true;
            pnlViewAction.Visible = true;
            GridView.Visible = true;
            
         

            using (SqlCommand command = new SqlCommand("SELECT * FROM NotesWAttach;", connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        GridView.Rows.Clear(); 

                        while (reader.Read())
                        {
                            Guid noteID = reader.GetGuid(0);


                            string guidString = noteID.ToString();
                            int rowIndex = GridView.Rows.Add();

                            GridView.Rows[rowIndex].Cells["NoteID"].Value = guidString;
                            GridView.Rows[rowIndex].Cells["NoteContent"].Value = reader["NoteContent"];
                            GridView.Rows[rowIndex].Cells["CreatedDate"].Value = reader["CreatedDate"];
                            GridView.Rows[rowIndex].Cells["FileName"].Value = reader["FileName"];

                               
                            byte[] binaryData = (byte[])reader["FileContent"];

                            if (binaryData != null && binaryData.Length > 0)
                            {
                                string contentType = reader["ContentType"].ToString();

                                if (contentType == "image/jpeg" || contentType == "image/png")
                                {
                                    using (MemoryStream ms = new MemoryStream(binaryData)) 
                                    {
                                        Image image = System.Drawing.Image.FromStream(ms);

                                        GridView["Image", rowIndex].Value = image;
                                    }
                                }
                                 else if (contentType == "application/pdf")
                                    {

                                    //using (MemoryStream ms = new MemoryStream(binaryData))
                                    {
                                        //PdfDocument pdfDocument = PdfDocument.Load(ms);


                                    }

                                 }   
                            }
                        }
                    }
                }
            }
            
        }

        private bool CheckAccess(string userProvidedKey, out Guid matchingNoteID, out string noteContent, out List<string> attachmentFileNames)
        {
            string queryKey = "SELECT NoteID FROM EncryptionKeys WHERE EncryptionKey = @UserProvidedKey";
            string queryNoteContent = "SELECT NoteContent FROM Notes WHERE NoteID = @NoteID";
            string queryAttachment = "SELECT FileName FROM Attachments WHERE NoteID = @NoteID";

            matchingNoteID = Guid.Empty;
            noteContent = null;
            attachmentFileNames = new List<string>();

            using (SqlCommand keyCommand = new SqlCommand(queryKey, connection))
            {
                keyCommand.Parameters.AddWithValue("@UserProvidedKey", userProvidedKey);

                using (SqlDataReader keyReader = keyCommand.ExecuteReader())
                {
                    if (keyReader.Read())
                    {
                        matchingNoteID = keyReader.GetGuid(0);
                    }
                }
            }

            using (SqlCommand noteContentCommand = new SqlCommand(queryNoteContent, connection))
            {
                noteContentCommand.Parameters.AddWithValue("@NoteID", matchingNoteID);

                using (SqlDataReader noteContentReader = noteContentCommand.ExecuteReader())
                {
                    if (noteContentReader.Read())
                    {
                        noteContent = noteContentReader.GetString(0);
                    }
                }
            }

            using (SqlCommand attachmentCommand = new SqlCommand(queryAttachment, connection))
            {
                attachmentCommand.Parameters.AddWithValue("@NoteID", matchingNoteID);

                using (SqlDataReader attachmentReader = attachmentCommand.ExecuteReader())
                {
                    while (attachmentReader.Read())
                    {
                        string fileName = attachmentReader.GetString(0);
                        AtcName.Text = fileName;
                        AtcName.Items.Add(fileName);
                        attachmentFileNames.Add(fileName);
                    }
                }
            }

            return !string.IsNullOrEmpty(noteContent) && attachmentFileNames.Count > 0;
        }



        private void Continue_Click(object sender, EventArgs e)
        {
            panelView.Visible = false;
            pnlOkView.Visible = true;

            string userProvidedKey = inputKey.Text;
            Guid matchingNoteID;
            string noteContent;
            List<string> attachmentFileNames; // Change the type here

            bool hasAccess = CheckAccess(userProvidedKey, out matchingNoteID, out noteContent, out attachmentFileNames);

            if (hasAccess)
            {
                ViewRichBox.Text = noteContent;
            }
            else
            {
                MessageBox.Show("Invalid key. Access denied.");
            }
        }



        private void UpdateNoteContent(Guid noteID, string newContent)
        {

            string updateQuery = "UPDATE Notes SET NoteContent = @NewContent WHERE NoteID = @NoteID";

            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
            {
                updateCommand.Parameters.Add(new SqlParameter("@NoteID", SqlDbType.UniqueIdentifier) { Value = noteID });
                updateCommand.Parameters.AddWithValue("@NewContent", newContent);

                int rowsAffected = updateCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Note updated successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to update the note.");
                }
            }
        }

        private void viewSave_Click(object sender, EventArgs e)
        {
            ViewEncryptKey.Visible = true;
            ViewCopy.Visible = true;
            viewSave.Text = "Saved";

        }

        private List<Attachment> attachmentQueue = new List<Attachment>();

        public class Attachment
        {
            public Guid NoteID { get; set; }
            public string FileName { get; set; }
            public byte[] FileContent { get; set; }
            public string ContentType { get; set; } 

            public Attachment(Guid noteID, string fileName, byte[] fileContent , string contentType)
            {
                NoteID = noteID;
                FileName = fileName;
                ContentType = contentType; 
                FileContent = fileContent;
            }
        }



        private void UploadAttachment(Guid noteID, string fileName, byte[] fileContent , string contentType)
        {
            Attachment attachment = new Attachment(noteID, fileName, fileContent, contentType); 
            attachmentQueue.Add(attachment);
        }




        private void Upload(object sender, EventArgs e)
        {
            if (attachmentQueue.Count == 0)
            {
                MessageBox.Show("There are no attachments to upload.");
                return;
            }
                try
                {
                    foreach (Attachment attachment in attachmentQueue)
                    {
                        Guid noteID = actualNoteID;

                        string insertQuery = "INSERT INTO Attachments (NoteID, FileName, FileContent, ContentType) VALUES (@NoteID, @FileName, @FileContent, @ContentType)";

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.Add(new SqlParameter("@NoteID", SqlDbType.UniqueIdentifier) { Value = noteID });
                            command.Parameters.AddWithValue("@FileName", attachment.FileName);
                            command.Parameters.Add(new SqlParameter("@FileContent", SqlDbType.VarBinary) { Value = attachment.FileContent });
                            command.Parameters.AddWithValue("@ContentType", attachment.ContentType); 

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Attachment saved successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to save the attachment.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while uploading the attachments: " + ex.Message);
                }
                finally
                {
                    attachmentQueue.Clear();
                }
        }





        private void ViewCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outKey.Text);
            btnCopy.Text = "Copied";
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

            panelNew.Visible = false;
            panelView.Visible = false;
            pnlOkView.Visible = false;
            if (viewBar.Height > 150)
            {
                viewBarTransition.Start();
            }
            var about = new about();

            if (Application.OpenForms["about"] == null)
            {

                about.Show();

                about.TopMost = true;
            }
        }

        private void ViewCancel_Click(object sender, EventArgs e)
        {

        }

        private void addAtch_Click(object sender, EventArgs e)
        {

        }

        private void NewAttach_Click(object sender, EventArgs e)
        {
            
        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'protectedPapyrusDataSet5.NotesWAAttach' table. You can move, or remove it, as needed.
            //this.NotesWAAttachTableAdapter1.Fill(this.protectedPapyrusDataSet5.NotesWAAttach);
            // TODO: This line of code loads data into the 'protectedPapyrusDataSet4.NotesWAAttach' table. You can move, or remove it, as needed.
            //this.NotesWAAttachTableAdapter.Fill(this.protectedPapyrusDataSet4.NotesWAAttach);

        }

        private void Menu_Load_1(object sender, EventArgs e)
        {

        }

        private void NewAttach_Click_2(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Open Attachment";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.CheckFileExists = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(openFileDialog.FileName))
                    {
                        byte[] fileContent = File.ReadAllBytes(openFileDialog.FileName);

                        string fileName = openFileDialog.SafeFileName;

                        Guid noteID = actualNoteID; // Use actualNoteID directly as a Guid

                        string contentType = MimeUtility.GetMimeMapping(fileName);

                        UploadAttachment(noteID, openFileDialog.SafeFileName, fileContent, contentType);
                    }
                    else
                    {
                        MessageBox.Show("The attachment file does not exist.");
                    }
                }
            }
        }

        private void AtcBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFileName = AtcName.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedFileName))
            {
                var documentViewer = new DocumentViewer(selectedFileName);

                documentViewer.Show();
            }
        }

        private void inputKey_Click(object sender, EventArgs e)
        {
            inputKey.SelectAll();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
            this.Opacity = 0.7;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
    }
}
