using System;
using System.Windows.Forms;

namespace PhanMemQuanLyNhanSu
{
    public partial class FormMain : Form
    {
        public static bool isDangNhap = false;
        public static string user_current = "";
        clsResize _form_resize;
        public FormMain()
        {
            InitializeComponent();
            _form_resize = new clsResize(this);
            this.Load += _Load;
            this.Resize += _Resize;
        }
        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form dangnhap = new FormDangNhap();
            this.Hide();
            dangnhap.ShowDialog();
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if(isDangNhap==false)
            {
                đăngNhậpToolStripMenuItem.Enabled = true;
                đăngXuấtToolStripMenuItem.Enabled = false;
                danhMụcToolStripMenuItem.Enabled = false;
                cậpNhậtTàiKhoảnToolStripMenuItem.Visible = false;
                btnNhanVien.Enabled = false;      
                btnPhongBan.Enabled = false;
                btnLuong.Enabled = false;
                btnChamCong.Enabled = false;
                btnCheDo.Enabled = false;
            }
            else
            {
                đăngXuấtToolStripMenuItem.Enabled = true;
                danhMụcToolStripMenuItem.Enabled = true;
                btnNhanVien.Enabled = true;
                btnPhongBan.Enabled = true;
                btnLuong.Enabled = true;
                btnChamCong.Enabled = true;
                btnCheDo.Enabled = true;
                đăngNhậpToolStripMenuItem.Enabled = false;
                cậpNhậtTàiKhoảnToolStripMenuItem.Visible = true;
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form nv = new FormNhanVien();
            //this.Hide();
            nv.ShowDialog();
            //this.Close();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pb = new FormPhongBan();
            //this.Hide();
            pb.ShowDialog();
            //this.Close();
        }

        private void dựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {               
        }

        private void phânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {          
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {        
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {           
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            Form nv = new FormNhanVien();
            //this.Hide();
            nv.ShowDialog();
            //this.Close();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            Form pb = new FormPhongBan();
            //this.Hide();
            pb.ShowDialog();
            //this.Close();
        }

        private void btnDuAn_Click(object sender, EventArgs e)
        {
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            //Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //Kiểm tra có nhấp chọn nút ok không?
            if (traloi == DialogResult.OK) this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDangNhap = false;
            FormMain_Load(sender,e);
        }

        private void cậpNhậtTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cc = new FormCapNhatTaiKhoan();
            cc.ShowDialog();
        }

        private void btnCheDo_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form cc = new FormCheDo();
            cc.ShowDialog();
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            Form cc = new FormLuong();
            cc.ShowDialog();
        }

        private void btnChamCong_Click_1(object sender, EventArgs e)
        {
            Form cc = new FormChamCong();
            cc.ShowDialog();
        }

        private void lươngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form form = new FormLuong();
            form.ShowDialog();      
        }

        private void chấmCôngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form form = new FormChamCong();
            form.ShowDialog();
        }

        private void chếĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormCheDo();
            form.ShowDialog();
        }
    }
}
