using System;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;


namespace LoggerMonitor
{
    class TextFile : System.IO.TextReader
    {
        private const string workDir = @"C:\ProgramData\MolinProducts\";
        string path = "";
        public string line = "";
        TextReader textReadHandle = null;

        public TextFile()
        {
            if(!Directory.Exists(workDir))
			{
                Directory.CreateDirectory(workDir);
            }
        }

        public void Open(string Path)
        {
            path = Path;
            try
            {
                textReadHandle = File.OpenText(workDir + path);
            }
            catch(FileNotFoundException)
            {
                throw;
            }
        }

        public void OpenOrCreate(string Path)
        {
            path = Path;
            textReadHandle = File.OpenText(workDir + path);
        }

        public int ReadOneLine()
        {
            line = textReadHandle.ReadLine();
            int len = 0;
            if (line != null)
                len = line.Length;
            return len;
        }

        public override void Close()
        {
            if (textReadHandle != null)
            {
                textReadHandle.Close();
                textReadHandle = null;
            }
        }

        // Text file for write purposes

        public string wLine = "";

        FileStream textWriteHandle = null;

        public void OpenW(string Path)
        {
            path = Path;
            try
            {
                textWriteHandle = File.OpenWrite(workDir + path);
            }
            catch (FileNotFoundException) { }
            finally
            {
                textWriteHandle.SetLength(0);
            }
        }

        public void WriteOneLine()
        {
            try
            {
                var len = wLine.Length;
                byte[] bLine = new byte[len+2];
                for (int i = 0; i < len; i++)
                    bLine[i] = System.Convert.ToByte(wLine[i]);
                bLine[len] = (byte)'\n';
                textWriteHandle.Write(bLine, 0, len + 1);
            }
            catch (Exception ex)
            {
                string msg = "Error in wiriting to a text file:" + path + ". Original error: " + ex.Message;
                MessageBox.Show(msg);
            }
        }

        public void CloseW()
        {
            if (textWriteHandle != null)
            {
                textWriteHandle.Flush();
                textWriteHandle.Close();
                textWriteHandle = null;
            }
        }

    }
}
