using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPhanQuyen : Form
    {
        private int quyen;
        private string mads;
        public FormPhanQuyen(int quyen, string mads)
        {
            InitializeComponent();
            this.quyen = quyen;
            this.mads = mads;
        }

        private void FormPhanQuyen_Load(object sender, EventArgs e)
        {
            SetCheckedListBoxStateFromBitmask(quyen);
        }

        private int GetQuyen()
        {
            int bitmask = 0;
            for (int i = 0; i < listcheckquyen.Items.Count; i++)
            {
                if (listcheckquyen.GetItemChecked(i)) // Kiểm tra xem mục có được chọn hay không
                {
                    bitmask |= (1 << i); // Đặt bit tương ứng
                }
            }
            return bitmask;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool result = TaiKhoanBUS.Instance.UpdateQuyen(mads, GetQuyen());

            if(result)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetCheckedListBoxStateFromBitmask(int bitmask)
        {
            for (int i = 0; i < listcheckquyen.Items.Count; i++)
            {
                bool isChecked = (bitmask & (1 << i)) != 0; // Kiểm tra bit
                listcheckquyen.SetItemChecked(i, isChecked); // Thiết lập trạng thái
            }
        }
    }
}
