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

namespace DataTableForrm
{
    public partial class frmEmp : Form
    {
        public frmEmp()
        {
            InitializeComponent();
        }

        DataTable tblEmp = new DataTable("Employee");                                           // انشاء الجدول تحديد الاسم لة
        string FolderDataName = "data";                                                         // تجهيز اسم المجلد داخل متغير
        string fileNameSchema = "emp_s.xml";                                                    // تجهيز اسم ملف الاسكيما داخل متغير
        string fileNameData = "emp.xml";                                                        // تجهيز اسم ملف البيانات داخل متغير

        private void createEmpTable()
        {
            if (tblEmp.Columns.Count < 1)                                                       // التحقق من وجود اعمدة مسبقا او لا
            {
                tblEmp.Columns.Add("Number", typeof(int));                             // انشاء عمود وتسميتة وتحديد نوعة 
                tblEmp.Columns.Add("Name", typeof(string));                            // انشاء عمود وتسميتة وتحديد نوعة
                tblEmp.Columns.Add("Address", typeof(string));                                  // انشاء عمود وتسميتة وتحديد نوعة
                tblEmp.Columns.Add("Salary", typeof(int));                                      // انشاء عمود وتسميتة وتحديد نوعة

                tblEmp.Constraints.Add("emp_pk",tblEmp.Columns["Number"],true);        // انشاء حقل (primary key)

            }
        }

        private void clearData(Panel form) 
        {
            foreach (Control c in form.Controls)                                                // البحث فى جميع الادوات داخل هذة البنيل    
            {
                if (c is TextBox)                                                               // التحقق اذا كانت الادة مربع نص او لا
                {
                    ((TextBox)c).Clear();                                                       // مسح البيانات من مربع النص
                }
            }                                                                         
            autoNumber();

            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            lblResult.Text = "Result: " + dgvSearch.Rows.Count + " Row(s)";
            txtEmpName.Focus();                                                                                 // التركيز على اسم الموظف
            txtEmpName.Select();                                                                                // تحديد اسم الموظف للكتابة فية

        }

        private void autoNumber() 
        {
            int intAutoNum;
            if (tblEmp.Rows.Count < 1)                                                                          // التحقق من وجود صفوف فى الجدول
            {
                intAutoNum =1;                                                                               // اضافة اول قيمة 
            }
            else
            {
                intAutoNum = Convert.ToInt32(tblEmp.Compute("max(Number)", "")) + 1;                      // ارجاع اكبر قيمة فى الجدول و اضافة عليها واحد
                                                                                                         // اضافة القيمة بعد الزيادة على الكبر قيمة بواحد
            }
            txtEmpNum.Text = intAutoNum.ToString();

        }

        private void createFolderData()
        {
            if (!Directory.Exists(FolderDataName)) Directory.CreateDirectory(FolderDataName);                   // التحقق من انشاء مجلد البيانات اوذا لم يكن موجود يقوم بالانشاء 
        }
       
        private bool checkEmpFile() 
        {
            if (File.Exists(FolderDataName + "/" + fileNameSchema) && File.Exists(FolderDataName + "/" + fileNameData))     // التحقق من وجود الملفات داخل المجلد
                return true;
            else
                return false;
        }

        private bool checkTextBox() 
        {
            bool ok = true;
            if (txtEmpNum.Text.Trim() == "")                                                    //التحقق من مربع الرقم ليس فارغا
            {
                ok = false;
                Tools.msgBox("Number is Empty!!, press on New");

            }
            else if (txtEmpName.Text.Trim() == "")                                              //التحقق من مربع الاسم ليس فارغا
            {
                ok = false;
                Tools.msgBox("Name is Empty!!");
                txtEmpName.Focus(); 
                txtEmpName.Select();

            }
            else if (txtAddress.Text.Trim() == "")                                              //التحقق من مربع العنوان ليس فارغا
            {
                ok = false;
                Tools.msgBox("Address is Empty!!");
                txtAddress.Focus();
                txtAddress.Select();

            }
            else if (txtSalary.Text.Trim() == "")                                              //التحقق من مربع المرتب ليس فارغا
            {
                ok = false;
                Tools.msgBox("Salary is Empty!!");
                txtSalary.Focus();
                txtSalary.Select();

            }

            return ok;
        }

