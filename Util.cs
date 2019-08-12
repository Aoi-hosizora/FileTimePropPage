using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;
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
        ///
        ///     return: error?
        /// </summary>
        public static bool SaveFileTimes(string filePath, FileTimes fileTimes) {
            try {
                FileInfo finfo = new FileInfo(filePath);
                finfo.CreationTime = fileTimes.CreateTime;
                finfo.LastWriteTime = fileTimes.UpdateTime;
                finfo.LastAccessTime = fileTimes.AccessTime;
                return true;
            }
            catch (UnauthorizedAccessException) {
                return false;
            }
            catch (Exception) {
                return false;
            }
        }

        /// <summary>
        /// Check have administrator authority
        /// </summary>
        public static bool isAdmin() {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();  
            WindowsPrincipal principal = new WindowsPrincipal(identity);  
            return principal.IsInRole(WindowsBuiltInRole.Administrator);  
        }
        
        /// <summary>
        /// Get administrator authority
        /// </summary>
        public static void getAdmin() {
           // ProcessStartInfo psi = new ProcessStartInfo();
           // psi.FileName = Application.ExecutablePath;
           // psi.Verb = "runas";
           // try {
           //     Process.Start(psi);
           //     Application.Exit();
           // }
           // catch (Exception ex) {
           //     MessageBox.Show(ex.Message);
           // }
        }
    }
}