using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTimePropPage.Implementation {

    public class Program {

        static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // exe [file path] [create datetime] [update datetime] [access datetime]
            if (args.Length < 4) {
                ShowHelp();
                return;
            }

            // get the arguments
            var filepath = args[0];
            var ctString = args[1];
            var utString = args[2];
            var atString = args[3];

            // check arguments
            if (!File.Exists(filepath)) {
                ShowError("ファイルは見つかりません、もう一度確認してください。");
                return;
            }
            DateTime createTime, updateTime, accessTime;
            try {
                var format = "yyyy-MM-ddTHH:mm:ss";
                createTime = DateTime.ParseExact(ctString, format, null);
                updateTime = DateTime.ParseExact(utString, format, null);
                accessTime = DateTime.ParseExact(atString, format, null);
            } catch (Exception) {
                ShowError("日時の形式は 0000-00-00T00:00:00 ではありません、もう一度確認してください。");
                return;
            }

            // main process
            try {
                var info = new FileInfo(filepath);
                info.CreationTime = createTime;
                info.LastWriteTime = updateTime;
                info.LastAccessTime = accessTime;
            } catch (UnauthorizedAccessException ex) {
                var principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
                if (!principal.IsInRole(WindowsBuiltInRole.Administrator)) {
                    // not in admin, try to get admin authority
                    ProcessStartInfo psi = new ProcessStartInfo {
                        FileName = Application.ExecutablePath,
                        Arguments = string.Join(" ", args),
                        Verb = "runas"
                    };
                    Process.Start(psi);
                    return;
                }
                ShowError($"管理者の権限がありませんので、ファイルの日時の変更は失敗しました。詳細：\n{ex}");
                return;
            } catch (Exception ex) {
                ShowError($"ファイルの日時の変更は失敗しました。詳細：\n{ex}");
            }
        }

        private static void ShowHelp() {
            MessageBox.Show(new Form { TopMost = true }, $"用例: {AppDomain.CurrentDomain.FriendlyName} " +
                "[ファイルパス] [作成日時] [更新日時] [ｱｸｾｽ日時]、日時は 0000-00-00T00:00:00 のような形式にしてください。",
                "ファイル日時", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void ShowError(string message) {
            MessageBox.Show(new Form { TopMost = true }, message, "ファイル日時", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
