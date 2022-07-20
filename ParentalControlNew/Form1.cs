using ComponentFactory.Krypton.Toolkit;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void kryptonBtnBlock_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
        //блокировка программы (название вводим в строку поиска)
        bool task = true;
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePickerStart.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
                timer.Stop();

            try
            {
               
                    if (toolStripTextBoxSearch.Text != null)
                {
                    Task.Factory.StartNew(() =>
                    {
                        while (task)
                        {
                            var procceses = from proc in Process.GetProcesses()
                                            where proc.ProcessName == toolStripTextBoxSearch.Text
                                            select proc;
                            try
                            {
                                foreach (var p in procceses)
                                    KillProcess(p);
                            }
                            catch (Exception)
                            {
                            }
                            Thread.Sleep(100);
                        }
                    });

                }
                DateTime currentTime2 = DateTime.Now;
                DateTime userTime2 = dateTimePickerEnd.Value;
                if (currentTime2.Hour == userTime2.Hour && currentTime2.Minute == userTime2.Minute && currentTime2.Second == userTime2.Second)
                    task = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
      
       
    }
}
