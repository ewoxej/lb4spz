using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4SPZ
{
    public partial class Form1 : Form
    {
        private List<int> fileData;
        public Form1()
        {
            InitializeComponent();
            fileData = new List<int>();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            fileData.Clear();
            for (int i=0;i<100;i++)
            {
                fileData.Add(random.Next(1000));
            }
            text_content.Text = string.Join(" ", fileData);
            btn_save.Enabled = true;
            text_path.Text = string.Empty;
            btn_exch.Enabled = true;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
                text_content.Text = fileContent;
                if (!openFileDialog.FileName.Equals(string.Empty))
                {
                    text_path.Text = openFileDialog.FileName;
                    string[] str_arr = fileContent.Split(' ').ToArray();
                    foreach (var i in str_arr)
                    {
                        fileData.Add(int.Parse(i));
                    }
                }
                btn_exch.Enabled = true;
            }

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = saveFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = saveFileDialog.OpenFile();
                    using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileStream))
                    {
                        writer.Write(text_content.Text.ToString());
                    }
                }
                if(!saveFileDialog.FileName.Equals(string.Empty))
                text_path.Text=saveFileDialog.FileName;
            }
        }

        private void btn_exch_Click(object sender, EventArgs e)
        {
            int maxindex=0, minindex=0,min=fileData[0],max=fileData[0];
            for(int i=0;i<fileData.Count;i++)
            {
                if (fileData[i] > max)
                {
                    max = fileData[i];
                    maxindex = i;
                }
                else if (fileData[i] < min) 
                {
                    min = fileData[i];
                    minindex = i;
                }

            }
            fileData[minindex] = max;
            fileData[maxindex] = min;
            text_content.Text = string.Join(" ", fileData);
        }
    }
}
