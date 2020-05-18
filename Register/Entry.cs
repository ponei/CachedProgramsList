using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CachedProgramsList.Register
{
    class Entry
    {
        private string path, name;
        private bool valid = false, exists = false;
        private DateTime creation, modification;
        public string Path { get => path; }
        public bool Valid { get => valid;  }
        public bool Exists { get => exists; }
        public DateTime Creation { get => creation; }
        public DateTime Modification { get => modification; }
        public string Name { get => name; }

        public Entry(string path)
        {
            this.path = path;
            checkIfValid();
            if (valid)
            {
                checkIfExists();
                if (exists)
                {
                    creation = File.GetCreationTime(this.path);
                    modification = File.GetLastWriteTime(this.path);
                }
            }
        }

        //https://www.oreilly.com/library/view/regular-expressions-cookbook/9781449327453/ch08s18.html
        string validPathRegex = @"[a-zA-Z]:\\(?:[^\\\/:*?" + "\"" + @"<>|\r\n]+\\)*([^\\\/:*?" + "\"" + @"<>|\r\n]*)";

        private void checkIfValid()
        {
            if (path.EndsWith(".ApplicationCompany") || path.EndsWith(".FriendlyAppName"))
            {
                path = path.Replace(".FriendlyAppName", "").Replace(".ApplicationCompany", "");
            }

            Regex rg = new Regex(validPathRegex);
            MatchCollection pathValid = rg.Matches(path);
            if (pathValid.Count > 0)
            {
                valid = true;
                name = pathValid[0].Groups[1].Value;
            }
        }

        private void checkIfExists()
        {
            if (File.Exists(path))
            {
                exists = true;
            }
        }


    }
}
