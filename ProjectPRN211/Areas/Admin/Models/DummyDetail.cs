using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Testing.Models
{
    public partial class DummyDetail
    {
        public int DetailId { get; set; }
        public string DetailName { get; set; }
        public int MasterId { get; set; }

        public virtual DummyMaster Master { get; set; }
    }
}
