

using ProjectWork.Model;
using ProjectWork.Presenter;
using ProjectWork.View;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;


namespace ProjectWork
{
    public partial class Form1 : Form, IUserInfoView
    {
        private readonly UserInfoPresenter _presenter;

        public Form1()
        {
            InitializeComponent();
            _presenter = new UserInfoPresenter(this, new UserInfoRepository());
            DisplayRecords(_presenter.GetAllUserInfo());
        }


        public int UserId
        {
            get { return Convert.ToInt32(txtId.Text); }
            set { txtId.Text = value.ToString(); }
        }

        public string UserName {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }
        
        public string UserBookName
        {
            get { return txtBookName.Text; }
            set { txtBookName.Text = value; }
        }
        public string UserFaculty
        {
            get { return cbFaculty.Text; }
            set { cbFaculty.Text = value; }
        }
        public DateTime UserReturned
        {
            get { return dtReturned.Value; }
          
                set { dtReturned.Value = DateTime.Now; }
        }
        public string UserSearch
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }


        public void DisplayMessage(string message) => MessageBox.Show(message);
        public void DisplayError(string message) => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
       
        public void DisplayRecords(List<UserInfo> userInfoList) => dataGridView1.DataSource = userInfoList;


        private void btnInsert_Click(object sender, EventArgs e) => _presenter.InsertUser();
        private void btnUpdate_Click(object sender, EventArgs e) => _presenter.UpdateUser();
        private void btnDelete_Click(object sender, EventArgs e) => _presenter.DeleteUser();
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                txtId.Text = selectedRow.Cells["Id"].Value.ToString();
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtBookName.Text = selectedRow.Cells["BookName"].Value.ToString();
                cbFaculty.Text = selectedRow.Cells["Faculty"].Value.ToString();
                dtReturned.Value = Convert.ToDateTime(selectedRow.Cells["Returned"].Value);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => _presenter.SearchUser();

        private void btnReset_Click(object sender, EventArgs e) => _presenter.ClearUser();



    }
}
