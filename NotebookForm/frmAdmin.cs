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
    public partial class frmAdmin : Form
    {
        UserManager userManager;
        public frmAdmin()
        {
            InitializeComponent();
            userManager = new UserManager(new EfUserDal());
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            foreach (var item in userManager.GetAll())
            {
                lvi.SubItems.Add(item.FirstName);
                lvi.SubItems.Add(item.LastName);
                lvi.SubItems.Add(item.UserName);
                lvi.SubItems.Add(item.IsActive == true ? "Aktif" : "Pasif");
                lvUsers.Items.Add(lvi);
            }
        }

        private void lvUsers_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
