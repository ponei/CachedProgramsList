using CachedProgramsList.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CachedProgramsList.Data
{
    class Entries
    {
        private DataGridViewRow baseRow;
        private List<DataGridViewRow> entriesList = new List<DataGridViewRow>();
        public Entries(DataGridViewRow baseRow)
        {
            this.baseRow = baseRow;
        }

        public List<DataGridViewRow> getEntries(bool search = true)
        {
            if (search)
            {
                entriesList.Clear();
                getEntriesForKey(@"SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache");
                getEntriesForKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store");
                getEntriesForKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers");
                getEntriesForKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Persisted");
            }

            return entriesList;
        }

        public List<DataGridViewRow> filterEntries(string filter, string field)
        {
            List<DataGridViewRow> filteredEntriesList = new List<DataGridViewRow>();


            switch (field)
            {
                case "Name":
                    foreach (DataGridViewRow row in entriesList)
                    {
                        if (row.Cells[0].Value.ToString().ToUpper().Contains(filter.ToUpper()))
                        {
                            filteredEntriesList.Add(row);
                        }
                    }
                    break;

                case "Creation Date":
                    foreach (DataGridViewRow row in entriesList)
                    {
                        if (row.Cells[2].Value != null)
                        {
                            DateTime dateValue = (DateTime)row.Cells[2].Value;
                            if (dateValue.ToString("MM/dd/yyyy HH:mm:ss").Contains(filter))
                            {
                                filteredEntriesList.Add(row);
                            }
                        }
                    }
                    break;

                case "Modification Date":
                    foreach (DataGridViewRow row in entriesList)
                    {
                        if (row.Cells[3].Value != null)
                        {
                            DateTime dateValue = (DateTime)row.Cells[3].Value;
                            if (dateValue.ToString("MM/dd/yyyy HH:mm:ss").Contains(filter))
                            {
                                filteredEntriesList.Add(row);
                            }
                        }
                    }
                    break;

                case "Path":
                    foreach (DataGridViewRow row in entriesList)
                    {
                        if (row.Cells[4].Value.ToString().ToUpper().Contains(filter.ToUpper()))
                        {
                            filteredEntriesList.Add(row);
                        }
                    }
                    break;
            }


            return filteredEntriesList;
        }

        private void getEntriesForKey(string keyToSearch)
        {
            Key key = new Key(keyToSearch);
            foreach (Entry value in key.getEntries())
            {
                if (value.Valid)
                {
                    bool alreadyExists = false;
                    foreach (DataGridViewRow row in entriesList)
                    {
                        if (row.Cells[4].Value != null)
                        {
                            string existingPath = row.Cells[4].Value.ToString();
                            if (value.Path == existingPath)
                            {
                                alreadyExists = true;
                                break;
                            }
                        }
                    }

                    if (!alreadyExists)
                    {
                        DataGridViewRow newEntry = (DataGridViewRow)baseRow.Clone();
                        newEntry.Cells[0].Value = value.Name;
                        newEntry.Cells[1].Value = value.Exists;
                        newEntry.Cells[2].Value = value.Exists == true ? value.Creation : (DateTime?)null;
                        newEntry.Cells[3].Value = value.Exists == true ? value.Modification : (DateTime?)null;
                        newEntry.Cells[4].Value = value.Path;
                        entriesList.Add(newEntry);
                    }
                }
            }
        }

    }
}
