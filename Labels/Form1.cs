using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using Velopack;
using Velopack.Sources;

namespace Labels
{
    public partial class Form1 : Form
    {
        List<string> serials = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (chkNoSerial.Checked)
            {
                serials.Clear();
                listSerials.Items.Clear();

                for (int i = 0; i < numQty.Value; i++)
                {
                    serials.Add("N/A");
                    listSerials.Items.Add("N/A");
                }
            }
        }

        private void txtSerials_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtSerials.Text))
            {
                if (chkNoSerial.Checked)
                {
                    serials.Clear();
                    listSerials.Items.Clear();
                    for (int i = 0; i < numQty.Value; i++)
                    {
                        serials.Add("N/A");
                        listSerials.Items.Add("N/A");
                    }
                    txtSerials.Clear();
                    return;
                }

                var separators = new[] { ',', '\n', '\r', ' ' };
                string[] inputSerials = txtSerials.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                foreach (string rawSerial in inputSerials)
                {
                    if (serials.Count >= numQty.Value)
                    {
                        MessageBox.Show("All serials scanned.");
                        break;
                    }

                    string serial = rawSerial.Trim();
                    if (!string.IsNullOrWhiteSpace(serial) && !serials.Contains(serial))
                    {
                        serials.Add(serial);
                        listSerials.Items.Add(serial);
                    }
                }

                txtSerials.Clear();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (serials.Count != numQty.Value)
            {
                MessageBox.Show("Not all serials scanned.");
                return;
            }

            GeneratePdfLabels(
                serials,
                productName.Text,
                orderNumber.Text,
                cwNum.Text,
                addInfo.Text
            );
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listSerials.SelectedItem == null)
            {
                MessageBox.Show("Please select a serial to remove.");
                return;
            }

            string selectedSerial = listSerials.SelectedItem.ToString();
            listSerials.Items.Remove(selectedSerial);
            serials.Remove(selectedSerial);
        }

        private void GeneratePdfLabels(List<string> serials, string productName, string orderNumber, string cwNum, string addInfo)
        {
            int labelsPerRow = 2;
            int labelsPerColumn = 5;
            int labelsPerPage = labelsPerRow * labelsPerColumn;

            double pageWidth = XUnit.FromInch(8.5);
            double pageHeight = XUnit.FromInch(11);
            double labelWidth = pageWidth / labelsPerRow;
            double labelHeight = pageHeight / labelsPerColumn;

            PdfDocument document = new PdfDocument();
            PdfPage page = null;
            XGraphics gfx = null;

            for (int i = 0; i < serials.Count; i++)
            {
                if (i % labelsPerPage == 0)
                {
                    page = document.AddPage();
                    page.Width = pageWidth;
                    page.Height = pageHeight;
                    gfx = XGraphics.FromPdfPage(page);
                }

                int labelIndexOnPage = i % labelsPerPage;
                int row = labelIndexOnPage / labelsPerRow;
                int col = labelIndexOnPage % labelsPerRow;

                double x = col * labelWidth;
                double y = row * labelHeight;

                var rect = new XRect(x + 10, y + 10, labelWidth - 20, labelHeight - 20);
                gfx.DrawRectangle(XPens.Black, rect);

                double lineHeight = 16;
                double textX = x + 20;
                double textY = y + 30;

                gfx.DrawString($"CW PO#: {orderNumber}", new XFont("Arial", 14), XBrushes.Black, new XPoint(textX, textY));
                textY += lineHeight;
                gfx.DrawString($"Product: {productName}", new XFont("Arial", 14), XBrushes.Black, new XPoint(textX, textY));
                if (addInfo.Length > 0)
                { textY += lineHeight; }
                gfx.DrawString($"{addInfo}", new XFont("Arial", 14), XBrushes.Black, new XPoint(textX, textY));
                textY += lineHeight;
                gfx.DrawString($"Serial #: {serials[i]}", new XFont("Arial", 14), XBrushes.Black, new XPoint(textX, textY));
                textY += lineHeight;
                gfx.DrawString($"CW #: {cwNum}", new XFont("Arial", 14), XBrushes.Black, new XPoint(textX, textY));
                textY += lineHeight;
                textY += lineHeight;
                gfx.DrawString("Retail: $_________", new XFont("Arial", 14), XBrushes.Black, new XPoint(textX, textY));
                textY += lineHeight;
                gfx.DrawString("Client/ Employee: _________________", new XFont("Arial", 14), XBrushes.Black, new XPoint(textX, textY));
            }

            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ProductLabels.pdf");
            document.Save(filename);
            Process.Start("explorer", filename);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtSerials.Enabled = !chkNoSerial.Checked;

            if (chkNoSerial.Checked)
            {
                txtSerials.Clear();
            }
            txtSerials.Enabled = !chkNoSerial.Checked;
            txtSerials.Clear();

            serials.Clear();
            listSerials.Items.Clear();

            if (chkNoSerial.Checked)
            {
                for (int i = 0; i < numQty.Value; i++)
                {
                    serials.Add("N/A");
                    listSerials.Items.Add("N/A");
                }
            }
            txtSerials.Enabled = !chkNoSerial.Checked;
            txtSerials.Clear();

            serials.Clear();
            listSerials.Items.Clear();

            if (chkNoSerial.Checked)
            {
                for (int i = 0; i < numQty.Value; i++)
                {
                    serials.Add("N/A");
                    listSerials.Items.Add("N/A");
                }
            }
        }

        private void addInfo_TextChanged(object sender, EventArgs e)
        {

        }
        private static async Task UpdateMyApp()
        {
            var accessToken = "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";
            var mgr = new UpdateManager(new GithubSource("https://github.com/TCKaen/Labels", accessToken, false, null));

            // check for new version
            var newVersion = await mgr.CheckForUpdatesAsync();
            if (newVersion == null)
                return; // no update available

            // download new version
            await mgr.DownloadUpdatesAsync(newVersion);

            // install new version and restart app
            mgr.ApplyUpdatesAndRestart(newVersion);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
//Test commit for new build