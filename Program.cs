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
            Settings.self.init(Current + "/config.ini");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class Settings
    {
        public static Settings self = new Settings();

        public IniHelper ini;
        public string iniFilePath;

        public int prefix = 6;
        public int count = 20;
        public bool random = false;
        public bool shuffle = false;
        public bool autoSend = false;

        public List<Profile> profiles = new List<Profile>();

        public Profile currentProfile;

        public void init(string iniFilePath)
        {
            this.iniFilePath = iniFilePath;
            this.ini = new IniHelper(iniFilePath);

            Settings.self.load();
        }

        public Profile selectProfile(int index)
        {
            currentProfile = profiles[index];
            return currentProfile;
        }

        public Profile addProfile()
        {
            Profile profile = new Profile(profiles.Count + "-" + new Random().Next(100, 999));
            profiles.Add(profile);
            return selectProfile(profiles.Count - 1);
        }

        public Profile removeProfile()
        {
            profiles.Remove(currentProfile);
            if (profiles.Count == 0)
            {
                return addProfile();
            }
            return selectProfile(0);
        }

        public void load()
        {
            try
            {
                prefix = Int32.Parse(ini.ReadValue("Main", "prefix"));
            }
            catch (Exception)
            {
                prefix = 6;
            }

            try
            {
                count = Int32.Parse(ini.ReadValue("Main", "count"));
            }
            catch (Exception)
            {
                count = 20;
            }

            try
            {
                random = Boolean.Parse(ini.ReadValue("Main", "random"));
            }
            catch (Exception)
            {
                random = false;
            }

            try
            {
                autoSend = Boolean.Parse(ini.ReadValue("Main", "autoSend"));
            }
            catch (Exception)
            {
                autoSend = false;
            }

            try
            {
                shuffle = Boolean.Parse(ini.ReadValue("Main", "shuffle"));
            }
            catch (Exception)
            {
                shuffle = false;
            }

            string profiles_str = ini.ReadValue("Main", "profiles");
            string[] profileNames = profiles_str.Split(',');
            foreach (string profileName in profileNames)
            {
                if (profileName.Trim().Length == 0)
                {
                    continue;
                }

                Profile profile = new Profile(profileName);
                profile.load(ini);
                profiles.Add(profile);
            }

            if (profiles.Count == 0)
            {
                addProfile();
            }
            else
            {
                selectProfile(0);
            }

        }

        public void save()
        {
            File.Delete(iniFilePath);

            ini.WriteValue("Main", "prefix", prefix + "");
            ini.WriteValue("Main", "random", random + "");
            ini.WriteValue("Main", "count", count + "");
            ini.WriteValue("Main", "autoSend", autoSend + "");
            ini.WriteValue("Main", "shuffle", shuffle + "");

            string profiles_str = "";

            foreach (Profile profile in profiles)
            {
                profiles_str += profile.name + ",";
                profile.save(ini);
            }

            profiles_str = profiles_str.Remove(profiles_str.Length - 1);
            ini.WriteValue("Main", "profiles", profiles_str);
        }
    }

    public class Profile
    {
        public string name = "";
        public string title = "无标题 - 记事本";
        public string slist = "";
        List<string> list = new List<string>();

        public Profile(string name)
        {
            this.name = name;
        }

        public string getDisplayName()
        {
            return "(" + list.Count + ")" + title;
        }

        public void load(IniHelper ini)
        {
            this.title = ini.ReadValue(name, "title");

            int i = 0;
            string str = "";
            string s = ini.ReadValue(name, "list" + i++);
            while (s.Length > 0)
            {
                str += s;
                s = ini.ReadValue(name, "list" + i++);
            }

            slist = str.Replace(",", "\r\n");

            parseList();
        }

        public void save(IniHelper ini)
        {
            ini.WriteValue(name, "title", title);

            string str = slist.Replace("\r\n", ",");
            int i = 0;
            while (str.Length > 254)
            {
                ini.WriteValue(name, "list" + i++, str.Substring(0, 254));
                str = str.Substring(254);
            }
            ini.WriteValue(name, "list" + i++, str);
        }

        public void parseList()
        {
            string[] arr = slist.Split('\n');
            List<string> list = new List<string>(arr.Length);
            foreach (string s in arr)
            {
                string ss = s.Trim();
                if (ss.Length > 0)
                {
                    list.Add(ss);
                }
            }
            this.list = list;
        }

        public List<List<string>> getItems(int count, bool random, bool shuffle)
        {
            if (count == 0)
            {
                count = list.Count;
            }
            else if (count > list.Count)
            {
                count = list.Count;
            }

            if (count == 0)
            {
                return new List<List<string>>(0);
            }

            List<string> source = new List<string>();
            if (Settings.self.random)
            {
                Random r = new Random();
                for (int i = 0; i < count; i++)
                {
                    source.Add(list[r.Next(list.Count)]);
                }

            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    source.Add(list[i]);
                }
            }

            if (Settings.self.shuffle)
            {
                source = GetRandomList(source);
            }

            List<List<string>> target = new List<List<string>>();
            List<string> temlist = null;
            for (int i = 0; i < count; i++)
            {
                if (i % 20 == 0)
                {
                    if (i != 0)
                    {
                        target.Add(temlist);
                    }
                    temlist = new List<string>();
                }

                temlist.Add(source[i].Substring(0, Settings.self.prefix));
            }
            target.Add(temlist);

            return target;
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
