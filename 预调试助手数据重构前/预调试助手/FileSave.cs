using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ACS.SPiiPlusNET;

namespace 预调试助手
{
    class FileSave
    {

        public void SISave(string path,string value)
        {
            //保存
            try
            {
                using (StreamWriter sr=new StreamWriter(path))
                {
                    sr.WriteLine(value);
                }
            }
            catch (IOException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void SPISave(string path,ApplicationFileInfo  value)
        {
            //判断是否重名，重名的话增加（数字）
            string directory = Path.GetDirectoryName(path);
            string filename = Path.GetFileNameWithoutExtension(path);
            string extension = Path.GetExtension(path);
            int counter = 1;

            string newFullPath = path;

            while (System.IO.File.Exists(newFullPath))
            {
                string newFilename = filename + "(" + counter + ")" + extension;
                newFullPath = Path.Combine(directory, newFilename);
                counter++;
            }
            //保存
            try
            {
                using (StreamWriter sr = new StreamWriter(newFullPath))
                {
                    sr.WriteLine(value);
                }
            }
            catch (IOException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
