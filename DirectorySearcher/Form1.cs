using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectorySearcher
{
    public partial class Form1 : Form
    {
        string paramOne;
        string paramTwo;
        string paramThree;
        string[] directories = Directory.GetDirectories("C:\\");
        string[] files = Directory.GetFiles("C:\\", "*.dll");



        public Form1()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            paramOne = searchOne.Text;
            paramTwo = searchTwo.Text;
            paramThree = searchThree.Text;


            string[] allDocuments = Directory.GetFiles(@"C:\Users\Documents");


            //foreach (var item in allDocuments)
            //{


            //    var fileExtensions = item.Split('.');

            //    if(fileExtensions[fileExtensions.Length - 1] == ".doc" || 
            //        fileExtensions[fileExtensions.Length - 1] == ".docx" )
            //    {
            //      doc.SaveAsPDF(pathToSave);
            //    }


            //    //filesBox.Items.Add(item.ToString());
            //}
        }

        void DirSearch(string[] myDirect)
        {
            try
            {
                //string[] fileEntrys = Directory.GetFiles(myDirect);
                foreach (var item in myDirect)
                {
                    if (item.Contains(paramOne))
                    {
                        ProcessFile(item);
                    }

                }

                //string[] subDirectories = Directory.GetDirectories(myDirect);
                //foreach (var subDirect in subDirectories)
                //{
                //    DirSearch(subDirect);
                //}

            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        void ProcessFile(string fileName)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);
            while ((line = file.ReadLine()) != null)
            {
                filesBox.Items.Add(line);
                counter++;
            }

            file.Close();

        }

        private void filesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filePathView.Text = filesBox.SelectedItem.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
