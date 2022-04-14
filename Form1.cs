using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace registry
{
    public partial class Form1 : Form
    {
        RegistryKey currentUserKey;

        public Form1()
        {
            currentUserKey = Registry.CurrentUser;
            InitializeComponent();
        }

        private void CreateKey(string keyName, string valueName, string keyValue)
        {
            RegistryKey key = currentUserKey.CreateSubKey(keyName);
            key.SetValue(valueName,keyValue);
            LbxKeys.Items.Add(key.Name);
            key.Close();
        }

        private void BtnCreateKey_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtKeyName.Text) && !String.IsNullOrEmpty(TxtValueName.Text) && !String.IsNullOrEmpty(TxtKeyValue.Text))
            {
                string keyName = TxtKeyName.Text;
                string valueName = TxtValueName.Text;
                string keyValue = TxtKeyValue.Text;
                CreateKey(keyName, valueName, keyValue);
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }

            TxtValueName.Clear();
            TxtKeyValue.Clear();
        }

        private void DeleteKey(string keyName)
        {
            currentUserKey.DeleteSubKey(keyName);
            LbxKeys.Items.Remove(Path.Combine("HKEY_CURRENT_USER", keyName));
            TxtInfo.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtDeleteKeyName.Text))
            {
                DeleteKey(TxtDeleteKeyName.Text);
            }

            TxtDeleteKeyName.Clear();
        }


        private void BtnReadValues_Click(object sender, EventArgs e)
        {
            if (LbxKeys.SelectedItem != null)
            {
                string regName = LbxKeys.SelectedItem.ToString().Remove(0, LbxKeys.SelectedItem.ToString().LastIndexOf('\\')+1);
                RegistryKey key = Registry.CurrentUser.OpenSubKey(regName);
                Dictionary<string, object> keyValuePairs;
                TxtInfo.Text = key.View.ToString();
                using (var settingsRegKey = Registry.CurrentUser.OpenSubKey(regName))
                {
                    var valueNames = settingsRegKey.GetValueNames();
                    keyValuePairs = valueNames.ToDictionary(name => name, settingsRegKey.GetValue);

                    foreach (var regkey in keyValuePairs)
                    {
                        TxtInfo.AppendText(regkey.ToString() + settingsRegKey.GetValue(regkey.ToString())+Environment.NewLine);
                    }
                }
            }
        }
    }
}
