using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace DataTableForrm
{
    ///<sumary>
    ///ملاحظات تظهر اسناء استعمال اي شيئ
    ///</sumary>
    public class Tools
    {
        /// <summary>
        /// هذة الدالة تقوم بانشاء مجلد جديد
        /// </summary>
        /// <param name="Path">مسار المجلد المراد انشاؤة</param>
        public static void createFolder(string Path)
        {
            if (!Directory.Exists(Path))
                Directory.CreateDirectory(Path);
            else Console.WriteLine(Path + " Is Exists");

        }

        public static void createFolders(string[] paths)
        {
            foreach (string folder in paths)
            {
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                else Console.WriteLine(folder + " Is Exists");
            }

        }
        public static void createFile(string Path)
        {
            if (!File.Exists(Path))
                File.Create(Path).Close();
            else Console.WriteLine(Path + " IS Exists");

        }
        public static void createFiles(string[] Paths)
        {

            foreach (string s in Paths)
            {
                if (!File.Exists(s)) File.Create(s).Close();
                else Console.WriteLine(s + " IS Exists");
            }
        }
        public static void createDataFile(string Path, string[] Lines)
        {
            StreamWriter sw = new StreamWriter(Path, true);
            foreach (string line in Lines)
            {
                sw.WriteLine(line);
            }
            sw.Close();
        }
        public static void createDataFiles(string[] Path, string[][] AllLines)
        {
            for (int x = 0; x < Path.Count(); x++)
            {
                createDataFile(Path[x], AllLines[x]);
            }



        }
        public static int getNumberOnly(string Text)
        {
            string NewText = "";
            foreach (char c in Text.ToCharArray())
            {

                if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                {
                    NewText += c;
                }


            }
            if (NewText == "") NewText = "0";
            int NewInt = Convert.ToInt32(NewText);
            return NewInt;

        }
        public static string inputBox(string Title, string Text, bool IsPassword = false)
        {
            Form frm = new Form();
            Label lblHader = new Label();
            TextBox txt = new TextBox();
            Button btnOk = new Button();
            Button btnClose = new Button();

            // frm
            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.BackColor = Color.White;
            frm.ControlBox = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Text = Title;
            frm.Font = new Font("Arial", 14, FontStyle.Bold);
            frm.Size = new Size(400, 190);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((Screen.PrimaryScreen.Bounds.Width - frm.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - frm.Height) / 2);

            // lblHeder
            lblHader.Text = Text;
            lblHader.AutoSize = true;
            lblHader.Location = new Point(10, 10);

            // txt
            if (IsPassword) txt.PasswordChar = '×';
            txt.Location = new Point(10, 45);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Width = frm.Width - 40;

            // btnOk
            btnOk.Location = new Point(75, txt.Top + txt.Height + 25);
            btnOk.Text = "Ok";
            btnOk.AutoSize = true;
            btnOk.Cursor = Cursors.Hand;
            btnOk.FlatStyle = FlatStyle.Popup;
            btnOk.BackColor = Color.Navy;
            btnOk.ForeColor = Color.White;

            // btnClose
            btnClose.Location = new Point(btnOk.Left + btnOk.Width + 30, txt.Top + txt.Height + 25);
            btnClose.Text = "Cancel";
            btnClose.AutoSize = true;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.BackColor = Color.Navy;
            btnClose.ForeColor = Color.White;



            frm.Controls.Add(lblHader);
            frm.Controls.Add(txt);
            frm.Controls.Add(btnOk);
            frm.Controls.Add(btnClose);

            // txt.event
            txt.KeyDown += delegate (Object mySander, KeyEventArgs mye)
            {
                if (mye.KeyCode == Keys.Enter)
                    btnOk.PerformClick();
            };

            // btnClose.event
            btnClose.Click += delegate {
                frm.Close();
            };
            string Textfromtxt = "";

            // btnOk.event
            btnOk.Click += delegate {
                Textfromtxt = txt.Text;
                frm.Close();
            };

            frm.ShowDialog();
            return Textfromtxt;
        }
        public static void msgBox(string Text, string Caption = "")
        {
            MessageBox.Show(Text, Caption);

        }
        public static bool yesOrNo(string Text, string Caption = "")
        {
            DialogResult di = MessageBox.Show(Text, Caption, MessageBoxButtons.YesNo);
            if (di == DialogResult.Yes) return true;
            else return false;
        }








        public string getStrArray(string[] StrArray, string sign)
        {
            string strArray = "";
            foreach (string s in StrArray)
            {
                strArray += s + sign;
            }
            return strArray;

        }

        public int[] getCalcTwoArray(int[] Array1, int[] Array2, char Ope)
        {
            if (Array1.Count() != Array2.Count())
            {
                Console.WriteLine("Error!! \nthere Are Not Equal");
                return new int[] { 0 };

            }
            else
            {
                int[] Array3 = new int[Array1.Count()];

                for (int x = 0; x < Array3.Count(); x++)
                {
                    switch (Ope)
                    {
                        case '+': Array3[x] = Array1[x] + Array2[x]; break;
                        case '-': Array3[x] = Array1[x] - Array2[x]; break;
                        case '*': Array3[x] = Array1[x] * Array2[x]; break;
                        case '/': if ((Array2[x]) == 0) Array2[x] = 1; Array3[x] = Array1[x] / Array2[x]; break;
                        case '%': if ((Array2[x]) == 0) Array2[x] = 1; Array3[x] = Array1[x] % Array2[x]; break;
                        default: Console.WriteLine("Your Chooes are not Currect "); break;
                    }


                }
                return Array3;
            }

        }

        public static void clearData(Panel form) 
        {
            foreach (Control c in form.Controls ) 
            {
                if (c is TextBox) 
                {
                    ((TextBox)c).Clear();
                }
            }
        
        }

    }
}
