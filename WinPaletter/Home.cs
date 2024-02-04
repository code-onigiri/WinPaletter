﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinPaletter.NativeMethods;
using static WinPaletter.PreviewHelpers;
using static WinPaletter.Theme.Manager;

namespace WinPaletter
{
    public partial class Home : Form
    {
        private bool _shown = false;
        private bool RaiseUpdate = false;
        private string ver = string.Empty;
        private int StableInt, BetaInt, UpdateChannel;
        private int ChannelFixer;
        private List<string> Updates_ls = new();
        public string file = string.Empty;
        public bool LoggingOff = false;

        public Home()
        {
            InitializeComponent();
            Icon = Forms.MainForm.Icon;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.LoadLanguage();
            ApplyStyle(this);

            _shown = false;
            LoggingOff = false;

            NotifyUpdates.Icon = Icon;

            if (!Program.Elevated) apply_btn.Image = Properties.Resources.WP_Admin;

            win11.Checked = Program.WindowStyle == WindowStyle.W12 || Program.WindowStyle == WindowStyle.W11;
            win10.Checked = Program.WindowStyle == WindowStyle.W10;
            win81.Checked = Program.WindowStyle == WindowStyle.W81;
            win7.Checked = Program.WindowStyle == WindowStyle.W7;
            winVista.Checked = Program.WindowStyle == WindowStyle.WVista;
            winXP.Checked = Program.WindowStyle == WindowStyle.WXP;

            switch (Program.WindowStyle)
            {
                case WindowStyle.W12:
                    card1.Image = Assets.Banners.Win12;
                    break;

                case WindowStyle.W11:
                    card1.Image = Assets.Banners.Win11;
                    break;

                case WindowStyle.W10:
                    card1.Image = Assets.Banners.Win10;
                    break;

                case WindowStyle.W81:
                    card1.Image = Assets.Banners.Win81;
                    break;

                case WindowStyle.W7:
                    card1.Image = Assets.Banners.WinOld;
                    break;

                case WindowStyle.WVista:
                    card1.Image = Assets.Banners.WinOld;
                    break;

                case WindowStyle.WXP:
                    card1.Image = Assets.Banners.WinOld;
                    break;

                default:
                    card1.Image = Assets.Banners.Win12;
                    break;
            }

            LoadData();

            foreach (UI.WP.Button button in titlebarExtender2.GetAllControls().OfType<UI.WP.Button>())
            {
                button.MouseEnter += (s, e) => FluentTransitions.Transition.With(tip_label, nameof(tip_label.Text), (s as UI.WP.Button).Tag as string).CriticalDamp(TimeSpan.FromMilliseconds(Program.AnimationDuration_Quick));
                button.MouseLeave += (s, e) => FluentTransitions.Transition.With(tip_label, nameof(tip_label.Text), string.Empty).CriticalDamp(TimeSpan.FromMilliseconds(Program.AnimationDuration_Quick));
            }
        }

        public void LoadData()
        {
            userButton.Tag = User.UserName;
            userButton.Image = User.ProfilePicture.Resize(38, 38);
        }

        public void LoadFromTM(Theme.Manager TM)
        {

        }

