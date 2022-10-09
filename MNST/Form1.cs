using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MNST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dtgvData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgvData_DataError);
           

        }
        #region Global Varible
        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-FAMD6FDU\PHAMHAO;Initial Catalog=MNST;Integrated Security=True");
       string[] nganh = { "Công nghệ thông tin", "Marketing", "Quản trị kinh doanh", "Ngôn ngữ anh" };
        #endregion
        #region Methods
        void AddCmb()
        {

            //SqlCommand cmd = new SqlCommand("select facultyName from FACULTY", cnn);
            //cmbfac.DisplayMember = "FacultyName";
            //SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            //DataTable dt2 = new DataTable();
            //cmbfac.DataSource = dt2;
        }
        void AddDataGV()
        {


            string sql = "select Student_ID,FullName,Gender,Addresss,AvgScore,FacultyName\r\nfrom STUDENT,FACULTY\r\nwhere STUDENT.Faculty_ID = FACULTY.Faculty_ID";
            //string sql = "select Student_ID,FullName,STUDENT.Faculty_ID,FacultyName\r\nfrom STUDENT,FACULTY\r\nwhere STUDENT.Faculty_ID = FACULTY.Faculty_ID";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            dtgvData.DataSource = dt;
        }
        private void connectDatabase()
        {
            cnn.Open();
           AddCmb();
            AddDataGV();
           
        }
        void LoadData()
        {
            using (ModelMNST context = new ModelMNST())
            {
                var rs = context.STUDENT;
                dtgvData.DataSource = rs.ToList();
            }
            connectDatabase();
        }   
      
        void Add()
        { 
            using (ModelMNST context = new ModelMNST())
            {
                var stu = new STUDENT();
            
                    stu.Student_ID = txtid.Text;
                    stu.FullName = txtname.Text;
                    stu.AvgScore = float.Parse(txtavgscore.Text);
                    stu.Addresss = txtaddress.Text;
                    stu.Faculty_ID = cmbfac.SelectedIndex + 1;

                    if (rdbMale.Checked == true)
                    {
                        stu.Gender = rdbMale.Text;
                    }

                    else if (rdbFemale.Checked == true)
                    {
                        stu.Gender = rdbFemale.Text;
                    }
                    else
                    {
                        stu.Gender = rdbMore.Text;
                    }
                    context.STUDENT.Add(stu);
                    context.SaveChanges();
                //    LoadData();
                    ClearInput();
                    MessageBox.Show("Thêm thành công!!", "thông báo");
                
            } 
        }

        void Del()
        {
            using(ModelMNST context = new ModelMNST())
            {
                var stu = context.STUDENT.First(p =>p.Student_ID == txtid.Text);
              
                context.STUDENT.Remove(stu);
                context.SaveChanges();
               // LoadData();
                ClearInput();
            }
            MessageBox.Show("Xóa thành công!!", "thông báo");
        }
        void Edit()
        {
            using (ModelMNST context = new ModelMNST())
            {
                var s = context.STUDENT.First(p => p.Student_ID == txtid.Text);

                string name = txtname.Text;
                if (name == "")
                {
                    name = s.FullName;
                }
                else
                {
                    s.FullName = txtname.Text;

                }
                string score = (txtavgscore.Text.ToString());
                if (score == "")
                {
                    score = s.AvgScore.ToString();
                }
                else
                {
                    s.AvgScore = float.Parse(txtavgscore.Text);
                }

                string addres = txtaddress.Text;
                if (addres == "")
                {
                    addres = s.Addresss;
                }
                else
                {
                    s.Addresss = txtaddress.Text;

                }

                string m = rdbMale.Text;
                if (rdbMale.Checked == false)
                {
                    m = s.Gender;
                }    
                else
                {
                    s.Gender = rdbMale.Text;
                }

                string f = rdbFemale.Text;
                if (rdbFemale.Checked == false)
                {
                    m = s.Gender;
                }
                else
                {
                    s.Gender = rdbFemale.Text;
                }
                string mor = rdbMore.Text;
                if (rdbMore.Checked == false)
                {
                    m = s.Gender;
                }
                else
                {
                    s.Gender = rdbMore.Text;
                }


               int n = cmbfac.SelectedIndex+1;
                if(n ==0)
                {
                    n = s.Faculty_ID;
                }   
                else
                {
                    s.Faculty_ID = cmbfac.SelectedIndex + 1;
                }
                context.SaveChanges();   
           //     LoadData();
                ClearInput();
            }
       }
  

        void Search()
        {

            using (ModelMNST context = new ModelMNST())
            {
                var stu = context.STUDENT.Where(p => p.Student_ID == txtid.Text).ToList();
                dtgvData.DataSource = stu;
                var s = context.STUDENT;
                //dtgvData.DataSource = s;
             //   Edit();
                context.SaveChanges();
                ClearInput();
             
            }

        }
        
        void ClearInput()
        {
            txtname.Text = txtid.Text = txtaddress.Text = txtavgscore.Text = cmbfac.Text = "";
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            rdbMore.Checked = false;
        }
        #endregion
        #region Event
       
        private void Form1_Load(object sender, EventArgs e)
        {
           cmbfac.Items.AddRange(nganh);

            LoadData();
    
        }
     

        private void dtgvData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntDel_Click(object sender, EventArgs e)
        {
            Del();
            
        }

        private void dtgvData_SelectionChanged(object sender, EventArgs e)
        {
           if(dtgvData.SelectedRows.Count > 0)
            {
               
                txtid.Text = dtgvData.SelectedRows[0].Cells[0].Value.ToString();  
                txtname.Text = dtgvData.SelectedRows[0].Cells[1].Value.ToString();
                txtaddress.Text = dtgvData.SelectedRows[0].Cells[3].Value.ToString();
                txtavgscore.Text = dtgvData.SelectedRows[0].Cells[4].Value.ToString();
                cmbfac.Text = dtgvData.SelectedRows[0].Cells[5].Value.ToString(); 
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
            
        }

        private void cmbfac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }    
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Search();
           
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            LoadData();
           
        }

    }
    #endregion
}
