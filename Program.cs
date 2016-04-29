using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AutoAtForQQ
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string Current = Directory.GetCurrentDirectory();//获取当前根目录
            Settings.self.Ini = new IniHelper(Current + "/config.ini");
            Settings.self.load();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class Settings
    {
        public static Settings self = new Settings();

        private IniHelper ini;

        private string title = "无标题 - 记事本";
        private int prefix = 6;
        private string slist = "";
        private List<string> list = new List<string>(0);

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public int Prefix
        {
            get
            {
                return prefix;
            }

            set
            {
                prefix = value;
            }
        }

        public string Slist
        {
            get
            {
                return slist;
            }

            set
            {
                slist = value;
            }
        }

        public IniHelper Ini
        {
            get
            {
                return ini;
            }

            set
            {
                ini = value;
            }
        }

        public void parseList(string slist)
        {
            this.slist = slist;
            string[] arr = slist.Split('\n');
            List<string> list = new List<string>(arr.Length);
            foreach (string s in arr)
            {
                string ss = s.Trim();
                if(ss.Length > 0)
                {
                    list.Add(ss);
                }
            }
            this.list = list;
        }

        public List<List<string>> getItems(int count, bool random)
        {
            if(count == 0)
            {
                count = list.Count;
            }
            else if(count > list.Count)
            {
                count = list.Count;
            }

            if (count == 0)
            {
                return new List<List<string>>(0);
            }

            List<string> source = new List<string>(list);

            if (random)
            {
                source = GetRandomList(source);
            }

            List<List<string>> target = new List<List<string>>();
            List<string> temlist = null;
            for (int i = 0; i < count; i++)
            {
                if (i % 20 == 0)
                {
                    if(i != 0)
                    {
                        target.Add(temlist);
                    }
                    temlist = new List<string>(30);
                }

                temlist.Add(source[i].Substring(0, prefix));
            }
            target.Add(temlist);

            return target;
        }

        public List<T> RandomSortList<T>(List<T> ListT)
        {
            Random random = new Random();
            List<T> newList = new List<T>();
            foreach (T item in ListT)
            {
                newList.Insert(random.Next(newList.Count + 1), item);
            }
            return newList;
        }

        public static List<T> GetRandomList<T>(List<T> inputList)
        {
            //Copy to a array
            T[] copyArray = new T[inputList.Count];
            inputList.CopyTo(copyArray);

            //Add range
            List<T> copyList = new List<T>();
            copyList.AddRange(copyArray);

            //Set outputList and random
            List<T> outputList = new List<T>();
            Random rd = new Random(DateTime.Now.Millisecond);

            while (copyList.Count > 0)
            {
                //Select an index and item
                int rdIndex = rd.Next(0, copyList.Count - 1);
                T remove = copyList[rdIndex];

                //remove it from copyList and add it to output
                copyList.Remove(remove);
                outputList.Add(remove);
            }
            return outputList;
        }

        public void save()
        {
            ini.WriteValue("Main", "title", title);
            ini.WriteValue("Main", "prefix", prefix + "");

            string str = slist.Replace("\r\n", ",");
            int i = 0;
            while(str.Length > 254)
            {
                ini.WriteValue("Main", "list" + i++, str.Substring(0, 254));
                str = str.Substring(254);
            }
            ini.WriteValue("Main", "list" + i++, str);
        }

        public void load()
        {
            title = ini.ReadValue("Main", "title");
            if (title.Length == 0)
            {
                title = "无标题 - 记事本";
            }

            try {
                prefix = Int32.Parse(ini.ReadValue("Main", "prefix"));
            }
            catch (Exception)
            {
                prefix = 6;
            }

            int i = 0;
            string str = "";
            string s = ini.ReadValue("Main", "list" + i++);
            while (s.Length > 0)
            {
                str += s;
                s = ini.ReadValue("Main", "list" + i++);
            }

            slist = str.Replace(",", "\r\n");
        }
    }

    public class IniHelper
    {
        // 声明INI文件的写操作函数 WritePrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        // 声明INI文件的读操作函数 GetPrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal, int size, string filePath);

        private string sPath = null;
        public IniHelper(string path)
        {
            this.sPath = path;
        }

        public void WriteValue(string section, string key, string value)
        {
            // section=配置节，key=键名，value=键值，path=路径
            WritePrivateProfileString(section, key, value, sPath);
        }

        public string ReadValue(string section, string key)
        {
            // 每次从ini中读取多少字节
            System.Text.StringBuilder temp = new System.Text.StringBuilder(255);
            // section=配置节，key=键名，temp=上面，path=路径
            GetPrivateProfileString(section, key, "", temp, 255, sPath);
            return temp.ToString();
        }
    }
}
