using ExamWeb_PhamHuynhAnh.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_PhamHuynhAnh.Controllers
{
    public class PhimController : Controller
    {
        private AppDbContext _db;
        public PhimController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            var dsPhim = _db.Phims.ToList();
            int tongSoPhim = _db.Phims.Count();
            double giaVeCaoNhat = _db.Phims.Max(p => p.GiaVe);
            ViewBag.TongSoPhim = tongSoPhim;
            ViewBag.GiaVeCaoNhat = giaVeCaoNhat;
            return View(dsPhim);
        }
        [HttpPost]
        public IActionResult Add(Phim p)
        {
            _db.Phims.Add(p);
            _db.SaveChanges();
            TempData["success"] = "Thêm Phim thành công";

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Phim p)
        {

            //B1: Truy vấn cần cập nhật trong CSDL
            var OldPhim = _db.Phims.Find(p.Id);

            //cập nhật danhmucj vào table danhmucj
            OldPhim.TuaDe = p.TuaDe;
            OldPhim.DienVien = p.DienVien;
            OldPhim.TrongNuoc = p.TrongNuoc;
            OldPhim.GiaVe = p.GiaVe;
            OldPhim.ThoiLuong = p.ThoiLuong;
            _db.SaveChanges();
            TempData["success"] = "Cập nhật Phim thành công";
            return RedirectToAction("Index");

        }

        //Hiển thị form cập nhật
        public IActionResult Update(int id)
        {
            var p = _db.Phims.Find(id);
            return View(p);
        }
        public IActionResult Delete(int id)
        {
            var p = _db.Phims.Find(id); 
            return View(p);

        }
        //Thông báo xác nhận 
        public IActionResult DeleteConfirm(int id)
        {
            var p = _db.Phims.Find(id);        
            _db.Phims.Remove(p);
            _db.SaveChanges();
            TempData["success"] = "Xóa Phim thành công";         
            return RedirectToAction("Index");

        }
    }
}
