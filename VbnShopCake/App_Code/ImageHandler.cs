
using System;
using System.Configuration;
using System.Collections;
using System.IO;
using System.Drawing;
using System.Web;

namespace Library.Tools
{
    public class ImageHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext ctx)
        {
            // the max size of the Thumbnail
            int MaxWidth = (ctx.Request["w"] == null) ? 120 : int.Parse(ctx.Request["w"]);
            int MaxHeight = (ctx.Request["h"] == null) ? MaxWidth : int.Parse(ctx.Request["h"]);
            string ImageFilePath = (ctx.Request["f"] == null) ? "/img/chudu24-logo-2.png" : ctx.Request["f"];
            bool IsCrop = (ctx.Request["c"] == null) ? true : ctx.Request["c"].Trim() == "1" ? true : false; // default is crop

            ctx.Trace.Warn("MaxWidth", MaxWidth.ToString());
            ctx.Trace.Warn("MaxHeight", MaxHeight.ToString());
            ctx.Trace.Warn("ImageFilePath", ImageFilePath);
            ctx.Trace.Warn("IsCrop", IsCrop.ToString());

            // let's cache this for 1 day
            System.Drawing.Imaging.ImageFormat imageFormat;
            ctx.Response.ContentType = GetContentType(ImageFilePath, out imageFormat);
            ctx.Response.Cache.SetCacheability(HttpCacheability.Public);
            ctx.Response.Cache.SetExpires(DateTime.Now.AddDays(1));

            // find the directory where we're storing the images
            //string imageDir = ConfigurationSettings.AppSettings["imageDir"];
            //imageDir = Path.Combine(ctx.Request.PhysicalApplicationPath, imageDir);

            // find the image that was requested
            string file = ctx.Server.MapPath(ImageFilePath);

            if (IsCrop)
                CreateCropThumbnail(ctx, file, MaxWidth, imageFormat);
            else
                CreateThumbnail(ctx, file, MaxWidth, MaxHeight, imageFormat);
        }

        private void CreateThumbnail(HttpContext ctx, string file, int MaxWidth, int MaxHeight, System.Drawing.Imaging.ImageFormat imageFormat)
        {
            using (Image img = new Bitmap(file))
            {
                // do some math to resize the image
                int w = img.Width;
                int h = img.Height;
                GetScaledWidthHeight(img.Width, img.Height, MaxWidth, MaxHeight, out w, out h);
                ctx.Trace.Warn("w", w.ToString());
                ctx.Trace.Warn("h", h.ToString());

                // create the thumbnail image
                //using (Image thumbnailImage = img.GetThumbnailImage(w, h, new Image.GetThumbnailImageAbort(Abort), IntPtr.Zero))
                using (Image thumbnailImage = Library.Tools.ImageFunction.ScaleImage(img, w, h, MaxWidth, MaxHeight))
                {
                    // emit it to the response strea,
                    if (imageFormat != System.Drawing.Imaging.ImageFormat.Png)
                    {
                        thumbnailImage.Save(ctx.Response.OutputStream, imageFormat);
                    }
                    else
                    {
                        // with PNG, we need to use this function to avoid error
                        MemoryStream io = new MemoryStream();
                        thumbnailImage.Save(io, imageFormat);
                        ctx.Response.BinaryWrite(io.GetBuffer());
                    }
                }
            }
        }

        // do some math to resize the image
        private void GetScaledWidthHeight(int WidthBeforeResize, int HeightBeforeResize, int MaxWidth, int MaxHeight
            , out int WidthAfterResize, out int HeightAfterResize)
        {
            // do some math to resize the image
            WidthAfterResize = WidthBeforeResize;
            HeightAfterResize = HeightBeforeResize;
            System.Web.HttpContext.Current.Trace.Warn("1 WidthAfterResize", WidthAfterResize.ToString());
            System.Web.HttpContext.Current.Trace.Warn("1 HeightAfterResize", HeightAfterResize.ToString());

            if (WidthAfterResize > MaxWidth | HeightAfterResize > MaxHeight)
            {
                // Determine what dimension is off by more
                int deltaWidth = WidthAfterResize - MaxWidth;
                int deltaHeight = HeightAfterResize - MaxHeight;

                System.Web.HttpContext.Current.Trace.Warn("2 deltaWidth", deltaWidth.ToString());
                System.Web.HttpContext.Current.Trace.Warn("2 deltaHeight", deltaHeight.ToString());

                double scaleFactor = 2.59999;
                System.Web.HttpContext.Current.Trace.Warn("2.1 scaleFactor", scaleFactor.ToString());

                if (deltaHeight > deltaWidth)
                {
                    // Scale by the height
                    scaleFactor = (double)MaxHeight / (double)HeightAfterResize;

                    System.Web.HttpContext.Current.Trace.Warn("3 scaleFactor", scaleFactor.ToString());
                }
                else
                {
                    // Scale by the Width
                    scaleFactor = (double)MaxWidth / (double)WidthAfterResize;

                    System.Web.HttpContext.Current.Trace.Warn("4 scaleFactor", scaleFactor.ToString());
                }

                //WidthAfterResize *= scaleFactor;
                //HeightAfterResize *= scaleFactor;

                WidthAfterResize = Convert.ToInt32(WidthAfterResize * scaleFactor);
                HeightAfterResize = Convert.ToInt32(HeightAfterResize * scaleFactor);

                System.Web.HttpContext.Current.Trace.Warn("5 WidthAfterResize", WidthAfterResize.ToString());
                System.Web.HttpContext.Current.Trace.Warn("5 HeightAfterResize", HeightAfterResize.ToString());
            }
        }

        private void GetScaledWidthHeight_Old(int originalWidth, int originalHeight, int MAX_THUMBNAIL_WIDTH, int MAX_THUMBNAIL_HEIGHT
            , out int WidthAfterResize, out int HeightAfterResize)
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
            WidthAfterResize = realWidth;
            HeightAfterResize = realHeight;
        }

        private void CreateCropThumbnail(HttpContext ctx, string file, int MaxDim, System.Drawing.Imaging.ImageFormat imageFormat)
        {
            using (Image img = new Bitmap(file))
            {
                // create the thumbnail image
                using (Image thumbnailImage = Library.Tools.Image2.Crop(img, MaxDim, MaxDim, Library.Tools.Image2.AnchorPosition.Center))
                {
                    // emit it to the response strea,
                    if (imageFormat != System.Drawing.Imaging.ImageFormat.Png)
                    {
                        thumbnailImage.Save(ctx.Response.OutputStream, imageFormat);
                    }
                    else
                    {
                        // with PNG, we need to use this function to avoid error
                        MemoryStream io = new MemoryStream();
                        thumbnailImage.Save(io, imageFormat);
                        ctx.Response.BinaryWrite(io.GetBuffer());
                    }
                }
            }
        }

        public bool IsReusable
        {
            get { return true; }
        }

        private bool Abort()
        {
            return false;
        }

        private string GetContentType(string ImageFilePath, out System.Drawing.Imaging.ImageFormat imageFormat)
        {
            string contentType = "image/";

            if (ImageFilePath.Substring(ImageFilePath.Length - 4).ToUpper().IndexOf(".JPG") > -1
                || ImageFilePath.Substring(ImageFilePath.Length - 4).ToUpper().IndexOf(".JPEG") > -1)
            {
                contentType += "jpg";
                imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            }
            else if (ImageFilePath.Substring(ImageFilePath.Length - 4).ToUpper().IndexOf(".GIF") > -1)
            {
                contentType += "gif";
                imageFormat = System.Drawing.Imaging.ImageFormat.Gif;
            }

            else if (ImageFilePath.Substring(ImageFilePath.Length - 4).ToUpper().IndexOf(".BMP") > -1)
            {
                contentType += "bmp";
                imageFormat = System.Drawing.Imaging.ImageFormat.Bmp;
            }
            else if (ImageFilePath.Substring(ImageFilePath.Length - 4).ToUpper().IndexOf(".PNG") > -1)
            {
                contentType += "png";
                imageFormat = System.Drawing.Imaging.ImageFormat.Png;
            }
            else // default
            {
                contentType += "jpg";
                imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            }

            return contentType;
        }
    }


}
