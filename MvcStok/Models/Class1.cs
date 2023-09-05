using MvcStok.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcStok.Models
{
    public class Class1
    {
        public IEnumerable<TBLKATEGORILER> TBLKATEGORILER { get; set; }
        public IEnumerable<TBLURUNLER> TBLURUNLER { get; set; }

        public IEnumerable<TBLMUSTERILER> TBLMUSTERILER { get; set; }
        public IEnumerable<TBLSATISLAR> TBLSATISLAR { get; set; }

    }
}