﻿using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace WinPaletter.Theme.Structures
{
    /// <summary>
    /// Structure responsible for managing Windows screen saver
    /// </summary>
    public struct ScreenSaver : ICloneable
    {
        /// <summary>Controls if this feature is enabled or not</summary>
        public bool Enabled;

        /// <summary>Lock Windows after closure of screen saver</summary>
        public bool IsSecure;

        /// <summary>Inactivity (idle) time after which the screen save will start</summary>
        public int TimeOut;

        /// <summary>Screen saver file</summary>
        public string File;

        /// <summary>
        /// Loads ScreenSaver data from registry
        /// </summary>
        /// <param name="default">Default ScreenSaver data structure</param>
        public void Load(ScreenSaver @default)
        {
            Enabled = Convert.ToBoolean(Conversion.Val(GetReg(@"HKEY_CURRENT_USER\Control Panel\Desktop", "ScreenSaveActive", @default.Enabled ? 1 : 0)));
            IsSecure = Convert.ToBoolean(Conversion.Val(GetReg(@"HKEY_CURRENT_USER\Control Panel\Desktop", "ScreenSaverIsSecure", @default.IsSecure ? 1 : 0)));
            TimeOut = (int)Math.Round(Conversion.Val(GetReg(@"HKEY_CURRENT_USER\Control Panel\Desktop", "ScreenSaveTimeOut", @default.TimeOut)));
            File = GetReg(@"HKEY_CURRENT_USER\Control Panel\Desktop", "SCRNSAVE.EXE", @default.File).ToString();
        }

        /// <summary>
        /// Saves ScreenSaver data into registry
        /// </summary>
        /// <param name="TreeView">TreeView used as theme log</param>
        public void Apply(TreeView TreeView = null)
        {
            EditReg(TreeView, @"HKEY_CURRENT_USER\Control Panel\Desktop", "ScreenSaveActive", Enabled ? 1 : 0, RegistryValueKind.String);
            EditReg(TreeView, @"HKEY_CURRENT_USER\Control Panel\Desktop", "ScreenSaverIsSecure", IsSecure ? 1 : 0, RegistryValueKind.String);
            EditReg(TreeView, @"HKEY_CURRENT_USER\Control Panel\Desktop", "ScreenSaveTimeOut", TimeOut, RegistryValueKind.String);
            EditReg(TreeView, @"HKEY_CURRENT_USER\Control Panel\Desktop", "SCRNSAVE.EXE", File, RegistryValueKind.String);
        }

        /// <summary>Operator to check if two ScreenSaver structures are equal</summary>
        public static bool operator ==(ScreenSaver First, ScreenSaver Second)
        {
            return First.Equals(Second);
        }

        /// <summary>Operator to check if two ScreenSaver structures are not equal</summary>
        public static bool operator !=(ScreenSaver First, ScreenSaver Second)
        {
            return !First.Equals(Second);
        }

        /// <summary>Clones ScreenSaver structure</summary>
        public readonly object Clone()
        {
            return MemberwiseClone();
        }

        /// <summary>Checks if two ScreenSaver structures are equal or not</summary>
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        /// <summary>Get hash code of ScreenSaver structure</summary>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
