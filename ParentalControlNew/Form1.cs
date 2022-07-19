using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using Microsoft.VisualBasic;
using ComponentFactory.Krypton.Toolkit;

namespace ParentalControlNew
{
    public partial class Form1 : KryptonForm
    {
        private List<Process> processes = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void GetProcesses()
        {
            processes.Clear();
            processes = Process.GetProcesses().ToList();
        }
        private void RefreshProcesList()
        {
            listView.Items.Clear();
            foreach (Process p in processes)
            {
                try
                {
                    if (p != null)
                    {

                        string[] row = new string[] { p.ProcessName.ToString() };
                        listView.Items.Add(new ListViewItem(row));

                    }
                }
                catch (Exception)
                {

                }
                Text = "Processes are running: " + processes.Count.ToString();
            }
        }
        private void RefreshProcesList(List<Process> processes, string keyword)
        {
            listView.Items.Clear();
            foreach (Process p in processes)
            {
                try
                {
                    if (p != null)
                    {

                        string[] row = new string[] { p.ProcessName.ToString() };
                        listView.Items.Add(new ListViewItem(row));

                    }
                }
                catch (Exception)
                {

                }
                Text = $"Processes are running:{ keyword}" + processes.Count.ToString();
            }
        }
        private void KillProcess(Process process)
        {
            process.Kill();

        }

        //закрыть дерево процессов
        private void KillProcAndChild(int pid)
        {
            if (pid == 0)
            {
                return;
            }
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                "Select * From Win32_Process Where ParentProcessId=" + pid);
            ManagementObjectCollection objectsCollections = searcher.Get();
            foreach (ManagementObject obj in objectsCollections)
            {
                KillProcAndChild(Convert.ToInt32(obj["ProcessID"]));
            }
            try
            {
                Process p = Process.GetProcessById(pid);
                p.Kill();


            }
            catch (ArgumentException) { }

        }

        //получить ID родительского процесса
        private int GetParentProcessId(Process p)
        {
            int parentId = 0;
            try
            {
                ManagementObject managementObject = new ManagementObject("win32_process.handle='" + p.Id + "'");
                managementObject.Get();
                parentId = Convert.ToInt32(managementObject["ParentProcessId"]);
            }
            catch (Exception) { }
            return parentId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processes = new List<Process>();
            GetProcesses();
            RefreshProcesList();
        }

        private void toolStripButRefresh_Click(object sender, EventArgs e)
        {
            GetProcesses();
            RefreshProcesList();
        }

        private void toolStripButComplete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems[0] != null)
                {
                    Process procToKill = processes.Where((x) => x.ProcessName == listView.SelectedItems[0].SubItems[0].Text).ToList()[0];
                    KillProcess(procToKill);
                    GetProcesses();
                    RefreshProcesList();
                }
            }
            catch (Exception)
            {

            }
        }

        private void toolStripButComTree_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems[0] != null)
                {
                    Process procToKill = processes.Where((x) => x.ProcessName == listView.SelectedItems[0].SubItems[0].Text).ToList()[0];
                    KillProcAndChild(GetParentProcessId(procToKill));
                    GetProcesses();
                    RefreshProcesList();
                }
            }
            catch (Exception)
            {

            }
        }

        private void completeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems[0] != null)
                {
                    Process procToKill = processes.Where((x) => x.ProcessName == listView.SelectedItems[0].SubItems[0].Text).ToList()[0];
                    KillProcess(procToKill);
                    GetProcesses();
                    RefreshProcesList();
                }
            }
            catch (Exception)
            {

            }
        }

        private void completeProcessTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems[0] != null)
                {
                    Process procToKill = processes.Where((x) => x.ProcessName == listView.SelectedItems[0].SubItems[0].Text).ToList()[0];
                    KillProcAndChild(GetParentProcessId(procToKill));
                    GetProcesses();
                    RefreshProcesList();
                }
            }
            catch (Exception)
            {

            }
        }

        private void toolStripMenuItemRun_Click(object sender, EventArgs e)
        {
            TopMost = false;
            string paht = Interaction.InputBox("Enter the program name", "Run new task");
            try
            {
                Process.Start(paht); //просто имя программы
            }
            catch (Exception)
            {

            }
        }

        private void exitToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            GetProcesses();
            List<Process> filterproc = processes.Where((x) => x.ProcessName.ToLower().Contains(toolStripTextBoxSearch.Text.ToLower())).ToList();
            RefreshProcesList(filterproc, toolStripTextBoxSearch.Text);
        }

      
    }
}
