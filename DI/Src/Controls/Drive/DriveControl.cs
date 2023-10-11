
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace DI.Src.Controls.Drive
{
    public partial class DriveControl : UserControl
    {
        #region FIELDS

        private const int SCALE_FACTOR = 1000;

        private DriveInfo DriveInfo { get; set; }

        #endregion

        #region Contstructors

        public DriveControl()
        {
            InitializeComponent();
        }

        public DriveControl(DriveInfo driveInfo):this()
        {
            DriveInfo = driveInfo;
            UpdateDriveInfo(driveInfo);
        }

        #endregion

        #region Methods

        private Bitmap SelectImageSource(DriveType driveType)
        {
            switch (driveType)
            {
                case DriveType.NoRootDirectory:
                    return Properties.Resources.NoRootDirectory;
                case DriveType.Removable:
                    return Properties.Resources.FlashDrive;
                case DriveType.Fixed:
                    return Properties.Resources.HardDrive;
                case DriveType.Network:
                    return Properties.Resources.NetworkDrive;
                case DriveType.CDRom:
                    return Properties.Resources.СDRom;
                case DriveType.Ram:
                    return Properties.Resources.RamDrive;
                default:
                    return Properties.Resources.UnknownDrive;
            }
        }

        private void UpdateSizeBar(DriveInfo driveInfo)
        {
            if (driveInfo.IsReady)
            {
                var occupiedSpace = driveInfo.TotalSize - driveInfo.AvailableFreeSpace;
                sizeBar.Maximum = (int)(driveInfo.TotalSize / SCALE_FACTOR);
                sizeBar.Value = (int)(occupiedSpace / SCALE_FACTOR);
                sizeBar.Enabled = true;
            }
            else
            {
                sizeBar.Maximum = sizeBar.Value = 0;
                sizeBar.Enabled = false;
            }
        }

        public void UpdateDriveInfo(DriveInfo driveInfo)
        {
            DriveInfo = driveInfo;

            if (driveInfo.IsReady)
            {
                lblDriveName.Text = driveInfo.Name;

                lblAvaliableValue.Text = driveInfo.AvailableFreeSpace.ToString("N0");
                lblFreeValue.Text = driveInfo.TotalFreeSpace.ToString("N0");
                lblTotalValue.Text = driveInfo.TotalSize.ToString("N0");

                lblLabelValue.Text = driveInfo.VolumeLabel;
                lblDirectoryValue.Text = driveInfo.RootDirectory.FullName;
                lblFormatValue.Text = driveInfo.DriveFormat;

            }
            else
            {
                lblDriveName.Text = driveInfo.Name;

                lblAvaliableValue.Text = string.Empty;
                lblFreeValue.Text = string.Empty;
                lblTotalValue.Text = string.Empty;

                lblLabelValue.Text = string.Empty;
                lblDirectoryValue.Text = driveInfo.RootDirectory.FullName;
                lblFormatValue.Text = string.Empty;
            }

            driveTypePicture.Image = SelectImageSource(DriveInfo.DriveType);
            UpdateSizeBar(driveInfo);
        }

        #endregion

        #region EventHandlers

        private void DriveTypePicture_Click(object sender, System.EventArgs e)
        {
            if (DriveInfo.IsReady)
            {
                var drivePath = lblDirectoryValue.Text;
                System.Diagnostics.Process.Start("explorer", drivePath);
            }
        }

        #endregion
    }
}