        private void saveEmpFile() 
        {
            createEmpTable();
            createFolderData();
            tblEmp.WriteXmlSchema(FolderDataName + "/" + fileNameSchema);                                       // لحفظ ملف الاسكيما داخل المجلد
            tblEmp.WriteXml(FolderDataName + "/" + fileNameData);                                               // لحفظ ملف البيانات داخل المجلد
        }

        private void readEmpFile()
        {
            if (checkEmpFile())
            {
                tblEmp.ReadXmlSchema(FolderDataName + "/" + fileNameSchema);                                    // لقراءة ملف الاسكيما داخل المجلد
                tblEmp.ReadXml(FolderDataName + "/" + fileNameData);                                            // لقراءة ملف البيانات داخل المجلد
            }
        }

        private DataRow findRow(string employeeNumber)
        {
            int intNumWithNumber = Tools.getNumberOnly(employeeNumber); // ادخال رقم الموظف للبحث عنة
            DataRow row = tblEmp.Rows.Find(intNumWithNumber);           // تحديد الصف بدلالة رقم الموظف
            return row;
        }

        private void frmEmp_Load(object sender, EventArgs e)
        {
            
            createFolderData();
            if (checkEmpFile())                                                                                 // التحقق اولا اذا كان الملف موجود عند فتح البرنامج
            {
                readEmpFile();
            }
            else 
            {
                saveEmpFile();
            }
            dgvSearch.DataSource = tblEmp;                                                                      // تحديد مصدر البايانات لداتا جريد فيو ليكون الجدول
            clearData(panelData);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearData(panelData);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkTextBox()) 
            {
                int strNum = Convert.ToInt32(txtEmpNum.Text);
                string strName = txtEmpName.Text;
                string strAddress = txtAddress.Text;
                int strSalary = Convert.ToInt32(txtSalary.Text);

                tblEmp.Rows.Add(strNum, strName, strAddress, strSalary);                                    // اضافة البيانات فى الجدول
                saveEmpFile();
                dgvSearch.DataSource = tblEmp;
                clearData(panelData);
            }

        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '0'|| e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8' || e.KeyChar == '9' || e.KeyChar == '\b')) //حتى لا يتم ادخال حروف او رموز مع الارقام عند الضغط على ازار الكيبورد
            {
                e.Handled = true;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int intNumWithNumber = Tools.getNumberOnly(Tools.inputBox("Enter employe number", "Enter employee number: ")); // ظهور فورم لادخال فيها رقم الموظف للبحث عنة
            DataRow row = findRow(intNumWithNumber.ToString());                                                                        // تحديد الصف بدلالة رقم الموظف
            if (row == null)
            {
                Tools.msgBox("Number not found!!");
            }
            else 
            {
                txtEmpNum.Text = row["Number"].ToString();
                txtEmpName.Text = row["Name"].ToString();
                txtAddress.Text = row["Address"].ToString();
                txtSalary.Text = row["Salary"].ToString();

                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        
        }

        private void dgvSearch_SelectionChanged(object sender, EventArgs e)  // حدث عند اختيار احد الصفوف
        {
            if (dgvSearch.CurrentRow != null)                                // التحقق من عدم فراغ الصف
            {
                txtEmpNum.Text = dgvSearch.CurrentRow.Cells[0].Value.ToString();        // ارجاع بيانات الصف المختار الحقل الاول منة
                txtEmpName.Text = dgvSearch.CurrentRow.Cells[1].Value.ToString();       // ارجاع بيانات الصف المختار الحقل الثانى منة
                txtAddress.Text = dgvSearch.CurrentRow.Cells[2].Value.ToString();       // ارجاع بيانات الصف المختار الحقل الثالث منة
                txtSalary.Text = dgvSearch.CurrentRow.Cells[3].Value.ToString();        // ارجاع بيانات الصف المختار الحقل الرابع منة

                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkTextBox()) 
            {
                DataRow row = findRow(txtEmpNum.Text);          //تحديد الصف لتغير بياناتة
                row["Name"] = txtEmpName.Text;                  // تغير بيانات الاسم
                row["Address"] = txtAddress.Text;               // تغير بيانات العنوان
                row["Salary"] = txtSalary.Text;                 // تغير بيانات المرتب
                saveEmpFile();                                  // حفظ البيانات فى ملف xml
                clearData(panelData);                           // مسح البيانات من مربع النص
            }
            
        }

        private void dgvSearch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvSearch_SelectionChanged(sender, null);        // لتنفيذ الحدث هنا ايضا
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Tools.yesOrNo("Do you want to delete  this employee?")) 
            {
                DataRow row = findRow(txtEmpNum.Text);          //تحديد الصف لمسح بياناتة
                row.Delete();                                   // حذف الصف
                saveEmpFile();                                  // حفظ البيانات فى ملف xml
            }
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataRow[] rows = null;
            DataTable tblSearch = new DataTable();                          // انشاء جدول لوضع فية نتائج البحث
            foreach (DataColumn col in tblEmp.Columns)                      // 
            {
                tblSearch.Columns.Add(col.ColumnName, col.DataType);        // انشاء عمدان  فى  جدول البحث مثل جدول الموظفين
            }
            if (txtSearch.Text.Trim() == "") 
            {
                rows = tblEmp.Select();
            }
            else if (rdoNum.Checked)                      //اذا كان الاختيار البحث برقم الموظف
            {
                int numSearch = Tools.getNumberOnly(txtSearch.Text);         // استخلاص الارقام فقط من مربع البحث
                rows = tblEmp.Select("Number =" + numSearch);                  // ثم اضف داخل مصفوفة الصفوف ناتج البحث 
            }
            else if (rdoName.Checked)               //اذا كان الاختيار البحث باسم الموظف
            {
                rows = tblEmp.Select("Name like'%" + txtSearch.Text + "%'");

            }
            else if (rdoAddress.Checked)            //اذا كان الاختيار البحث بعنوان الموظف
            {
                rows = tblEmp.Select("Address like'%" + txtSearch.Text + "%'");
            }
            else if (rdoGreaderThan.Checked)
            {
                int numSearch = Tools.getNumberOnly(txtSearch.Text);         // استخلاص الارقام فقط من مربع البحث
                rows = tblEmp.Select("Salary >" + numSearch);
            }
            else if (rdoLessThan.Checked)
            {
                int numSearch = Tools.getNumberOnly(txtSearch.Text);         // استخلاص الارقام فقط من مربع البحث
                rows = tblEmp.Select("Salary <" + numSearch);
            }
            else if (rdoSalary.Checked)             //اذا كان الاختيار البحث بمرتب الموظف
            {
                int numSearch = Tools.getNumberOnly(txtSearch.Text);         // استخلاص الارقام فقط من مربع البحث
                rows = tblEmp.Select("Salary =" + numSearch);                  // ثم اضف داخل مصفوفة الصفوف ناتج البحث  
            }
            
            foreach (DataRow row in rows)                      // 
            {
                tblSearch.ImportRow(row);        // انشاء عمدان  فى  جدول البحث مثل جدول الموظفين
            }

            dgvSearch.DataSource = tblSearch;
            
            clearData(panelData);

        }

        private void chechRadioSearch() 
        {
            if (!rdoLessThan.Checked && !rdoGreaderThan.Checked)
            {
                rdoLessThan.Visible = rdoSalary.Checked;
                rdoGreaderThan.Visible = rdoSalary.Checked;
            }
        }

        private void rdoSalary_CheckedChanged(object sender, EventArgs e)
        {
            chechRadioSearch();


        }
    }
}
