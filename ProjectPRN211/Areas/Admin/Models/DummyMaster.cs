using System;
using System.Collections.Generic;

#nullable disable

namespace Project_Testing.Models
{
    public partial class DummyMaster
    {
        public DummyMaster()
        {
            DummyDetails = new HashSet<DummyDetail>();
        }

        public int MasterId { get; set; }
        public string MasterName { get; set; }

        public virtual ICollection<DummyDetail> DummyDetails { get; set; }
    }
}
