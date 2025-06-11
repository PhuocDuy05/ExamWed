using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_PhamHuynhAnh.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> ops) : base(ops)
        {
        }
        public DbSet<Phim> Phims { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Phim>().HasData(
                new Phim { Id = 1, TuaDe = "Mắt Biếc", DienVien = "Trần Nghĩa", TrongNuoc = true, GiaVe = 75000, ThoiLuong = 117 },
                new Phim { Id = 2, TuaDe = "Avengers: Endgame", DienVien = "Robert Downey Jr.", TrongNuoc = false, GiaVe = 120000, ThoiLuong = 181 },
                new Phim { Id = 3, TuaDe = "Parasite", DienVien = "Song Kang-ho", TrongNuoc = false, GiaVe = 95000, ThoiLuong = 132 },
                new Phim { Id = 4, TuaDe = "Bố Già", DienVien = "Trấn Thành", TrongNuoc = true, GiaVe = 80000, ThoiLuong = 128 },
                new Phim { Id = 5, TuaDe = "The Dark Knight", DienVien = "Christian Bale", TrongNuoc = false, GiaVe = 110000, ThoiLuong = 152 },
                new Phim { Id = 6, TuaDe = "Em và Trịnh", DienVien = "Avin Lu", TrongNuoc = true, GiaVe = 70000, ThoiLuong = 136 }
            );
        }

    }
}

