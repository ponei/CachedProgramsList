using CachedProgramsList.Register;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CachedProgramsList.Data
{
    class Entries
    {

        private DataGridViewRow baseRow;
        private List<DataGridViewRow> entriesList = new List<DataGridViewRow>();

        public event EventHandler<int> EntryAmountUpdate;
        public event EventHandler<int> WorkEnded;
        public Entries(DataGridViewRow baseRow)
        {
            this.baseRow = baseRow;
        }

        protected virtual void OnEntryAmountUpdate()
        {
            EntryAmountUpdate?.Invoke(this, entryAmount);
        }

        protected virtual void OnWorkEnded()
        {
            WorkEnded?.Invoke(this, entryAmount);
        }

        private int entryAmount = 0;
        public List<DataGridViewRow> getEntries(bool search = true)
        {
            if (search)
            {
                entriesList.Clear();
                entryAmount = 0;
                getEntriesForKey(@"SOFTWARE\Classes\Local Settings\Software\Microsoft\Windows\Shell\MuiCache");
                getEntriesForKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store");
                getEntriesForKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers");
                getEntriesForKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Persisted");
                getEntriesForKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched");
            }

            OnWorkEnded();
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

        private void updateEntryAmountIfNecessary()
        {
            if (entryAmount % 100 == 0)
            {
                OnEntryAmountUpdate();
            }
        }

        private void getEntriesForKey(string keyToSearch)
        {

            Key key = new Key(keyToSearch);
            foreach (Entry value in key.getEntries())
            {
                updateEntryAmountIfNecessary();
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
                        entryAmount++;
                        entriesList.Add(newEntry);
                    }
                }
            }
        }

    }
}
