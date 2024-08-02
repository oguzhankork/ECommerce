namespace ECommerce.Common.ImageHelpers
{
    public static class ImageHelper
    {
        public static string Upload(string imageName)
        {

            //png, jpg, jpeg, gif, bmp


            string newImageName = "";

            string uniqueName = Guid.NewGuid().ToString();


            var fileArray=imageName.Split('.');

            var extension = fileArray[fileArray.Length - 1]; //görselin uzantısını teslim eder.

            if (extension == "png" || extension == "jpg" || extension == "bmp" || extension == "gif" || extension == "jpeg")
            {
                newImageName = uniqueName + "." + extension;
                return newImageName;
            }
            else
            {
                return "0";
            }

            
        }
    }
}
