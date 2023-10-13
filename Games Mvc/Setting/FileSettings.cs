namespace Games_Mvc.Setting
{
    public class FileSettings
    {
        public const string ImagesPath = "/assets/images/games";
        public const string AllowedExtensions = ".jpeg,.jpg,.png";
        public const int MaxFileSizeMB = 1;
        public const int MaxFileSizeB = MaxFileSizeMB*1024*1024 ;
    }
}
