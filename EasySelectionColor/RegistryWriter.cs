using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySelectionColor
{
    internal class RegistryWriter
    {
        public RegistryWriter() { }

        public void SetControlPanelColorsValue(string key, object value)
        {
            var branchRoot = Registry.CurrentUser.OpenSubKey("Control Panel\\Colors", true);
            if (branchRoot == null)
                throw new ArgumentException("No subkey found for user: HKEY_CURRENT_USER\\ControlPanel\\Colors");
            
            branchRoot.SetValue(key, value);
        }

        public object GetControlPanelColorsValue(string key)
        {
            var branchRoot = Registry.CurrentUser.OpenSubKey("Control Panel\\Colors");
            if (branchRoot == null)
                throw new ArgumentException("");

            return branchRoot.GetValue(key);
        }
    }
}
