
namespace DI.Src.Controls.DriveList
{
    public static class Helper
    {
        public static bool IsExistAddedDriveControls(int countDriveControls, int countDriveElements)
        {
            return countDriveControls < countDriveElements;
        }

        public static bool IsExistEmptyDriveControls(int countDriveControls, int countDriveElements)
        {
            return countDriveControls > countDriveElements;
        }
    }
}
