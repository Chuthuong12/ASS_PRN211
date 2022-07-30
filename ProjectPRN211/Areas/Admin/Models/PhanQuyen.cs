using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Testing.Models
{
    public partial class PhanQuyen
    {
        public PhanQuyen()
        {
            Nguoidungs = new HashSet<Nguoidung>();
        }

        public int Idquyen { get; set; }
        public string TenQuyen { get; set; }

        public virtual ICollection<Nguoidung> Nguoidungs { get; set; }
    }
}
