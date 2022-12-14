using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TO_DO_LIST_UPDATED
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> keyValuePairs;
        string SettingsFileStorageLocation;
        string SettingsFileName;     
        public Form1()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            keyValuePairs = new Dictionary<string, string>();
            string MyDocuments = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            SettingsFileStorageLocation = Path.Combine(MyDocuments, "IOStream");
            SettingsFileName = Path.Combine(SettingsFileStorageLocation, "Text1.Txt");
            if (!Directory.Exists(SettingsFileStorageLocation))
            {
                Directory.CreateDirectory(SettingsFileStorageLocation);
            }
            if (File.Exists(SettingsFileName))
            {
                using (StreamReader sr = new StreamReader(SettingsFileName))
                {
                    //VariableName=Value
                    while (!sr.EndOfStream)
                    {
                        string LineFromFile = sr.ReadLine();
                        string[] NameValuesArray = LineFromFile.Split('=');
                        if (NameValuesArray.Length == 2)
                        {
                            string NameOfVariable = NameValuesArray[0];
                            string ValueOfVariable = NameValuesArray[1];
                            if (!keyValuePairs.ContainsKey(NameOfVariable))
                            {
                                keyValuePairs.Add(NameOfVariable, ValueOfVariable);
                            }
                        }
                    }

                }
                foreach (string KeyName in keyValuePairs.Keys)
                {
                    combo_Name.Items.Add(KeyName);
                }
            }
        }

        private void VIEW_Click(object sender, EventArgs e)
        {

           using(StreamWriter sw = new StreamWriter(SettingsFileName))
            {
                foreach(string KeyName in keyValuePairs.Keys)
                {
                    sw.WriteLine(KeyName + "=" + keyValuePairs[KeyName]);
                }
            }

            //string UserEnteredVariableName = combo_Name.Text;
            //string UserEnteredValue = textBox1.Text;

            //if (keyValuePairs.ContainsKey(UserEnteredVariableName))
            //{
            //    keyValuePairs[UserEnteredVariableName] = UserEnteredValue;
            //}
            //else
            //{
            //    keyValuePairs.Add(UserEnteredVariableName, UserEnteredValue);
            //    combo_Name.Items.Add(UserEnteredVariableName);
            //}
        }

        private void Load_Click(object sender, EventArgs e)
        {
            string UserEnteredVariableName = combo_Name.Text;
            if (keyValuePairs.ContainsKey(UserEnteredVariableName))
            {
                string ValueOfVariable = keyValuePairs[UserEnteredVariableName];
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string UserEnteredVariableName = combo_Name.Text;
            string UserEnteredValue = textBox1.Text;
            if (keyValuePairs.ContainsKey(UserEnteredVariableName))
            {
                keyValuePairs[UserEnteredVariableName] = UserEnteredValue;    
            }
            else
            {
                keyValuePairs.Add(UserEnteredVariableName, UserEnteredValue);
                combo_Name.Items.Add(UserEnteredVariableName);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
