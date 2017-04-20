using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web;

namespace shop.Models.BUS
{
    public class SanPhamBUS
    {
        public static IEnumerable<sanpham> DanhSach()
        {
            var db = new webDB();
            return db.Query<sanpham>("select * from sanpham");

        }
    }
}