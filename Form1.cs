using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_Computer_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoggedinTB.Text = Environment.UserName;
            ComputerNameTB.Text = Environment.MachineName;

            #region Serial Number
            ManagementObjectSearcher SerialNumber = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            foreach (ManagementObject  wmi in SerialNumber.Get())
            {
                try
                {
                    ComputerSerialTB.Text = wmi.GetPropertyValue("SerialNumber").ToString();
                }
                catch
                {
                    ComputerSerialTB.Text = "Could not retrieve SN";
                }
            }
            #endregion

            #region Model
            ManagementObjectSearcher ComputerModel = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            foreach (ManagementObject wmi in ComputerModel.Get())
            {
                try
                {
                    ComputerModelTB.Text = wmi.GetPropertyValue("Model").ToString();
                }
                catch
                {
                    ComputerModelTB.Text = "Count not retrieve Model";
                }
            }
            #endregion

            #region Reboot Time
            string RebootDays = TimeSpan.FromMilliseconds(Environment.TickCount).Days.ToString();
            string RebootHours = TimeSpan.FromMilliseconds(Environment.TickCount).Hours.ToString();
            string RebootMinutes = TimeSpan.FromMilliseconds(Environment.TickCount).Minutes.ToString();


            TimeRebootTB.Text = RebootDays.ToString() + " days " + RebootHours.ToString() + " Hours " + RebootMinutes.ToString() + " Minutes";
            #endregion


        }
    }
}
