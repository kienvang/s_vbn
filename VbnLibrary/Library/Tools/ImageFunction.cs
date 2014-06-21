using System;
using System.IO;
using System.Drawing;
using System.Web;
using System.Configuration;
using System.Globalization;
using System.Threading;

namespace Library.Tools
{
    /// <summary>
    /// Summary description for ImageFunction.
    /// </summary>
    public class ImageFunction
    {
        public static string returnWidthImageRessume
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["WidthImageTravelGuide"].ToString();
            }
        }
        public static string returnHeightImageRessume
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["HeightImageTravelGuide"].ToString();
            }
        }

        public static System.Drawing.Image ScaleImage(System.Drawing.Image imgPhoto, int maxExpectedWidth, int maxExpectedHeight)
        {
            return ScaleImage(imgPhoto, maxExpectedWidth, maxExpectedHeight, true);
        }

        public static System.Drawing.Image ScaleImage(System.Drawing.Image imgPhoto, int maxExpectedWidth, int maxExpectedHeight, bool KeepRatio)
        {
            int[] realThumbDimensions = GetProportionalThumbnailSize(imgPhoto.Width, imgPhoto.Height, maxExpectedWidth, maxExpectedHeight);

            if (imgPhoto.Width < maxExpectedWidth && imgPhoto.Height < maxExpectedHeight) return imgPhoto;

            System.Drawing.Bitmap ret = null;
            int wi, hi;
            wi = realThumbDimensions[0];
            hi = realThumbDimensions[1];

            // original code that creates lousy thumbnails
            // System.Drawing.Image ret = source.GetThumbnailImage(wi,hi,null,IntPtr.Zero);
            ret = new Bitmap(wi, hi);
            using (Graphics g = Graphics.FromImage(ret))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.FillRectangle(Brushes.White, 0, 0, wi, hi);
                g.DrawImage(imgPhoto, 0, 0, wi, hi);
            }

            return ret;
        }

        public static System.Drawing.Image ScaleImage(System.Drawing.Image imgPhoto, int maxExpectedWidth, int maxExpectedHeight, int maxWidth, int maxHeight)
        {
            int[] realThumbDimensions = GetProportionalThumbnailSize(imgPhoto.Width, imgPhoto.Height, maxExpectedWidth, maxExpectedHeight);

            //if (imgPhoto.Width < maxExpectedWidth && imgPhoto.Height < maxExpectedHeight) return imgPhoto;
            int x = 0;
            int y = 0;

            if (maxExpectedWidth < maxWidth)
                x = (maxWidth - maxExpectedWidth) / 2;
            if (maxExpectedHeight < maxHeight)
                y = (maxHeight - maxExpectedHeight) / 2;

            System.Drawing.Bitmap ret = null;
            int wi, hi;
            wi = realThumbDimensions[0];
            hi = realThumbDimensions[1];

            // original code that creates lousy thumbnails
            // System.Drawing.Image ret = source.GetThumbnailImage(wi,hi,null,IntPtr.Zero);
            ret = new Bitmap(maxWidth, maxHeight);
            using (Graphics g = Graphics.FromImage(ret))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.FillRectangle(Brushes.White, 0, 0, maxWidth, maxHeight);
                g.DrawImage(imgPhoto, x, y, wi, hi);
            }

            return ret;
        }

        public static void CreateThumbnail(string OriginalImagePhysicalPath, string ThumbnailPhysicalPath, int ThumbnailWidth, int ThumbnailHeight)
        {
            // Create thumbnail with same guid above
            using (System.Drawing.Image imgOriginal = System.Drawing.Image.FromFile(OriginalImagePhysicalPath))
            {
                using (System.Drawing.Image imgThumbnail = ScaleImage(imgOriginal, ThumbnailWidth, ThumbnailHeight))
                {
                    if (ThumbnailPhysicalPath.Substring(ThumbnailPhysicalPath.Length - 4).ToUpper().IndexOf(".JPG") > -1)
                        imgThumbnail.Save(ThumbnailPhysicalPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    else if (ThumbnailPhysicalPath.Substring(ThumbnailPhysicalPath.Length - 4).ToUpper().IndexOf(".JPEG") > -1)
                        imgThumbnail.Save(ThumbnailPhysicalPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    else if (ThumbnailPhysicalPath.Substring(ThumbnailPhysicalPath.Length - 4).ToUpper().IndexOf(".GIF") > -1)
                        imgThumbnail.Save(ThumbnailPhysicalPath, System.Drawing.Imaging.ImageFormat.Gif);
                    else if (ThumbnailPhysicalPath.Substring(ThumbnailPhysicalPath.Length - 4).ToUpper().IndexOf(".PNG") > -1)
                        imgThumbnail.Save(ThumbnailPhysicalPath, System.Drawing.Imaging.ImageFormat.Png);
                    else if (ThumbnailPhysicalPath.Substring(ThumbnailPhysicalPath.Length - 4).ToUpper().IndexOf(".bmp") > -1)
                        imgThumbnail.Save(ThumbnailPhysicalPath, System.Drawing.Imaging.ImageFormat.Png);
                    imgOriginal.Dispose();
                    imgThumbnail.Dispose();
                }
            }
        }

        public static string CreateImagesFolder(string PathFolder, string name)
        {
            //Create Images Folder
            string guid = System.Guid.NewGuid().ToString().Substring(0, 20);
            //string strImagePath =  name + guid;
            string strImagePath = name;

            try
            {
                if (!Directory.Exists(PathFolder + strImagePath))
                {
                    Directory.CreateDirectory(PathFolder + strImagePath);
                }
            }
            catch (Exception ex1)
            {
            }
            return strImagePath;
        }
        public static string CreateThumbnailFolder(string PathFolder, string name)
        {
            //Create Images Folder
            string guid = System.Guid.NewGuid().ToString().Substring(0, 20);
            string strThunbnailPath = name + guid;
            try
            {

                if (!Directory.Exists(strThunbnailPath))
                {
                    Directory.CreateDirectory(PathFolder + strThunbnailPath);
                }
            }
            catch (Exception ex)
            {
            }
            return strThunbnailPath;
        }

        private static int[] GetProportionalThumbnailSize(int originalWidth, int originalHeight, int MAX_THUMBNAIL_WIDTH, int MAX_THUMBNAIL_HEIGHT)
        {
            int realWidth = MAX_THUMBNAIL_WIDTH;
            int realHeight = MAX_THUMBNAIL_HEIGHT;
            if (originalWidth > originalHeight)
            {
                realHeight = (int)Math.Round((decimal)(originalHeight * MAX_THUMBNAIL_WIDTH / originalWidth));
            }
            else
            {
                realWidth = (int)Math.Round((decimal)(originalWidth * MAX_THUMBNAIL_HEIGHT / originalHeight));
            }
            return new int[] { realWidth, realHeight };
        }

        public static System.Drawing.Imaging.ImageFormat GetImageFormatFromFileName(string ImageFilePath, out string ContentType)
        {
            System.Drawing.Imaging.ImageFormat imageFormat;
            ContentType = "image/";

            if (ImageFilePath.Substring(ImageFilePath.Length - 4).ToUpper().IndexOf(".JPG") > -1
                || ImageFilePath.Substring(ImageFilePath.Length - 4).ToUpper().IndexOf(".JPEG") > -1)
            {
                ContentType += "jpg";
                imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            }
            else if (ImageFilePath.Substring(ImageFilePath.Length - 4).ToUpper().IndexOf(".GIF") > -1)
            {
                ContentType += "gif";
                imageFormat = System.Drawing.Imaging.ImageFormat.Gif;
            }

            else if (ImageFilePath.Substring(ImageFilePath.Length - 4).ToUpper().IndexOf(".BMP") > -1)
            {
                ContentType += "bmp";
                imageFormat = System.Drawing.Imaging.ImageFormat.Bmp;
            }
            else if (ImageFilePath.Substring(ImageFilePath.Length - 4).ToUpper().IndexOf(".PNG") > -1)
            {
                ContentType += "png";
                imageFormat = System.Drawing.Imaging.ImageFormat.Png;
            }
            else // default
            {
                ContentType += "jpg";
                imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            }

            return imageFormat;
        }

        public static System.Drawing.Imaging.ImageFormat GetImageFormatFromFileName(string ImageFilePath)
        {
            string contentType;
            return GetImageFormatFromFileName(ImageFilePath, out contentType);
        }

    }
}
