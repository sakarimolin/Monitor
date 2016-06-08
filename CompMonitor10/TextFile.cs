using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace CompMonitor10
{
    class TextFile : System.IO.TextReader
    {
        string path = "";
        public string line = "";
        TextReader textReadHandle = null;

        public TextFile()
        {
        }

        public void Open( string Path ){
            path = Path;
            textReadHandle = File.OpenText(path);
        }

        public int ReadOneLine()
        {
            line = textReadHandle.ReadLine();
            int len = 0;
            if (line != null)
                len = line.Length;
            return  len;
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

        string wPath = "";
        public string wLine = "";

        FileStream textWriteHandle = null;

        
        public void OpenW(string Path)
        {
            path = Path;
            textWriteHandle = File.OpenWrite(path);
            textWriteHandle.SetLength(0);
        }

        public void WriteOneLine()
        {
            try
            {
                byte[] bLine = new byte[wLine.Length];
                for ( int i = 0; i < wLine.Length; i++ )
                    bLine[i] = System.Convert.ToByte( wLine[i]);
                textWriteHandle.Write( bLine, 0, wLine.Length );
            }
            catch (Exception ex)
            {
                string msg = "Error in wiriting to a text file:" + wPath + ". Original error: " + ex.Message;
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
