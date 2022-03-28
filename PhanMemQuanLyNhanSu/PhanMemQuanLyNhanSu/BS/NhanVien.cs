using System.Data;

using PhanMemQuanLyNhanSu.DB;

namespace PhanMemQuanLyNhanSu.BS
{
    class NhanVien
    {
        DBMain db = null;
        
        public NhanVien()
        {

            db = new DBMain();
            
        }
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("select * from NhanVien", CommandType.Text);
        }

        public bool ThemNhanVien(string MaNV,string TenNV, string NgSinh,string Phai, string DChi, string Phong, string CMND, string GhiChu, ref string error)
        {
            //string sqlString = "Insert Into NhanVien Values('" + MaNV + "',N'" + TenNV + "','" + NgSinh + "',N'" + Phai + "',N'" + DChi + "',N'" + Phong + "','" + CMND + "',N'" + CongViec + "','" + Luong + "',N'" + GhiChu + "','" + LoaiNV + "')";
            string sqlString = "Insert Into NhanVien Values('" + MaNV + "',N'" + TenNV + "','" + NgSinh + "',N'" + Phai + "',N'" + DChi + "',N'" + Phong + "','" + CMND + "',N'" + GhiChu + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool CapNhatNhanVien(string MaNV, string TenNV, string NgSinh, string Phai, string DChi, string Phong, string CMND, string GhiChu, ref string error)
        {
            string sqlString =
               "Update NhanVien Set HoTenNV=N'" + TenNV + "', NgaySinh='" + NgSinh + "',GioiTinh=N'"+Phai+"' ,Diachi=N'"+DChi+"'," +
               "Phong=N'"+Phong+"',CMND='"+CMND+"', GhiChu=N'"+GhiChu+ "' Where MaNV='" + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool XoaNhanVien(string MaNV ,ref string error)
        {
            string sqlString = "Delete From NhanVien Where MaNV='" + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool KiemTraTonTai(string MaNV,ref string error)
        {
            string sqlString = "Select Count(*) From NhanVien Where MaNV=N'" + MaNV.Trim() + "'";
            return db.Check(sqlString, CommandType.Text, ref error);
        }
    }
}
