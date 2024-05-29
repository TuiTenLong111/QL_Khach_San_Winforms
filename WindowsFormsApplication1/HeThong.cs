using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace QL_Khach_San_Backend
{
    public class HeThong
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCS"].ConnectionString);
        public DataSet ds = new DataSet();
        public DataView dtv_Khach = new DataView();
        public DataView dtv_LoaiPhong = new DataView();
        public DataView dtv_Phong = new DataView();
        public DataView dtv_Phong_LoaiPhong = new DataView();
        public DataView dtv_NhanVien = new DataView();
        public DataView dtv_Luong = new DataView();
        public DataView dtv_Thuong = new DataView();
        public DataView dtv_TaiKhoan = new DataView();
        public DataView dtv_DichVu = new DataView();
        public DataView dtv_VatTu = new DataView();
        public DataView dtv_HoaDon = new DataView();
        public DataView dtv_Ca = new DataView();
        public DataView dtv_PhanCong = new DataView();
        public DataView dtv_DiemDanh = new DataView();
        public DataView dtv_NhapKho = new DataView();
        public DataView dtv_ChiTietHoaDon_SuDungDV = new DataView();
        public DataView dtv_ChiTietHoaDon_TieuThuVT = new DataView();
        public List<string> tinhTrang = new List<string>() { "Trống", "Đã thuê", "Đang sửa" };
        public List<string> gioiTinh = new List<string>() { "Nam", "Nữ" };
        public List<string> chucVu = new List<string>() { "Quản lý", "Lễ tân", "Phục vụ", "Lao công", "Bảo vệ" };
        SqlDataAdapter da;

        public HeThong()
        {
                dtv_Khach = Load("Khach", 1);
                dtv_LoaiPhong = Load("LoaiPhong", 1);
                dtv_Phong = Load("Phong", 1);
                dtv_Phong_LoaiPhong = Load("View_Phong_LoaiPhong", 1);
                dtv_NhanVien = Load("NhanVien", 1);
                dtv_TaiKhoan = Load("TaiKhoan", 1);
                dtv_DichVu = Load("DichVu", 1);
                dtv_VatTu = Load("VatTu", 1);
                dtv_HoaDon = Load("HoaDon", 1);
                dtv_Ca = Load("Ca", 2);
                dtv_PhanCong = Load("PhanCong", 3);
                dtv_DiemDanh = Load("DiemDanh", 4);            
                dtv_ChiTietHoaDon_SuDungDV = Load("ChiTietHoaDon_SuDungDV", 3);
                dtv_ChiTietHoaDon_TieuThuVT = Load("ChiTietHoaDon_TieuThuVT", 3);
                dtv_NhapKho = Load("NhapKho", 2);
        }

        public DataView Load(string tenBang, int soKhoaChinh)
        {
            da = new SqlDataAdapter("Select * from " + tenBang + "", connection);
            
            da.Fill(ds, tenBang);

            ds.AcceptChanges();

            DataColumn[] keys = new DataColumn[soKhoaChinh];

            for (int i = 0; i < soKhoaChinh; i++)
            {
                keys[i] = ds.Tables[tenBang].Columns[i];
            }

            ds.Tables[tenBang].PrimaryKey = keys;

            return new DataView(ds.Tables[tenBang]);
        }

        public DataView Reload(string tenBang)
        {
            da = new SqlDataAdapter("Select * from " + tenBang + "", connection);

            da.Update(ds, tenBang);

            return new DataView(ds.Tables[tenBang]);
        }

        public DataView ReloadNhanVien()
        {
            return Reload("NhanVien");
        }

        public DataView ReloadNhanVien(string MaNV)
        {
            DataView dv = new DataView(ds.Tables["NhanVien"]);

            if (dv == null)
            {
                ReloadNhanVien();
            }

            dv.RowFilter = "MaNV = " + MaNV + "";
            return dv;
        }

        public DataView ReloadTaiKhoan()
        {
            return Reload("TaiKhoan");
        }

        public DataView ReloadTaiKhoan(string MaNV)
        {
            DataView dv = new DataView(ds.Tables["TaiKhoan"]);

            if (dv == null)
            {
                ReloadTaiKhoan();
            }

            dv.RowFilter = "MaNV = " + MaNV + "";
            return dv;
        }

        public DataView ReloadLoaiPhong()
        {
            return Reload("LoaiPhong");
        }

        public DataView ReloadLoaiPhong(string MaLoaiPhong)
        {
            DataView dv = new DataView(ds.Tables["LoaiPhong"]);

            if (dv == null)
            {
                ReloadLoaiPhong();
            }

            dv.RowFilter = "MaLoaiPhong = '" + MaLoaiPhong + "'";
            return dv;
        }

        public DataView ReloadPhong()
        {
            return Reload("Phong");
        }

        public DataView ReloadPhong(string MaPhong)
        {
            DataView dv = new DataView(ds.Tables["Phong"]);

            if (dv == null)
            {
                ReloadPhong();
            }

            dv.RowFilter = "MaPhong = '" + MaPhong + "'";
            return dv;
        }

        public DataView ReloadKhach()
        {
            return Reload("Khach");
        }

        public DataView ReloadKhach(string CCCD)
        {
            DataView dv = new DataView(ds.Tables["Khach"]);

            if (dv == null)
            {
                ReloadKhach();
            }

            dv.RowFilter = "CMND_CCCD = '" + CCCD + "'";
            return dv;
        }

        public DataView ReloadDichVu()
        {
            return Reload("DichVu");
        }

        public DataView ReloadDichVu(string TenDV)
        {
            DataView dv = new DataView(ds.Tables["DichVu"]);

            if (dv == null)
            {
                ReloadDichVu();
            }

            dv.RowFilter = "TenDV = '" + TenDV + "'";
            return dv;
        }

        public DataView ReloadVatTu()
        {
            return Reload("VatTu");
        }

        public DataView ReloadVatTu(string TenVT)
        {
            DataView dv = new DataView(ds.Tables["VatTu"]);

            if (dv == null)
            {
                ReloadVatTu();
            }

            dv.RowFilter = "TenVT = '" + TenVT + "'";
            return dv;
        }

        public DataView ReloadCTHD_DV()
        {
            return Reload("ChiTietHoaDon_SuDungDV");
        }

        public DataView ReloadCTHD_DV(string MaHD)
        {
            DataView dv = new DataView(ds.Tables["ChiTietHoaDon_SuDungDV"]);

            if (dv == null)
            {
                ReloadCTHD_DV();
            }

            dv.RowFilter = "MaHD = '" + MaHD + "'";
            return dv;
        }

        public DataView ReloadCTHD_VT()
        {
            return Reload("ChiTietHoaDon_TieuThuVT");
        }

        public DataView ReloadCTHD_VT(string MaHD)
        {
            DataView dv = new DataView(ds.Tables["ChiTietHoaDon_TieuThuVT"]);

            if (dv == null)
            {
                ReloadCTHD_VT();
            }

            dv.RowFilter = "MaHD = '" + MaHD + "'";
            return dv;
        }

        public DataView ReloadHoaDon()
        {
            return Reload("HoaDon");
        }

        public DataView ReloadHoaDon(string MaHD)
        {
            DataView dv = new DataView(ds.Tables["HoaDon"]);

            if (dv == null)
            {
                ReloadHoaDon();
            }

            dv.RowFilter = "MaHD = '" + MaHD + "'";
            return dv;
        }

        public DataView ReloadCa()
        {
            return Reload("Ca");
        }

        public DataView ReloadCa(string ChucVu)
        {
            DataView dv = new DataView(ds.Tables["Ca"]);

            if (dv == null)
            {
                ReloadCa();
            }

            dv.RowFilter = "ChucVu = '" + ChucVu + "'";
            return dv;
        }

        public DataView ReloadCa(string SoCa, string ChucVu)
        {
            DataView dv = new DataView(ds.Tables["Ca"]);

            if (dv == null)
            {
                ReloadCa();
            }

            dv.RowFilter = "ChucVu = '" + ChucVu + "' and SoCa = '" + SoCa + "'";
            return dv;
        }

        public DataView ReloadPhanCong()
        {
            return Reload("PhanCong");
        }

        public DataView ReloadPhanCong(string MaNV)
        {
            DataView dv = new DataView(ds.Tables["PhanCong"]);

            if (dv == null)
            {
                ReloadPhanCong();
            }

            dv.RowFilter = "MaNV = '" + MaNV + "'";
            return dv;
        }

        public DataView ReloadDiemDanh()
        {
            return Reload("DiemDanh");
        }

        public DataView ReloadDiemDanh(string MaNV)
        {
            DataView dv = new DataView(ds.Tables["DiemDanh"]);

            if (dv == null)
            {
                ReloadDiemDanh();
            }

            dv.RowFilter = "MaNV = '" + MaNV + "'";
            return dv;
        }

        public DataView XemNhapKho()
        {
            DataView dv = new DataView();

            da = new SqlDataAdapter("Select * from View_NhapKho", connection);

            da.Fill(ds, "View_NhapKho");

            DataColumn[] keys = new DataColumn[2];

            keys[0] = ds.Tables["View_NhapKho"].Columns[0];
            keys[1] = ds.Tables["View_NhapKho"].Columns[3];

            ds.Tables["View_NhapKho"].PrimaryKey = keys;

            return new DataView(ds.Tables["View_NhapKho"]);
        }

        public void Luu(string tenBang)
        {
            da = new SqlDataAdapter("Select * from " + tenBang + "", connection);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, tenBang);
        }

        /// <summary>
        /// Kiểm tra tài khoản có tồn tại không. Nếu có thì mật khẫu đã nhập có trùng khớp không. Nếu đúng thì sẽ trả về chức vụ của nhân viên đó
        /// </summary>
        /// <param name="MaNV"></param>
        /// <param name="MatKhau"></param>
        /// <returns></returns>
        public string KiemTraTaiKhoan(string MaNV, string MatKhau)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand("Select MatKhau from TaiKhoan where MaNV = " + MaNV + "", connection);

            string mk = (string)command.ExecuteScalar();

            if (mk != null)
            {
                string cv = "";

                if (MatKhau == mk.Trim())
                {
                    SqlCommand command2 = new SqlCommand("Select ChucVu from NhanVien where MaNV = " + MaNV + "", connection);
                    cv = (string)command2.ExecuteScalar();

                    connection.Close();

                    return cv;
                }
            }
        
            return null;
        }

        public string ThemDichVu(string TenDV, string GiaDV)
        {
            try
            {
                DataRow newrow = ds.Tables["DichVu"].NewRow();
                newrow["TenDV"] = TenDV;
                newrow["GiaDV"] = GiaDV;
                ds.Tables["DichVu"].Rows.Add(newrow);

                Luu("DichVu");

                return "Thêm dịch vụ thành công";
            }
            catch
            {
                return "Thêm dịch vụ thất bại";
            }
        }

        public string CapNhatDichVu(string TenDV, string GiaDV)
        {
            try
            {
                Load("DichVu", 1);
                DataRow newrow = ds.Tables["DichVu"].Rows.Find(TenDV);
                newrow["GiaDV"] = GiaDV;

                Luu("DichVu");

                return "Cập nhật dịch vụ thành công";
            }
            catch
            {
                return "Cập nhật dịch vụ thất bại";
            }
        }

        public string ThemVatTu(string TenVT, int SoLuong, string NguonGoc, int DonGia)
        {
            try
            {
                DataRow newrow = ds.Tables["VatTu"].NewRow();
                newrow["TenVT"] = TenVT;
                newrow["SoLuong"] = SoLuong;
                newrow["NguonGoc"] = NguonGoc;
                newrow["DonGia"] = DonGia;
                ds.Tables["VatTu"].Rows.Add(newrow);

                Luu("VatTu");

                return "Thêm vật tư thành công";
            }
            catch
            {
                return "Thêm cầu vật tư thất bại";
            }
        }

        public string CapNhatVatTu(string TenVT, int SoLuong, string NguonGoc, int DonGia)
        {
            try
            {
                Load("VatTu", 1);
                DataRow newrow = ds.Tables["VatTu"].Rows.Find(TenVT);
                newrow["SoLuong"] = SoLuong;
                newrow["NguonGoc"] = NguonGoc;
                newrow["DonGia"] = DonGia;

                Luu("VatTu");

                return "Cập nhật dịch vụ thành công";
            }
            catch
            {
                return "Cập nhật dịch vụ thất bại";
            }
        }

        public string SuDungDV(string MaHD, string TenDV)
        {
            try
            {
                DataRow newrow = ds.Tables["ChiTietHoaDon_SuDungDV"].NewRow();
                newrow["MaHD"] = MaHD;
                newrow["TenDV"] = TenDV;
                newrow["ThoiGianYeuCau"] = DateTime.Now;
                ds.Tables["ChiTietHoaDon_SuDungDV"].Rows.Add(newrow);

                Luu("ChiTietHoaDon_SuDungDV");

                return "Yêu cầu dịch vụ thành công";
            }
            catch
            {
                return "Yêu cầu dịch vụ thất bại";
            }
        }

        public string TieuThuVT(string MaHD, string TenVT, int SoLuong)
        {
            try
            {
                DataRow newrow = ds.Tables["ChiTietHoaDon_TieuThuVT"].NewRow();
                newrow["MaHD"] = MaHD;
                newrow["TenVT"] = TenVT;
                newrow["ThoiGianTieuThu"] = DateTime.Now;
                newrow["SoLuong"] = SoLuong;
                ds.Tables["ChiTietHoaDon_TieuThuVT"].Rows.Add(newrow);

                Luu("ChiTietHoaDon_TieuThuVT");

                CapNhatSoLuong(TenVT, -SoLuong);

                return "Yêu cầu vật tư thành công";
            }
            catch
            {
                return "Yêu cầu vật tư thất bại";
            }
        }

        public string CapNhatSoLuong(string TenVT, int SoLuong)
        {           
            try
            {
                DataRow rowVT = ds.Tables["VatTu"].Rows.Find(TenVT);
                rowVT["SoLuong"] = Convert.ToInt32(rowVT["SoLuong"]) + SoLuong;

                Luu("VatTu");

                return "Yêu cầu vật tư thành công";
            }
            catch
            {
                return "Yêu cầu vật tư thất bại";
            }
        }

        public string ThemHoaDon(string MaPhong, string CCCD, DateTime Ngay)
        {
            try
            {
                DataRow newrow = ds.Tables["HoaDon"].NewRow();
                int last_number = Convert.ToInt32(ds.Tables["HoaDon"].Rows[ds.Tables["HoaDon"].Rows.Count - 1]["MaHD"].ToString());
                newrow["MaHD"] = last_number + 1;
                newrow["MaPhong"] = MaPhong;
                newrow["CMND_CCCD"] = CCCD;
                newrow["ThoiGianGiaoPhong"] = Ngay;
                newrow["TongTien"] = 0;
                ds.Tables["HoaDon"].Rows.Add(newrow);

                Luu("HoaDon");

                return "Thêm hóa đơn thành công";
            }
            catch
            {
                return "Thêm hóa đơn thất bại";
            }
        }

        public string CapNhatHoaDon(string MaHD, string MaPhong, string CCCD, DateTime NgayNhanPhong, DateTime NgayTraPhong = default)
        {
            try
            {
                Load("HoaDon", 1);
                DataRow newrow = ds.Tables["HoaDon"].Rows.Find(MaHD);
                newrow["MaPhong"] = MaPhong;
                newrow["CMND_CCCD"] = CCCD;
                newrow["ThoiGianGiaoPhong"] = NgayNhanPhong;
                if (NgayTraPhong != default)
                {
                    newrow["ThoiGianGiaoPhong"] = NgayTraPhong;
                }
                newrow["TongTien"] = 0;
                ds.Tables["HoaDon"].Rows.Add(newrow);

                Luu("HoaDon");

                return "Thêm hóa đơn thành công";
            }
            catch
            {
                return "Thêm hóa đơn thất bại";
            }
        }

        public string XoaHoaDon(string MaHD)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            int tong = 0;

            SqlCommand command = new SqlCommand("Exec XoaHoaDon " + MaHD + "", connection);

            command.ExecuteNonQuery();

            return "Xóa hóa đơn thành công";
        }

        public bool DoiTinhTrangPhong(string MaPhong, string tinhTrang)
        {
            try
            {
                DataRow rowP = ds.Tables["Phong"].Rows.Find(MaPhong);
                rowP["TinhTrang"] = tinhTrang;

                Luu("Phong");

                return true;
            }
            catch
            {
                return false;
            }
        }

        public string thuePhong(string MaPhong, string CCCD, DateTime Ngay)
        {
            DataRow rowP = ds.Tables["Phong"].Rows.Find(MaPhong);
            string tt = rowP["TinhTrang"].ToString();

            if(tt == "Trống")
            {
                try
                {
                    ThemHoaDon(MaPhong, CCCD, Ngay);

                    DoiTinhTrangPhong(MaPhong, "Đã thuê");

                    return "Thuê phòng thành công";
                }
                catch
                {
                    return "Thuê phòng thất bại do lỗi kĩ thuật";
                }
            }
            else if (tt == "Đã thuê")
            {
                return "Thuê phòng thất bại do phòng đã được thuê";
            }
            else
            {
                return "Thuê phòng thất bại do phòng đang được sửa chữa";
            }
        }

        public bool ThanhToan(string MaHD)
        {
            DataRow rowHD = ds.Tables["HoaDon"].Rows.Find(MaHD);
            DataRow rowP = ds.Tables["Phong"].Rows.Find(rowHD["MaPhong"]);
            DataRow rowLP = ds.Tables["View_Phong_LoaiPhong"].Rows.Find(rowHD["MaPhong"]);

            DateTime dt = Convert.ToDateTime(rowHD["ThoiGianGiaoPhong"]);
            int soNgayO = DateTime.Today.Subtract(dt).Days + 1;
            int tienPhong = Convert.ToInt32(rowLP["GiaPhong"]) * soNgayO;

            rowHD["TongTien"] = tienPhong + TinhChiPhi(MaHD);
            rowHD["ThoiGianTraPhong"] = DateTime.Now;

            Luu("HoaDon");

            DoiTinhTrangPhong(rowP["MaPhong"].ToString(), "Trống");
            try
            {


                return true;
            }
            catch
            {
                return false;
            }
        }

        public string DoiPhong(string MaHD, string MaPhong, string CCCD, DateTime Ngay)
        {
            if(ThanhToan(MaHD))
            {
                string kq = thuePhong(MaPhong, CCCD, Ngay);

                if (kq == "Thuê phòng thành công")
                {
                    return "Đổi phòng thành công";
                }
                else
                {
                    return "Đổi phòng thất bại";
                }

            }
            else
            {
                return "Đổi phòng thất bại do thanh toán không thành công";
            }
        }

        public DataView XuatHoaDonPhong(string MaPhong)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand("Exec XemHoaDonGanNhat @mp = '" + MaPhong + "'", connection);

            SqlDataReader r = command.ExecuteReader();           

            DataTable dt = new DataTable();
            dt.Load(r);

            DataView dv = new DataView(dt);

            connection.Close();

            return dv;
        }

        public int TinhChiPhi(string MaHD)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            int tong = 0;

            SqlCommand command = new SqlCommand("Exec XemTienDV @mhd = " + MaHD + "", connection);
            SqlCommand command2 = new SqlCommand("Exec XemTienVT @mhd = " + MaHD + "", connection);

            var kq = command.ExecuteScalar();
            var kq2 = command2.ExecuteScalar();

            connection.Close();

            if (kq != DBNull.Value)
            {
                tong += Convert.ToInt32(kq);
            }

            if (kq2 != DBNull.Value)
            {
                tong += Convert.ToInt32(kq2);
            }

            return tong;
        }

        public int TinhTienPhong(string MaHD)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand("Exec XemTienPhong @mhd = " + MaHD + "", connection);

            var kq = command.ExecuteScalar();

            int tien = Convert.ToInt32(kq);

            connection.Close();

            return tien;
        }

        public string ThemKhach(string CMND_CCCD, string TenKhach, string GioiTinh, string DiaChi, string SDT)
        {
            try
            {
                DataRow newrow = ds.Tables["Khach"].NewRow();
                newrow["CMND_CCCD"] = CMND_CCCD;
                newrow["TenKhach"] = TenKhach;
                newrow["GioiTinh"] = GioiTinh;
                newrow["DiaChi"] = DiaChi;
                newrow["SDT"] = SDT;
                ds.Tables["Khach"].Rows.Add(newrow);

                Luu("Khach");

                return "Thêm thông tin khách thành công";
            }
            catch
            {
                return "Thêm thông tin khách thất bại";
            }
        }

        public string CapNhatKhach(string CMND_CCCD, string TenKhach, string GioiTinh, string DiaChi, string SDT)
        {
            try
            {
                DataRow newrow = ds.Tables["Khach"].Rows.Find(CMND_CCCD);
                newrow["TenKhach"] = TenKhach;
                newrow["GioiTinh"] = GioiTinh;
                newrow["DiaChi"] = DiaChi;
                newrow["SDT"] = SDT;

                Luu("Khach");

                return "Cập nhật thông tin khách thành công";
            }
            catch
            {
                return "Cập nhật thông tin khách thất bại";
            }
        }

        public string ThemPhong(string MaPhong, string LoaiPhong, string ViTriPhong, string GiaPhong)
        {
            try
            {
                DataRow newrow = ds.Tables["Phong"].NewRow();
                newrow["MaPhong"] = MaPhong;
                newrow["LoaiPhong"] = LoaiPhong;
                newrow["ViTriPhong"] = ViTriPhong;
                newrow["GiaPhong"] = Convert.ToInt32(GiaPhong);
                newrow["TinhTrang"] = "Trống";
                ds.Tables["Phong"].Rows.Add(newrow);

                Luu("Phong");

                return "Thêm thông tin phòng thành công";
            }
            catch
            {
                return "Thêm thông tin phòng thất bại";
            }
        }

        public string CapNhatPhong(string MaPhong, string LoaiPhong, string ViTriPhong, string GiaPhong, string TinhTrang)
        {
            try
            {
                Load("Phong", 1);
                DataRow newrow = ds.Tables["Phong"].Rows.Find(MaPhong);
                newrow["LoaiPhong"] = LoaiPhong;
                newrow["ViTriPhong"] = ViTriPhong;
                newrow["GiaPhong"] = Convert.ToInt32(GiaPhong);
                newrow["TinhTrang"] = TinhTrang;

                Luu("Phong");

                return "Cập nhật thông tin phòng thành công";
            }
            catch
            {
                return "Cập nhật thông tin phòng thất bại";
            }
        }

        public string XoaPhong(string MaPhong)
        {

            try
            {
                DataView hd = XemHoaDonPhong(MaPhong);

                if (hd.Count > 0)
                {
                    return "Phòng này không thể xóa vì đang được sử dụng trong một hoặc nhiều hóa đơn";
                }

                DataRow newrow = ds.Tables["Phong"].Rows.Find(MaPhong);

                if (newrow != null)
                {
                    newrow.Delete();
                }

                Luu("Phong");

                return "Xóa phân công thành công";
            }
            catch
            {
                return "Xóa phân công thất bại";
            }
        }

        public string ThemNhanVien(string CMND_CCCD, string TenNV, string GioiTinh, string ChucVu, DateTime NgaySinh, string NoiSinh, string DiaChi, string SDT, DateTime TGNV, string Hinh = null, double HeSoLuong = 0)
        {
            try
            {
                DataRow newrow = ds.Tables["NhanVien"].NewRow();
                int last_number = Convert.ToInt32(ds.Tables["NhanVien"].Rows[ds.Tables["NhanVien"].Rows.Count - 1]["MaNV"].ToString());
                newrow["MaNV"] = last_number + 1;
                newrow["TenNV"] = TenNV;
                newrow["GioiTinh"] = GioiTinh;
                newrow["CMND_CCCD"] = CMND_CCCD;
                newrow["SDT"] = SDT;
                newrow["ChucVu"] = ChucVu;
                newrow["NgaySinh"] = NgaySinh;
                newrow["NoiSinh"] = NoiSinh;
                newrow["DiaChi"] = DiaChi;
                newrow["ThoiGianNhanViec"] = TGNV;
                newrow["ThoiGianThoiViec"] = DBNull.Value;
                newrow["HeSoLuong"] = HeSoLuong;
                if (Hinh == null)
                {
                    newrow["DuongDanHinh"] = DBNull.Value;
                }
                else
                {
                    newrow["DuongDanHinh"] = Hinh;
                }

                ds.Tables["NhanVien"].Rows.Add(newrow);

                Luu("NhanVien");

                return "Thêm thông tin nhân viên thành công";
            }
            catch (NullReferenceException)
            {
                return "Thêm thông tin nhân viên thất bại";
            }
        }

        public string CapNhatNhanVien(string MaNV, string CMND_CCCD, string TenNV, string GioiTinh, string ChucVu, DateTime NgaySinh, string NoiSinh, string DiaChi, string SDT, DateTime TGNV, double HeSoLuong, string Hinh = null)
        {
            Load("NhanVien", 1);
            DataRow newrow = ds.Tables["NhanVien"].Rows.Find(MaNV);

            try
            {
                if (newrow != null)
                {
                    newrow["TenNV"] = TenNV;
                    newrow["GioiTinh"] = GioiTinh;
                    newrow["CMND_CCCD"] = CMND_CCCD;
                    newrow["SDT"] = SDT;
                    newrow["ChucVu"] = ChucVu;
                    newrow["NgaySinh"] = NgaySinh;
                    newrow["NoiSinh"] = NoiSinh;
                    newrow["DiaChi"] = DiaChi;
                    newrow["ThoiGianNhanViec"] = TGNV;
                    newrow["HeSoLuong"] = HeSoLuong;

                    if (Hinh != null)
                    {
                        newrow["DuongDanHinh"] = Hinh;
                    }


                    Luu("NhanVien");

                    return "Cập nhật thông tin nhân viên thành công";
                }
                else
                {
                    return "Thông tin nhân viên có mã nhân viên " + MaNV + " không tồn tại";
                }
            }
            catch (NullReferenceException)
            {
                return "Cập nhật thông tin nhân viên thất bại";
            }
        }

        public string ThoiViecNhanVien(string MaNV)
        {
            DataRow newrow = ds.Tables["NhanVien"].Rows.Find(MaNV);

            if (newrow != null)
            {
                newrow["ThoiGianThoiViec"] = DateTime.Today;

                Luu("NhanVien");

                return "Thôi việc nhân viên thành công";
            }
            else
            {
                return "Thông tin nhân viên có mã nhân viên " + MaNV + " không tồn tại";
            }
        }

        public DataView XemTaiKhoanLeTan()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand("Exec XemTaiKhoan @chucVu = N'Lễ tân'", connection);

            SqlDataReader r = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(r);

            DataView dv = new DataView(dt);

            connection.Close();

            return dv;
        }

        public string ThemTaiKhoan(string MaNV, string MatKhau)
        {
            try
            {
                DataRow newrow = ds.Tables["TaiKhoan"].NewRow();
                newrow["MaNV"] = MaNV;
                newrow["MatKhau"] = MatKhau;
                ds.Tables["TaiKhoan"].Rows.Add(newrow);

                Luu("TaiKhoan");

                return "Thêm tài khoản thành công";
            }
            catch
            {
                return "Thêm tài khoản thất bại";
            }
        }

        public string DoiMatKhau(string MaNV, string MatKhau)
        {
            try
            {
                Load("TaiKhoan", 1);
                DataRow newrow = ds.Tables["TaiKhoan"].Rows.Find(MaNV);
                newrow["MatKhau"] = MatKhau;

                Luu("TaiKhoan");

                return "Đổi mật khẩu thành công";
            }
            catch
            {
                return "Đổi mật khẩu thất bại";
            }
        }

        public string XoaTaiKhoan(string MaNV)
        {
            try
            {
                DataRow newrow = ds.Tables["TaiKhoan"].Rows.Find(MaNV);

                if (newrow != null)
                {
                    newrow.Delete();
                }

                Luu("TaiKhoan");

                return "Xóa phân công thành công";
            }
            catch
            {
                return "Xóa phân công thất bại";
            }
        }

        public string ThemCa(string SoCa, string ChucVu, DateTime ThoiGianBatDauCa, DateTime ThoiGianKetThucCa)
        {
            try
            {
                DataRow newrow = ds.Tables["Ca"].NewRow();
                newrow["SoCa"] = SoCa;
                newrow["ChucVu"] = ChucVu;
                newrow["ThoiGianBatDauCa"] = ThoiGianBatDauCa.TimeOfDay;
                newrow["ThoiGianKetThucCa"] = ThoiGianKetThucCa.TimeOfDay;
                ds.Tables["Ca"].Rows.Add(newrow);

                Luu("Ca");

                return "Thêm ca thành công";
            }
            catch
            {
                return "Thêm ca thất bại";
            }
        }

        public string CapNhatCa(string SoCa, string ChucVu, DateTime ThoiGianBatDauCa, DateTime ThoiGianKetThucCa)
        {
            try
            {
                DataRow newrow = ds.Tables["Ca"].Rows.Find(SoCa);
                newrow["ChucVu"] = ChucVu;
                newrow["ThoiGianBatDauCa"] = ThoiGianBatDauCa.TimeOfDay;
                newrow["ThoiGianKetThucCa"] = ThoiGianKetThucCa.TimeOfDay;

                Luu("Ca");

                return "Cập nhật thông tin ca thành công";
            }
            catch
            {
                return "Cập nhật thông tin ca thất bại";
            }
        }

        public string ThemPhanCong(string MaNV, string Ca, string ChucVu)
        {
            try
            {
                DataRow newrow = ds.Tables["PhanCong"].NewRow();
                newrow["MaNV"] = MaNV;
                newrow["Ca"] = Ca;
                newrow["ChucVu"] = ChucVu;

                ds.Tables["PhanCong"].Rows.Add(newrow);

                Luu("PhanCong");

                return "Phân công thành công";
            }
            catch
            {
                return "Phân công thất bại";
            }
        }

        public string XoaPhanCong(string MaNV, string Ca, string ChucVu)
        {

            try
            {
                object[] keys = new object[3] { MaNV, ChucVu, Ca };

                DataRow newrow = ds.Tables["PhanCong"].Rows.Find(keys);

                if (newrow != null)
                {
                    newrow.Delete();
                }

                Luu("PhanCong");

                return "Xóa phân công thành công";
            }
            catch
            {
                return "Xóa phân công thất bại";
            }
        }

        public DataView DiemDanhHienTai(string MaNV)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlCommand command = new SqlCommand("Exec DiemDanhHienTai @mnv = '" + MaNV + "'", connection);

            SqlDataReader r = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(r);

            DataView dv = new DataView(dt);

            connection.Close();

            return dv;
        }

        public string DiemDanh(string MaNV)
        {
            try
            {
                DataView dv = DiemDanhHienTai(MaNV);

                object[] keys = new object[4] { MaNV, dv[0]["ChucVu"].ToString(), dv[0]["Ca"].ToString(), dv[0]["Ngay"].ToString() };

                DataRow newrow = ds.Tables["DiemDanh"].Rows.Find(keys);

                string kq = "Nhân viên này hôm nay đã điểm danh"; 

                if (newrow["DiemDanhBatDauCa"] == DBNull.Value)
                {
                    newrow["DiemDanhBatDauCa"] = DateTime.Now.ToString("HH:mm:ss");
                    kq = "Điểm danh bắt đầu ca thành công"; 
                }
                else if (newrow["DiemDanhKetThucCa"] == DBNull.Value)
                {
                    newrow["DiemDanhKetThucCa"] = DateTime.Now.ToString("HH:mm:ss");
                    kq = "Điểm danh kết thúc ca thành công"; 
                }

                Luu("DiemDanh");

                return kq;
            }
            catch (NullReferenceException)
            {
                return "Điểm danh thất bại";
            }
        }

        public string TaoDiemDanh()
        {
            try
            {
                string temp = dtv_NhanVien.RowFilter;

                dtv_NhanVien.RowFilter = null;

                foreach (DataRowView row in dtv_NhanVien)
                {
                    TaoDiemDanh(row["MaNV"].ToString());
                }

                dtv_NhanVien.RowFilter = temp;

                return "Tạo điểm danh thành công";
            }
            catch (NullReferenceException)
            {
                return "Tạo điểm danh thất bại";
            }
        }

        public string TaoDiemDanh(string MaNV)
        {
            try
            {
                DataView pc = ReloadPhanCong(MaNV);

                DataView dv = ReloadNhanVien(MaNV);

                foreach (DataRowView row in pc)
                {
                    DataRow newrow = ds.Tables["DiemDanh"].NewRow();

                    newrow["MaNV"] = MaNV;
                    newrow["ChucVu"] = dv[0]["ChucVu"].ToString();
                    newrow["Ca"] = row["Ca"].ToString();
                    newrow["Ngay"] = DateTime.Today;
                    newrow["DiemDanhBatDauCa"] = DBNull.Value;
                    newrow["DiemDanhKetThucCa"] = DBNull.Value;

                    ds.Tables["DiemDanh"].Rows.Add(newrow);
                }

                Luu("DiemDanh");

                return "Tạo điểm danh thành công";
            }
            catch (NullReferenceException)
            {
                return "Tạo điểm danh thất bại do thiếu thông tin";
            }
            catch (ConstraintException)
            {
                return "Đã tồn tại điểm danh";
            }
        }

        public DataView XemHoaDonKhach(string CMND_CCCD)
        {
            DataView dv = new DataView(ds.Tables["HoaDon"]);

            if (dv == null)
            {
                ReloadHoaDon();
            }

            dv.RowFilter = "CMND_CCCD = '" + CMND_CCCD + "'";
            return dv;
        }

        public DataView XemHoaDonPhong(string MaPhong)
        {
            DataView dv = new DataView(ds.Tables["HoaDon"]);

            if (dv == null)
            {
                ReloadHoaDon();
            }

            dv.RowFilter = "MaPhong = '" + MaPhong + "'";
            return dv;
        }

        public DataView XemSuDungDV(string TenDV)
        {
            DataView dv = new DataView(ds.Tables["ChiTietHoaDon_SuDungDV"]);

            if (dv == null)
            {
                ReloadCTHD_DV();
            }

            dv.RowFilter = "TenDV = '" + TenDV + "'";
            return dv;
        }

        public DataView XemTieuThuVT(string TenVT)
        {
            DataView dv = new DataView(ds.Tables["ChiTietHoaDon_TieuThuVT"]);

            if (dv == null)
            {
                ReloadCTHD_VT();
            }

            dv.RowFilter = "TenVT = '" + TenVT + "'";
            return dv;
        }

        public void RefreshTextBox(TextBox txt)
        {
            txt.DataBindings.Clear();
            txt.Clear();
        }

        public void RefreshTextBox(TextBox txt, DataView dv, string member)
        {
            txt.DataBindings.Clear();
            txt.Clear();
            txt.DataBindings.Add("text", dv, member);
        }

        public bool checkRong(string txt)
        {
            return string.IsNullOrWhiteSpace(txt);
        }

        public bool checkRong(List<string> txt_List)
        {
            foreach (string txt in txt_List)
            {
                if (checkRong(txt))
                {
                    return true;
                }
            }

            return false;
        }

        public void numberOnly(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        public string NhapKho(string TenVT, DateTime ThoiGianNhap, string MaNV, int SoLuong, int DonGiaNhap)
        {
            try
            {
                DataRow newrow = ds.Tables["NhapKho"].NewRow();
                int last_number = Convert.ToInt32(ds.Tables["NhapKho"].Rows[ds.Tables["NhapKho"].Rows.Count - 1]["MaNK"].ToString());
                newrow["MaNK"] = last_number + 1;
                newrow["TenVT"] = TenVT;
                newrow["ThoiGianNhap"] = ThoiGianNhap;
                newrow["MaNV"] = MaNV;
                newrow["SoLuong"] = SoLuong;
                newrow["DonGiaNhap"] = DonGiaNhap;

                ds.Tables["NhapKho"].Rows.Add(newrow);

                Luu("NhapKho");

                CapNhatSoLuong(TenVT, SoLuong);

                return "Ghi nhận thông tin nhập thành công";
            }
            catch
            {
                return "Ghi nhận thông tin nhập thất bại";
            }
        }

        public string ThemThuong(string MaNV, string MatKhau)
        {
            try
            {
                DataRow newrow = ds.Tables["TaiKhoan"].NewRow();
                newrow["MaNV"] = MaNV;
                newrow["MatKhau"] = MatKhau;
                ds.Tables["TaiKhoan"].Rows.Add(newrow);

                Luu("TaiKhoan");

                return "Thêm tài khoản thành công";
            }
            catch
            {
                return "Thêm tài khoản thất bại";
            }
        }

        public string CapNhatThuong(string MaNV, string MatKhau)
        {
            try
            {
                Load("TaiKhoan", 1);
                DataRow newrow = ds.Tables["TaiKhoan"].Rows.Find(MaNV);
                newrow["MatKhau"] = MatKhau;

                Luu("TaiKhoan");

                return "Đổi mật khẩu thành công";
            }
            catch
            {
                return "Đổi mật khẩu thất bại";
            }
        }

        public string XoaThuong(string MaNV)
        {
            try
            {
                DataRow newrow = ds.Tables["TaiKhoan"].Rows.Find(MaNV);

                if (newrow != null)
                {
                    newrow.Delete();
                }

                Luu("TaiKhoan");

                return "Xóa phân công thành công";
            }
            catch
            {
                return "Xóa phân công thất bại";
            }
        }
    }
}
