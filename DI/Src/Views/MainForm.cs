using System;
using System.IO;
using System.Windows.Forms;

namespace DI.Src.Views
{
    public partial class MainForm : Form
    {
        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region EventHandlers

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            driveListControl.UpdateDriveList(DriveInfo.GetDrives());
        }

        #endregion
    }
}