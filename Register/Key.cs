using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CachedProgramsList.Register
{
    class Key
    {
        private string key;
        public Key(string key)
        {
            this.key = key;
        }

        public List<Entry> getEntries()
        {
            List<Entry> entries = new List<Entry>();
            try
            {
                string[] keyValues = Registry.CurrentUser.OpenSubKey(key).GetValueNames();
                foreach(string keyValue in keyValues)
                {
                    Entry valueEntry = new Entry(keyValue);                   
                    entries.Add(valueEntry);                   
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return entries;
        }
    }
}
