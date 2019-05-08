using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class faccountprofile : Form
    {
        private AccountDTO loginAccount;

        public AccountDTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public faccountprofile(AccountDTO acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        void ChangeAccount(AccountDTO acc)
        {
            tbUserName.Text = LoginAccount.UserName;
            tbDisplayName.Text = LoginAccount.DisplayName;
        }

        void UpdateAccountInfo()
        {
            string displayName = tbDisplayName.Text;
            string password = tbPassword.Text;
            string newpass = tbnewpass.Text;
            string reenterPass = tbrepass.Text;
            string userName = tbUserName.Text;

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                if (Account.Instance.UpdateAccount(userName, displayName, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(Account.Instance.GetAccountByUserName(userName)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khấu");
                }
            }
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fAccountProfile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void fexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fupdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbrepass_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class AccountEvent : EventArgs
    {
        private AccountDTO acc;

        public AccountDTO Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public AccountEvent(AccountDTO acc)
        {
            this.Acc = acc;
        }
    }
}
