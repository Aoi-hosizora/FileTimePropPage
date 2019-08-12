using System;
using System.IO;
using Module;

namespace Utils {
    public class Util {

        /// <summary>
        /// Get File Times Props
        /// </summary>
        public static FileTimes LoadFileTimes(string filePath) {
            FileInfo finfo = new FileInfo(filePath);
            DateTime ct = finfo.CreationTime;
            DateTime ut = finfo.LastWriteTime;
            DateTime at = finfo.LastAccessTime;
            return new FileTimes(ct: ct, ut: ut, at: at);
        }
        
        /// <summary>
        /// Set File Times Props
        /// </summary>
        public static void SaveFileTimes(string filePath, FileTimes fileTimes) {
            FileInfo finfo = new FileInfo(filePath);
            finfo.CreationTime = fileTimes.CreateTime;
            finfo.LastWriteTime = fileTimes.UpdateTime;
            finfo.LastAccessTime = fileTimes.AccessTime;
        }
    }
}