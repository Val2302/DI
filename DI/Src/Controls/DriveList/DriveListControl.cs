using System.Windows.Forms;
using System.IO;
using DI.Src.Controls.Drive;
using System.Collections.Generic;

using static DI.Src.Controls.DriveList.Helper;

namespace DI.Src.Controls.DriveList
{
    public partial class DriveListControl : UserControl
    {
        #region Constants

        private const int CAPACITY_CONTROL_LIST = 15;
        private const int VERTICAL_SHIFT = 97;

        #endregion

        #region Properties

        private readonly List<DriveControl> _driveColtrolList;

        #endregion

        #region Construcrors

        public DriveListControl()
        {
            InitializeComponent();
            _driveColtrolList = new List<DriveControl>(CAPACITY_CONTROL_LIST);
        }

        #endregion

        #region Methods

        private void AddDriveControls(DriveInfo[] driveArray)
        {
            DriveControl driveControl;
            var begDriveIndex = _driveColtrolList.Count;
            var top = 0;

            for (int driveIndex = begDriveIndex; driveIndex < driveArray.Length; driveIndex++)
            {
                
                driveControl = new DriveControl(driveArray[driveIndex]);
                driveControl.Top = top;
                driveControl.Show();
                _driveColtrolList.Add(driveControl);
                Controls.Add(driveControl);
                top += VERTICAL_SHIFT;
            }
        }

        private void HideEmptyDriveControls(int begDriveIndex)
        {
            for (int driveIndex = begDriveIndex; driveIndex < _driveColtrolList.Count; driveIndex++)
            {
                _driveColtrolList[driveIndex].Hide();
            }
        }

        public void UpdateDriveList(DriveInfo[] driveArray)
        {
            int driveIndex;

            if (IsExistAddedDriveControls(_driveColtrolList.Count, driveArray.Length))
            {
                AddDriveControls(driveArray);
            }

            for (driveIndex = 0; _driveColtrolList.Count > driveIndex; driveIndex++)
            {
                _driveColtrolList[driveIndex].UpdateDriveInfo(driveArray[driveIndex]);
                _driveColtrolList[driveIndex].Show();
            }

            if(IsExistEmptyDriveControls(_driveColtrolList.Count, driveArray.Length))
            {
                HideEmptyDriveControls(driveIndex);
            }
        }

        #endregion
    }
}
