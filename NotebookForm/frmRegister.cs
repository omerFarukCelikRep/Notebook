using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
    public partial class frmRegister : Form
    {
        UserManager userManager;
        public frmRegister()
        {
            InitializeComponent();
            userManager = new UserManager(new EfUserDal());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == txtPasswordAgain.Text)
                {
                    userManager.Add(new User
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        UserName = txtUserName.Text,
                        Password = new Password { UserPassword = txtPassword.Text },
                        IsActive = false

                    }); 
                }
                else
                {
                    MessageBox.Show("Girdiğiniz Şifreler eşleşmemektedir. Lütfen Kontrol Ediniz!");
                }

    }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
