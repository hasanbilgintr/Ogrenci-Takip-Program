//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _190421_1_OOP_Ornek_Proje
{
    using System;
    using System.Collections.Generic;
    
    public partial class OgrenciIzin
    {
        public int IzinID { get; set; }
        public string IzinTuru { get; set; }
        public Nullable<int> YoklamaID { get; set; }
        public string BarkodNo { get; set; }
        public Nullable<System.DateTime> BaslangicTarihi { get; set; }
        public Nullable<System.DateTime> BitisTarihi { get; set; }
    
        public virtual Yoklama Yoklama { get; set; }
    }
}