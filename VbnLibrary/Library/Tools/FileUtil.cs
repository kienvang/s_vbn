using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Library.Tools
{
    public class FileEntity
    {
        public string FileName { get; set; }
        public string FileNameRoot { get; set; }
        public long FileLen { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
    }
    public class FileUtil
    {
        public static long TotalLinesOfFile(String fileName)
        {
            if (System.IO.File.Exists(fileName))
                return System.IO.File.ReadAllLines(fileName).Length;
            return 0;
        }
        public static byte[] ReadByteArrayFromFile(string fileName)
        {
            byte[] buff = null;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long numBytes = new FileInfo(fileName).Length;
            buff = br.ReadBytes((int)numBytes);
            br.Close();
            fs.Close();
            return buff;
        }

        /// <summary>
        /// Lay tat ca thu muc con(ke ca thu muc cha)
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        public static List<string> GetAllDirectory(string dir)
        {
            List<string> lstDir = new List<string>();
            GetAllDirectory(dir, lstDir);
            return lstDir;
        }
        protected static void GetAllDirectory(string dir, List<string> lstDir)
        {
            string[] subDirs = Directory.GetDirectories(dir);
            lstDir.Add(dir);
            for (int i = 0; i < subDirs.Length; i++)
            {
                GetAllDirectory(subDirs[i], lstDir);
            }
        }

        /// <summary>
        /// Lay ta ca thu muc con rong(khong chua thu muc con nao khac trong do)
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        public static List<string> GetSubDirectory(string dir)
        {
            List<string> lstDir = new List<string>();
            GetSubDirectory(dir, lstDir);
            return lstDir;
        }
        protected static void GetSubDirectory(string dir, List<string> lstDir)
        {
            string[] subDirs = Directory.GetDirectories(dir);
            if (subDirs.Length == 0)
                lstDir.Add(dir);
            else
            {
                for (int i = 0; i < subDirs.Length; i++)
                {
                    GetSubDirectory(subDirs[i], lstDir);
                }

            }
        }

        public static FileEntity UploadFile(Stream file, string path, string filename)
        {
            string fileId = Guid.NewGuid().ToString();
            string filepath = path.Trim('\\', '/') + "/" + fileId + filename.Substring(filename.LastIndexOf("."));
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            FileEntity finfo = null;
            try
            {
                finfo = new FileEntity();
                finfo.FileLen = file.Length;
                finfo.FileNameRoot = filename;
                finfo.FileName = fileId + filename.Substring(filename.LastIndexOf("."));
                finfo.FileType = filename.Substring(filename.LastIndexOf(".") + 1);

                byte[] fcontent = ReadByteArrayFromStream(file);
                fs.Write(fcontent, 0, fcontent.Length);
                fs.Flush();
                fs.Close();
                return finfo;
            }
            catch (Exception ex)
            {
                return finfo;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
            }
        }

        public static byte[] ReadByteArrayFromStream(Stream stream)
        {
            long originalPosition = stream.Position;
            stream.Position = 0;

            try
            {
                byte[] readBuffer = new byte[4096];

                int totalBytesRead = 0;
                int bytesRead;

                while ((bytesRead = stream.Read(readBuffer, totalBytesRead, readBuffer.Length - totalBytesRead)) > 0)
                {
                    totalBytesRead += bytesRead;

                    if (totalBytesRead == readBuffer.Length)
                    {
                        int nextByte = stream.ReadByte();
                        if (nextByte != -1)
                        {
                            byte[] temp = new byte[readBuffer.Length * 2];
                            Buffer.BlockCopy(readBuffer, 0, temp, 0, readBuffer.Length);
                            Buffer.SetByte(temp, totalBytesRead, (byte)nextByte);
                            readBuffer = temp;
                            totalBytesRead++;
                        }
                    }
                }

                byte[] buffer = readBuffer;
                if (readBuffer.Length != totalBytesRead)
                {
                    buffer = new byte[totalBytesRead];
                    Buffer.BlockCopy(readBuffer, 0, buffer, 0, totalBytesRead);
                }
                return buffer;
            }
            finally
            {
                stream.Position = originalPosition;
            }
        }

    }
}
