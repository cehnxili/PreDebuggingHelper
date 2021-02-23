using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace 预调试助手
{
    class INI
    {

        public string path;

        public INI(string INIPath)
        {
            path = INIPath;
        }
        #region 其他
        [DllImport("kernel32",CharSet =CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);


        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string defVal, Byte[] retVal, int size, string filePath);
        #endregion

        //写INI文件
        /// <summary>
        /// 写INI文件
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }
        //读取INI文件
        /// <summary>
        /// 读取INI文件
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
            return temp.ToString();
        }
        public byte[] IniReadValues(string section, string key)
        {
            byte[] temp = new byte[255];
            int i = GetPrivateProfileString(section, key, "", temp, 255, this.path);
            return temp;
        }
        //删除Ini文件下所有段落
        /// <summary>
        /// 删除ini文件下所有段落
        /// </summary>
        public void ClearAllSection()
        {
            IniWriteValue(null, null, null);
        }
        //删除Ini文件下Personal段落下的所有键
        /// <summary>
        /// 删除Ini文件下Personal段落下的所有键
        /// </summary>
        /// <param name="Section"></param>
        public void ClearSection(string Section)
        {
            IniWriteValue(Section, null, null);
        }

    }
}
