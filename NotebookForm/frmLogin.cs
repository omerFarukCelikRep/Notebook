using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotebookForm
{
    public partial class frmLogin : Form
    {
        UserManager userManager;
        public frmLogin()
        {
            InitializeComponent();
            userManager = new UserManager(new EfUserDal());
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (userManager.LoginCheck(txtUserName.Text, txtPassword.Text))
                {
                    frmNotes frmNotes = new frmNotes();
                    frmNotes.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunamadı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }
    }
}
