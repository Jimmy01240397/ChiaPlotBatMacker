using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Chia耕地腳本產生器
{
    public partial class Form1 : Form
    {
        //string[] name = new string[] { "FarmerPublicKey", "PoolPublicKey", "平行耕地數", "是否為每個平行耕地資料夾作區別", "耕地執行次數", "RAM(MB)", "Thread",  };
        List<Control> data;
        Dictionary<Button, TextBox> folderbutton;
        public Form1()
        {
            InitializeComponent();

            data = new List<Control>() { Knum, finger, fpk, ppk, fornum, checkBox1, timedelay, plotnum, ram, threadnum, bucketnum, temp1, temp2, finaldir, checkBox2 };
            folderbutton = new Dictionary<Button, TextBox>() { { button2, temp1 }, { button3, temp2 }, { button4, finaldir } };

            for (int i = 0; i < data.Count; i++)
            {
                string type = data[i].GetType().Name;
                switch (type)
                {
                    case "TextBox":
                        {
                            ((TextBox)data[i]).TextChanged += OnValueChanged;
                            break;
                        }
                    case "NumericUpDown":
                        {
                            ((NumericUpDown)data[i]).ValueChanged += OnValueChanged;
                            break;
                        }
                    case "CheckBox":
                        {
                            ((CheckBox)data[i]).CheckedChanged += OnValueChanged;
                            break;
                        }
                }
            }
        }

        string topath(string path)
        {
            if (path == "") return "";
            try
            {
                string outdata = Path.GetFullPath(path);
                if (outdata.Contains(" "))
                {
                    outdata = "\"" + outdata + "\"";
                }
                return outdata;
            }
            catch (Exception)
            {
                return "";
            }
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                string LocalAppdata = Environment.GetEnvironmentVariable("LocalAppdata");

                string foldername = "";

                foreach (string fname in Directory.GetFileSystemEntries(LocalAppdata + "\\chia-blockchain"))
                {
                    if (fname.Contains("app"))
                    {
                        foldername = Path.GetFileName(fname);
                    }
                }
                string data = "@echo off\r\n";
                data += "cd %LocalAppdata%\\chia-blockchain\\" + foldername + "\\resources\\app.asar.unpacked\\daemon\r\n";
                data += "for /l %%a in (1,1," + fornum.Value + ") do (\r\n";
                string thetemp1 = temp1.Text;
                string thetemp2 = temp2.Text;
                if (checkBox1.Checked && thetemp1 != "")
                {
                    thetemp1 = topath(Path.GetFullPath(thetemp1) + "\\%%a");
                    data += "mkdir " + thetemp1 + "\r\n";
                    if (thetemp2 != "")
                    {
                        thetemp2 = topath(Path.GetFullPath(thetemp2) + "\\%%a");
                        data += "mkdir " + thetemp2 + "\r\n";
                    }
                }

                data += "start chia plots create -k " + Knum.Value + (finger.Text == "" ? "" : " -a " + finger.Text) + " -f " + fpk.Text + " -p " + ppk.Text + " -n " + plotnum.Value + " -d " + topath(finaldir.Text) + " -t " + thetemp1 + (thetemp2 == "" ? "" : " -2 " + thetemp2) + " -b " + ram.Value + " -r " + threadnum.Value + " -u " + bucketnum.Value + (checkBox2.Checked ? " " : " -x") + "\r\n";
                data += "timeout /t " + timedelay.Value + "\r\n)";

                richTextBox1.Text = data;
            }
            catch(Exception)
            {

            }
        }

        private void OpenFolder(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            folderbutton[(Button)sender].Text = folderBrowserDialog1.SelectedPath;
        }

        private void SaveFile(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void SetArg(string input)
        {
            string[] getfiledata = input.Split('\n'); 

            checkBox1.Checked = input.Contains("mkdir");

            for (int a = 0; a < getfiledata.Length; a++)
            {
                if (getfiledata[a].Contains("for") || getfiledata[a].Contains("FOR"))
                {
                    string[] data = Stringstatic.TakeString(getfiledata[a], '(', ')');
                    for (int i = 0; i < data.Length; i++)
                    {
                        getfiledata[a] = getfiledata[a].Replace("(" + data[i] + ")", "{" + i + "}");
                    }

                    string[] alldata = getfiledata[a].Split(' ');

                    for (int i = 0; i < alldata.Length; i++)
                    {
                        switch (alldata[i])
                        {
                            case "in":
                                {
                                    i++;
                                    for (int k = 0; k < data.Length; k++)
                                    {
                                        if (alldata[i].Contains("{" + k + "}"))
                                        {
                                            int outdata = Convert.ToInt32(data[k].Split(',')[2]);
                                            if (outdata >= fornum.Minimum && outdata <= fornum.Maximum)
                                            {
                                                fornum.Value = outdata;
                                            }
                                        }
                                    }
                                    break;
                                }
                        }
                    }
                }
                else if (getfiledata[a].Contains("timeout"))
                {
                    string[] alldata = getfiledata[a].Split(' ');
                    for (int i = 0; i < alldata.Length; i++)
                    {
                        switch (alldata[i])
                        {
                            case "/t":
                                {
                                    i++;
                                    int data = Convert.ToInt32(alldata[i]);
                                    if (data >= timedelay.Minimum && data <= timedelay.Maximum)
                                    {
                                        timedelay.Value = data;
                                    }
                                    break;
                                }
                        }
                    }
                }
                else if (getfiledata[a].Contains("chia"))
                {
                    string[] path = Stringstatic.TakeString(getfiledata[a], '\"', '\"');
                    for (int i = 0; i < path.Length; i++)
                    {
                        getfiledata[a] = getfiledata[a].Replace("\"" + path[i] + "\"", "{" + i + "}");
                    }

                    string[] alldata = getfiledata[a].Split(' ');
                    for (int i = 0; i < alldata.Length; i++)
                    {
                        for (int k = 0; k < path.Length; k++)
                        {
                            if (alldata[i].Contains("{" + k + "}"))
                            {
                                alldata[i] = alldata[i].Replace("{" + k + "}", "\"" + path[k] + "\"");
                            }
                        }
                    }

                    checkBox2.Checked = Array.IndexOf(alldata, "-x") < 0;

                    for (int i = 0; i < alldata.Length; i++)
                    {
                        switch (alldata[i])
                        {
                            case "-k":
                                {
                                    i++;
                                    int data = Convert.ToInt32(alldata[i]);
                                    if (data >= Knum.Minimum && data <= Knum.Maximum)
                                    {
                                        Knum.Value = data;
                                    }
                                    break;
                                }
                            case "-a":
                                {
                                    i++;
                                    finger.Text = alldata[i];
                                    break;
                                }
                            case "-f":
                                {
                                    i++;
                                    fpk.Text = alldata[i];
                                    break;
                                }
                            case "-p":
                                {
                                    i++;
                                    ppk.Text = alldata[i];
                                    break;
                                }
                            case "-n":
                                {
                                    i++;
                                    int data = Convert.ToInt32(alldata[i]);
                                    if (data >= plotnum.Minimum && data <= plotnum.Maximum)
                                    {
                                        plotnum.Value = data;
                                    }
                                    break;
                                }
                            case "-d":
                                {
                                    i++;
                                    finaldir.Text = alldata[i];
                                    break;
                                }
                            case "-t":
                                {
                                    i++;
                                    temp1.Text = checkBox1.Checked ? Path.GetDirectoryName(alldata[i]) : alldata[i];
                                    break;
                                }
                            case "-2":
                                {
                                    i++;
                                    temp2.Text = alldata[i];
                                    break;
                                }
                            case "-b":
                                {
                                    i++;
                                    int data = Convert.ToInt32(alldata[i]);
                                    if (data >= ram.Minimum && data <= ram.Maximum)
                                    {
                                        ram.Value = data;
                                    }
                                    break;
                                }
                            case "-r":
                                {
                                    i++;
                                    int data = Convert.ToInt32(alldata[i]);
                                    if (data >= threadnum.Minimum && data <= threadnum.Maximum)
                                    {
                                        threadnum.Value = data;
                                    }
                                    break;
                                }
                            case "-u":
                                {
                                    i++;
                                    int data = Convert.ToInt32(alldata[i]);
                                    if (data >= bucketnum.Minimum && data <= bucketnum.Maximum)
                                    {
                                        bucketnum.Value = data;
                                    }
                                    break;
                                }
                        }
                    }
                }
            }
        }

        private void GetFile(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            SetArg(richTextBox1.Text);
        }
    }

    public static class Stringstatic
    {
        static int Matches(string input, char a)
        {
            string[] j = Split(input, a);
            return j.Length + 1;
        }

        public static string[] Split(string input, char a)
        {
            List<string> vs = new List<string>();
            int now = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '\\')
                {
                    i++;
                }
                else if (input[i] == a)
                {
                    vs.Add(input.Substring(now, i - now));
                    now = i + 1;
                }
            }
            vs.Add(input.Substring(now, input.Length - now));
            return vs.ToArray();
        }

        public static string FormattingString(string input)
        {
            StringBuilder stringBuilder = new StringBuilder(input);
            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if (stringBuilder[i] == '\\')
                {
                    stringBuilder.Remove(i, 1);
                }
            }
            return stringBuilder.ToString();
        }

        public static string[] TakeString(string text, char a, char b)
        {
            List<string> q = new List<string>(Split(text, b));
            if (a == b)
            {
                if (q.Count % 2 == 0)
                {
                    q.RemoveAt(q.Count - 1);
                }
                for (int i = 0; i < q.Count; i++)
                {
                    q.RemoveAt(i);
                }
                for (int i = 0; i < q.Count; i++)
                {
                    q[i] = FormattingString(q[i]);
                }
                return q.ToArray();
            }
            q.RemoveAt(q.Count - 1);
            for (int i = 0; i < q.Count;)
            {
                if (q[i] != "")
                {
                    if (Matches(q[i], a) != Matches(q[i], b) + 1)
                    {
                        q[i] += b.ToString() + q[i + 1];
                        q.RemoveAt(i + 1);
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    q[i - 1] += b.ToString();
                    q.RemoveAt(i);
                }
            }
            List<string> vs = new List<string>();
            foreach (string s in q)
            {
                int found = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '\\')
                    {
                        i++;
                    }
                    else if (s[i] == a)
                    {
                        found = i;
                        break;
                    }
                }
                if (found != -1)
                {
                    if (found + 1 == s.Length)
                    {
                        vs.Add("");
                    }
                    else
                    {
                        vs.Add(s.Substring(found + 1));
                    }
                }
            }
            return vs.ToArray();
        }

    }
}

