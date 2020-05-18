using CachedProgramsList.Data;
using CachedProgramsList.Properties;
using CachedProgramsList.Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CachedProgramsList
{
    public partial class FormMain : Form
    {
        private Entries dataEntries;
        public FormMain()
        {
            InitializeComponent();
            DoubleBufferedControl(datagEntries, true);
            dataEntries = new Entries((DataGridViewRow)datagEntries.Rows[0].Clone());
            comboFilterOptions.SelectedIndex = 0;
        }

        private void DoubleBufferedControl(DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        #region logging and filtering
        private async void btCancelFilter_Click(object sender, EventArgs e)
        {
            btCancelFilter.Enabled = false;
            btLog.Enabled = true;
            datagEntries.Rows.Clear();
            List<DataGridViewRow> entries = await Task.Run(() =>
            {
                return dataEntries.getEntries(false);
            });
            await addRows(entries);
        }

        private async void btLog_Click(object sender, EventArgs e)
        {
            btLog.Enabled = false;
            picWorking.Visible = true;
            datagEntries.Rows.Clear();
            List<DataGridViewRow> entries = await Task.Run(() =>
            {
                return dataEntries.getEntries();
            });

            await addRows(entries);

            btLog.Enabled = true;
            picWorking.Visible = false;
        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btFilter.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private async void btFilter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFilter.Text))
            {
                btCancelFilter.Enabled = true;
                btLog.Enabled = false;
                datagEntries.Rows.Clear();
                List<DataGridViewRow> entries = await Task.Run(() =>
                {
                    return dataEntries.filterEntries(txtFilter.Text, comboFilterOptions.Text);
                });
                await addRows(entries);
            }
        }

        private async Task addRows(List<DataGridViewRow> rows)
        {
            foreach (DataGridViewRow row in rows)
            {
                await Task.Run(() =>
                {
                    Invoke((MethodInvoker)delegate
                    {
                        datagEntries.Rows.Add(row);
                    });
                });
            }
        }
        #endregion

        #region menu strip
        #region native
        //https://stackoverflow.com/questions/1936682/how-do-i-display-a-files-properties-dialog-from-c
        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        static extern bool ShellExecuteEx(ref SHELLEXECUTEINFO lpExecInfo);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHELLEXECUTEINFO
        {
            public int cbSize;
            public uint fMask;
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpVerb;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpFile;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpParameters;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpDirectory;
            public int nShow;
            public IntPtr hInstApp;
            public IntPtr lpIDList;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpClass;
            public IntPtr hkeyClass;
            public uint dwHotKey;
            public IntPtr hIcon;
            public IntPtr hProcess;
        }

        private const int SW_SHOW = 5;
        private const uint SEE_MASK_INVOKEIDLIST = 12;
        public static bool ShowFileProperties(string Filename)
        {
            SHELLEXECUTEINFO info = new SHELLEXECUTEINFO();
            info.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(info);
            info.lpVerb = "properties";
            info.lpFile = Filename;
            info.nShow = SW_SHOW;
            info.fMask = SEE_MASK_INVOKEIDLIST;
            return ShellExecuteEx(ref info);
        }
        #endregion

        private string clickFolder, clickExec;
        private void datagEntries_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1 && e.Button == MouseButtons.Right)
            {
                DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                if (!c.Selected && c.Value != null)
                {
                    DataGridViewCell cExists = (sender as DataGridView)[1, e.RowIndex];
                    bool flag = (bool)cExists.Value;
                    openFileToolStripMenuItem.Enabled = flag;
                    moreInfoToolStripMenuItem.Enabled = flag;

                    clickExec = (string)c.Value;
                    int index = clickExec.LastIndexOf(@"\");
                    clickFolder = clickExec.Substring(0, index);

                    c.DataGridView.ClearSelection();
                    c.DataGridView.CurrentCell = c;
                    c.Selected = true;
                    var relativeMousePosition = datagEntries.PointToClient(Cursor.Position);
                    csmPath.Show(datagEntries, relativeMousePosition);
                }
            }
        }

        private void openPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(clickFolder))
            {
                Process.Start(clickFolder);
            }
            else
            {
                MessageBox.Show("Directory doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(clickExec);
        }

        private void moreInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFileProperties(clickExec);
        }
        #endregion

        #region theming
        private string theme = "dark";
        private void btTheme_Click(object sender, EventArgs e)
        {
            if (theme == "dark")
            {
                btTheme.BackgroundImage = Resources.dark;
                lightTheme();
                theme = "light";
            }
            else
            {
                btTheme.BackgroundImage = Resources.light;
                darkTheme();
                theme = "dark";
            }
        }

        private void lightTheme()
        {
            BackColor = Color.FromArgb(235, 235, 235);

            datagEntries.BackgroundColor = Color.FromArgb(230, 230, 230);
            datagEntries.GridColor = Color.FromArgb(150, 150, 150);

            datagEntries.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(225, 225, 225);
            datagEntries.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(15, 15, 15);

            datagEntries.DefaultCellStyle.BackColor = Color.FromArgb(215, 215, 215);
            datagEntries.DefaultCellStyle.ForeColor = Color.FromArgb(15, 15, 15);

            datagEntries.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(208, 208, 208);
            datagEntries.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(15, 15, 15);
        }



        private void darkTheme()
        {
            BackColor = Color.FromArgb(20, 20, 20);

            datagEntries.BackgroundColor = Color.FromArgb(25, 25, 25);
            datagEntries.GridColor = Color.FromArgb(105, 105, 105);

            datagEntries.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            datagEntries.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(240, 240, 240);

            datagEntries.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            datagEntries.DefaultCellStyle.ForeColor = Color.FromArgb(240, 240, 240);

            datagEntries.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(47, 47, 47);
            datagEntries.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(240, 240, 240);

        }
        #endregion
    }
}