        public async void AutoUpdatesCheck()
        {
            if (OS.WXP || OS.WVista) return;

            StableInt = 0;
            BetaInt = 0;
            UpdateChannel = 0;
            ChannelFixer = Program.Settings.Updates.Channel == Settings.Structures.Updates.Channels.Stable ? 0 : 1;

            if (Program.IsNetworkAvailable)
            {
                try
                {
                    using (DownloadManager DM = new())
                    {
                        RaiseUpdate = false;
                        ver = string.Empty;

                        string result = await DM.ReadStringAsync(Properties.Resources.Link_Updates);
                        Updates_ls = result.CList();

                        foreach (string updateInfo in Updates_ls.Where(update => !string.IsNullOrEmpty(update) && !update.StartsWith("#")))
                        {
                            string[] updateParts = updateInfo.Split(' ');

                            if (updateParts.Length >= 2)
                            {
                                if ((updateParts[0] ?? "stable").ToLower() == "stable") StableInt = Updates_ls.IndexOf(updateInfo);
                                if ((updateParts[0] ?? "stable").ToLower() == "beta") BetaInt = Updates_ls.IndexOf(updateInfo);
                            }
                        }

                        UpdateChannel = (ChannelFixer == 0) ? StableInt : BetaInt;

                        ver = Updates_ls.ElementAtOrDefault(UpdateChannel)?.Split(' ')[1];

                        RaiseUpdate = !string.IsNullOrEmpty(ver) && ver.CompareTo(Program.Version) == 1;
                    }
                }
                catch (WebException ex)
                {
                    // Handle the exception, e.g., log or display an error message
                    Console.WriteLine($"WebException: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Handle other exceptions, e.g., log or display an error message
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }

            Invoke(() =>
            {
                if (RaiseUpdate)
                {
                    Forms.Updates.ls = Updates_ls;
                    NotifyUpdates.Visible = true;
                    Button5.ImageVector = Properties.Resources.Update_Dot;
                    NotifyUpdates.ShowBalloonTip(10000, Application.ProductName, $"{Program.Lang.NewUpdate}. {Program.Lang.Version} {ver}", ToolTipIcon.Info);
                }
            });
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            User.Login(true);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.About);
        }

        private void Button39_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Resources.Link_Wiki);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.Whatsnew);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.RescueTools);
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            if (OS.WXP)
            {
                if (MsgBox(string.Format(Program.Lang.Store_WontWork_Protocol, Program.Lang.OS_WinXP), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                    return;
            }
            else if (OS.WVista)
            {
                if (MsgBox(string.Format(Program.Lang.Store_WontWork_Protocol, Program.Lang.OS_WinVista), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                    return;
            }

            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.Store);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.Updates);
            Button5.ImageVector = Properties.Resources.Update;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.SettingsX);
        }

        private void card1_Click(object sender, EventArgs e)
        {
            Form form;

            if (Program.WindowStyle == WindowStyle.W12)
            {
                form = Forms.Win11Colors;
            }
            else if (Program.WindowStyle == WindowStyle.W11)
            {
                form = Forms.Win11Colors;
            }
            else if (Program.WindowStyle == WindowStyle.W10)
            {
                form = Forms.Win10Colors;
            }
            else if (Program.WindowStyle == WindowStyle.W81)
            {
                form = Forms.Win81Colors;
            }
            else if (Program.WindowStyle == WindowStyle.W7)
            {
                form = Forms.Win7Colors;
            }
            else if (Program.WindowStyle == WindowStyle.WVista)
            {
                form = Forms.WinVistaColors;
            }
            else if (Program.WindowStyle == WindowStyle.WXP)
            {
                form = Forms.WinXPColors;
            }
            else
            {
                form = Forms.Win11Colors;
            }

            Forms.MainForm.tabsContainer1.AddFormIntoTab(form);
        }

        private void card2_Click(object sender, EventArgs e)
        {
            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.Win32UI);
        }

        private void card3_Click(object sender, EventArgs e)
        {
            if (Program.WindowStyle == WindowStyle.W12 || Program.WindowStyle == WindowStyle.W11 || Program.WindowStyle == WindowStyle.W10)
            {
                Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.LogonUI);
            }
            else if (Program.WindowStyle == WindowStyle.W81 | Program.WindowStyle == WindowStyle.W7)
            {
                Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.LogonUI7);
            }
            else if (Program.WindowStyle == WindowStyle.WXP)
            {
                Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.LogonUIXP);
            }
            else if (Program.WindowStyle == WindowStyle.WVista)
            {
                MsgBox(Program.Lang.VistaLogonNotSupported, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.LogonUI);
            }
        }

        private void card6_Click(object sender, EventArgs e)
        {
            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.CursorsStudio);
        }

        private void card5_Click(object sender, EventArgs e)
        {
            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.Metrics_Fonts);
        }

        private void card4_Click(object sender, EventArgs e)
        {
            Forms.TerminalsDashboard.ShowDialog();
        }

        private void card8_Click(object sender, EventArgs e)
        {
            if (Program.WindowStyle == WindowStyle.W12)
            {
                Forms.Wallpaper_Editor.WT = Program.TM.WallpaperTone_W12;
            }
            else if (Program.WindowStyle == WindowStyle.W11)
            {
                Forms.Wallpaper_Editor.WT = Program.TM.WallpaperTone_W11;
            }
            else if (Program.WindowStyle == WindowStyle.W10)
            {
                Forms.Wallpaper_Editor.WT = Program.TM.WallpaperTone_W10;
            }
            else if (Program.WindowStyle == WindowStyle.W81)
            {
                Forms.Wallpaper_Editor.WT = Program.TM.WallpaperTone_W81;
            }
            else if (Program.WindowStyle == WindowStyle.W7)
            {
                Forms.Wallpaper_Editor.WT = Program.TM.WallpaperTone_W7;
            }
            else if (Program.WindowStyle == WindowStyle.WVista)
            {
                Forms.Wallpaper_Editor.WT = Program.TM.WallpaperTone_WVista;
            }
            else if (Program.WindowStyle == WindowStyle.WXP)
            {
                Forms.Wallpaper_Editor.WT = Program.TM.WallpaperTone_WXP;
            }
            else
            {
                Forms.Wallpaper_Editor.WT = Program.TM.WallpaperTone_W12;
            }

            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.Wallpaper_Editor);
        }

        private void card9_Click(object sender, EventArgs e)
        {
            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.WinEffecter);
        }

        private void card7_Click(object sender, EventArgs e)
        {
            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.Sounds_Editor);
        }

        private void card11_Click(object sender, EventArgs e)
        {
            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.ScreenSaver_Editor);
        }

        private void card12_Click(object sender, EventArgs e)
        {
            if (Program.WindowStyle != WindowStyle.WXP && Program.WindowStyle != WindowStyle.WVista)
            {
                Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.AltTabEditor);
            }
            else
            {
                if (Program.WindowStyle == WindowStyle.WXP)
                    MsgBox(string.Format(Program.Lang.AltTab_Unsupported, Program.Lang.OS_WinXP), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (Program.WindowStyle == WindowStyle.WVista)
                    MsgBox(string.Format(Program.Lang.AltTab_Unsupported, Program.Lang.OS_WinVista), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void card10_Click(object sender, EventArgs e)
        {
            Forms.ApplicationThemer.FixLanguageDarkModeBug = false;
            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.ApplicationThemer);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new() { Filter = Program.Filters.WinPaletterTheme, FileName = file, Title = Program.Lang.Filter_SaveWinPaletterTheme })
            {
                Forms.MainForm.ExitWithChangedFileResponse(dlg, () => Forms.ThemeLog.Apply_Theme(), () => Forms.ThemeLog.Apply_Theme(Program.TM_FirstTime), () => Forms.ThemeLog.Apply_Theme(Theme.Default.Get()));
            }

            Program.TM = new(Theme.Manager.Source.Registry);
            Program.TM_Original = (Theme.Manager)Program.TM.Clone();
            file = null;
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new() { Filter = Program.Filters.WinPaletterTheme, FileName = file, Title = Program.Lang.Filter_SaveWinPaletterTheme })
            {
                Forms.MainForm.ExitWithChangedFileResponse(dlg, () => Forms.ThemeLog.Apply_Theme(), () => Forms.ThemeLog.Apply_Theme(Program.TM_FirstTime), () => Forms.ThemeLog.Apply_Theme(Theme.Default.Get()));
            }

            Program.TM = (Theme.Manager)Theme.Default.Get().Clone();
            file = null;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new() { Filter = Program.Filters.WinPaletterTheme, FileName = file, Title = Program.Lang.Filter_OpenWinPaletterTheme })
            using (SaveFileDialog save_dlg = new() { Filter = Program.Filters.WinPaletterTheme, FileName = file, Title = Program.Lang.Filter_SaveWinPaletterTheme })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Forms.MainForm.ExitWithChangedFileResponse(save_dlg, () => Forms.ThemeLog.Apply_Theme(), () => Forms.ThemeLog.Apply_Theme(Program.TM_FirstTime), () => Forms.ThemeLog.Apply_Theme(Theme.Default.Get()));

                    if (Program.Settings.BackupTheme.Enabled && Program.Settings.BackupTheme.AutoBackupOnThemeLoad)
                    {
                        string filename = Program.GetUniqueFileName($"{Program.Settings.BackupTheme.BackupPath}\\OnThemeOpen", $"{Program.TM.Info.ThemeName}_{DateTime.Now.Hour}.{DateTime.Now.Minute}.{DateTime.Now.Second}.wpth");
                        Program.TM.Save(Source.File, filename);
                    }

                    file = dlg.FileName;
                    Program.TM = new(Theme.Manager.Source.File, dlg.FileName);
                    Program.TM_Original = (Theme.Manager)Program.TM.Clone();
                }
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new() { Filter = Program.Filters.WinPaletterTheme, FileName = file, Title = Program.Lang.Filter_SaveWinPaletterTheme })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Program.TM.Save(Theme.Manager.Source.File, dlg.FileNames[0]);
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new() { Filter = Program.Filters.WinPaletterTheme, FileName = file, Title = Program.Lang.Filter_SaveWinPaletterTheme })
            {
                if (!System.IO.File.Exists(dlg.FileName))
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        Program.TM.Save(Theme.Manager.Source.File, dlg.FileNames[0]);
                    }
                }
                else
                {
                    Program.TM.Save(Theme.Manager.Source.File, dlg.FileNames[0]);
                }
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.EditInfo);
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.BackupThemes_List);
        }

        private void winXP_CheckedChanged(object sender, EventArgs e)
        {
            if (_shown && winXP.Checked)
            {
                Program.WindowStyle = WindowStyle.WXP;
                card1.Image = Assets.Banners.WinOld;
            }
        }

        private void winVista_CheckedChanged(object sender, EventArgs e)
        {
            if (_shown && winVista.Checked)
            {
                Program.WindowStyle = WindowStyle.WVista;
                card1.Image = Assets.Banners.WinOld;
            }
        }

        private void win7_CheckedChanged(object sender, EventArgs e)
        {
            if (_shown && win7.Checked)
            {
                Program.WindowStyle = WindowStyle.W7;
                card1.Image = Assets.Banners.WinOld;
            }
        }

        private void win81_CheckedChanged(object sender, EventArgs e)
        {
            if (_shown && win81.Checked)
            {
                Program.WindowStyle = WindowStyle.W81;
                card1.Image = Assets.Banners.Win81;
            }
        }

        private void win10_CheckedChanged(object sender, EventArgs e)
        {
            if (_shown && win10.Checked)
            {
                Program.WindowStyle = WindowStyle.W10;
                card1.Image = Assets.Banners.Win10;
            }
        }

        private void win11_CheckedChanged(object sender, EventArgs e)
        {
            if (_shown && win11.Checked)
            {
                Program.WindowStyle = WindowStyle.W11;
                card1.Image = Assets.Banners.Win11;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Resources.Link_PayPal);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            if (MsgBox(Program.Lang.LogoffQuestion, MessageBoxButtons.YesNo, MessageBoxIcon.Question, Program.Lang.LogoffAlert1, string.Empty, string.Empty, string.Empty, string.Empty, Program.Lang.LogoffAlert2, Ookii.Dialogs.WinForms.TaskDialogIcon.Information) == DialogResult.Yes)
            {
                LoggingOff = true;
                IntPtr intPtr = IntPtr.Zero;
                Kernel32.Wow64DisableWow64FsRedirection(ref intPtr);
                if (System.IO.File.Exists($@"{PathsExt.System32}\logoff.exe"))
                {
                    Interaction.Shell($@"{PathsExt.System32}\logoff.exe", AppWinStyle.Hide);
                }
                else
                {
                    MsgBox(string.Format(Program.Lang.LogoffNotFound, PathsExt.System32), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            Program.RestartExplorer();
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            Forms.ThemeLog.Apply_Theme();
        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            _shown = true;

            if (Program.Settings.Updates.AutoCheck) Task.Run(AutoUpdatesCheck);
        }

        private void NotifyUpdates_BalloonTipClicked(object sender, EventArgs e)
        {
            NotifyUpdates.Visible = false;
            Forms.MainForm.tabsContainer1.AddFormIntoTab(Forms.Updates);
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Forms.MainForm.tabsContainer1.TabControl.Visible = false;
            Forms.MainForm.Close();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        ////new UI.Style.SchemeEditor().Show();
        //}

        private void pin_button_Click(object sender, EventArgs e)
        {
            Forms.MainForm.tabsContainer1.AddFormIntoTab(this);
        }

        private void Dashboard_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null && Parent is TabPage)
            {
                pin_button.Visible = false;
            }
            else
            {
                pin_button.Visible = true;
            }
        }
    }
}