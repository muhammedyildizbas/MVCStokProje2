//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcProje.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TBLSATISLAR
    {
        public int SATISID { get; set; }
        
        public Nullable<int> URUN { get; set; }
        
        public Nullable<int> MUSTERI { get; set; }
        public Nullable<byte> ADET { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
    
        public virtual TBLMUSTERILER TBLMUSTERILER { get; set; }
        public virtual TBLURUNLER TBLURUNLER { get; set; }
    }
}
