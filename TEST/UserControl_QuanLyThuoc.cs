using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class UserControl_QuanLyThuoc : UserControl
    {
        public UserControl_QuanLyThuoc()
        {
            InitializeComponent();
        }

        private void UserControl_QuanLyThuoc_Load(object sender, EventArgs e)
        {

        }

        private void UserControl_QuanLyThuoc_Resize(object sender, EventArgs e)
        {
            int x;
            int y;
            int z;
            int k;
            x = this.Width - txtTimKiem.Width;
            y = this.Width - txtTimKiem.Width - btnDelete.Width;
            z = this.Width - txtTimKiem.Width - btnDelete.Width - btnEdit.Width;
            k = this.Width - txtTimKiem.Width - btnDelete.Width - btnEdit.Width - btnAdd.Width;
            txtTimKiem.Location = new Point(x, txtTimKiem.Location.Y);
            btnDelete.Location = new Point(y, btnDelete.Location.Y);
            btnEdit.Location = new Point(z, btnEdit.Location.Y);
            btnAdd.Location = new Point(k, btnAdd.Location.Y);
        }

        private void txtTimKiem_OnTextChange(object sender, EventArgs e)
        {

        }
    }
}
