﻿using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace WinPaletter
{
    internal partial class Program
    {
        public static void CreateUninstaller()
        {
            string guidText = Application.ProductName;
            string RegPath = $"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\{guidText}";

            if (!System.IO.Directory.Exists(PathsExt.appData)) System.IO.Directory.CreateDirectory(PathsExt.appData);

            WriteIfChangedOrNotExists($"{PathsExt.appData}\\uninstall.ico", Properties.Resources.Icon_Uninstall.ToByteArray());

            EditReg(RegPath, "DisplayName", "WinPaletter", RegistryValueKind.String);
            EditReg(RegPath, "ApplicationVersion", Version, RegistryValueKind.String);
            EditReg(RegPath, "DisplayVersion", Version, RegistryValueKind.String);
            EditReg(RegPath, "Publisher", Application.CompanyName, RegistryValueKind.String);
            EditReg(RegPath, "DisplayIcon", $"{PathsExt.appData}\\uninstall.ico", RegistryValueKind.String);
            EditReg(RegPath, "URLInfoAbout", Properties.Resources.Link_Repository, RegistryValueKind.String);
            EditReg(RegPath, "Contact", Properties.Resources.Link_Repository, RegistryValueKind.String);
            EditReg(RegPath, "InstallDate", DateTime.Now.ToString("yyyyMMdd"), RegistryValueKind.String);
            EditReg(RegPath, "Comments", Lang.Uninstall_Comment, RegistryValueKind.String);
            EditReg(RegPath, "UninstallString", $"{AppFile} -u", RegistryValueKind.String);
            EditReg(RegPath, "QuietUninstallString", $"{AppFile} -q", RegistryValueKind.String);
            EditReg(RegPath, "InstallLocation", new System.IO.FileInfo(Application.ExecutablePath).DirectoryName, RegistryValueKind.String);
            EditReg(RegPath, "NoModify", 1, RegistryValueKind.DWord);
            EditReg(RegPath, "NoRepair", 1, RegistryValueKind.DWord);
            EditReg(RegPath, "EstimatedSize", Length / 1024, RegistryValueKind.DWord);
        }

        public static void Uninstall_Quiet()
        {
            DeleteFileAssociation(".wpth", "WinPaletter.ThemeFile");
            DeleteFileAssociation(".wpsf", "WinPaletter.SettingsFile");
            DeleteFileAssociation(".wptp", "WinPaletter.ThemeResourcesPack");

            Registry.CurrentUser.DeleteSubKeyTree(@"Software\WinPaletter", false);

            try
            {
                if (!OS.WXP && System.IO.File.Exists($"{PathsExt.appData}\\WindowsStartup_Backup.wav"))
                {
                    string file = $"{PathsExt.appData}\\WindowsStartup_Backup.wav";

                    byte[] CurrentSoundBytes = PE.GetResource(PathsExt.imageres, "WAVE", OS.WVista ? 5051 : 5080);
                    byte[] TargetSoundBytes = System.IO.File.ReadAllBytes(file);

                    if (!CurrentSoundBytes.Equals_Method2(TargetSoundBytes))
                    {
                        PE.ReplaceResource(PathsExt.imageres, "WAV", OS.WVista ? 5051 : 5080, TargetSoundBytes);
                    }
                }
            }
            catch { } // Ignore errors, could be caused by lack of permissions and we need to continue with the uninstallation as silent as possible

            if (System.IO.Directory.Exists(PathsExt.appData))
            {
                if (!OS.WXP)
                {
                    Theme.Manager.ResetCursorsToAero();
                    if (Settings.ThemeApplyingBehavior.Cursors_HKU_DEFAULT_Prefs == Settings.Structures.ThemeApplyingBehavior.OverwriteOptions.Overwrite)
                        Theme.Manager.ResetCursorsToAero(@"HKEY_USERS\.DEFAULT");
                }

                else
                {
                    Theme.Manager.ResetCursorsToNone_XP();
                    if (Settings.ThemeApplyingBehavior.Cursors_HKU_DEFAULT_Prefs == Settings.Structures.ThemeApplyingBehavior.OverwriteOptions.Overwrite)
                        Theme.Manager.ResetCursorsToNone_XP(@"HKEY_USERS\.DEFAULT");
                }

                try { System.IO.Directory.Delete(PathsExt.appData, true); } 
                catch { } // Ignore errors, could be caused by lack of permissions and we need to continue with the uninstallation as silent as possible

            }

            Forms.SysEventsSndsInstaller.Uninstall(true);

            if (System.IO.Directory.Exists(PathsExt.ProgramFilesData))
            {
                try { System.IO.Directory.Delete(PathsExt.ProgramFilesData, true); } 
                catch { } // Ignore errors, could be caused by lack of permissions and we need to continue with the uninstallation as silent as possible
            }

            string guidText = Application.ProductName;
            Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall", true).DeleteSubKeyTree(guidText, false);

            Program.UninstallDone = true;

            Environment.ExitCode = 0;

            Program.ForceExit();
        }
    }
}