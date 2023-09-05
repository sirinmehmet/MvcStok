using MvcStok.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcStok.Models
{
    public class ViewModel
    {
        public IEnumerable<TBLKATEGORILER>KATEGORI{ get; set;}
        public IEnumerable<TBLMUSTERILER>MUSTERI{ get; set;}
        public IEnumerable<TBLSATISLAR>SATISLAR{ get; set; }
        public IEnumerable <TBLURUNLER>URUNLER{ get; set; }     

    }
}