using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace EntityMigrationDecode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtBase64String.Multiline = true;
            txtXmlOutput.Multiline = true;
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            string input = txtBase64String.Text;
            string output = Decode(input);
            txtXmlOutput.Text = output;

            if (!Directory.Exists(@"c:\temp"))
            {
                Directory.CreateDirectory(@"c:\temp");
            }
            File.WriteAllText(@"c:\temp\edmx.xml", output);
        }

        private string Decode(string base64string)
        {
            try {
                byte[] bytes = Convert.FromBase64String(base64string);
                byte[] uncompressed = Decompress(bytes);

                string edmx = Encoding.UTF8.GetString(uncompressed);
                return edmx;
            }
            catch(Exception e)
            {
                return string.Format("Exception: {0}", e.Message);
            }
        }
        private byte[] Decompress(byte[] gzip)
        {
            using (GZipStream stream = new GZipStream(new MemoryStream(gzip), CompressionMode.Decompress))
            {
                const int size = 4096;
                byte[] buffer = new byte[size];

                using (MemoryStream memory = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = stream.Read(buffer, 0, size);
                        if (count > 0)
                        {
                            memory.Write(buffer, 0, count);
                        }
                    }

                    while (count > 0);
                    return memory.ToArray();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBase64String.Text = string.Empty;
            txtXmlOutput.Text = string.Empty;
        }
    }
}
