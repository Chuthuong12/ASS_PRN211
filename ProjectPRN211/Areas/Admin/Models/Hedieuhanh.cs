using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Testing.Models
{
    public partial class Hedieuhanh
    {
        public Hedieuhanh()
        {
            Sanphams = new HashSet<Sanpham>();
        }

        public int Mahdh { get; set; }
        public string Tenhdh { get; set; }

        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}
