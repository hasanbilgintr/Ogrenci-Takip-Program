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
    
    public partial class OgrenciTakim
    {
        public int OgrenciTakimID { get; set; }
        public Nullable<int> OkulTakimiID { get; set; }
        public Nullable<int> OgrenciID { get; set; }
    
        public virtual Ogrenciler Ogrenciler { get; set; }
        public virtual OkulTakimi OkulTakimi { get; set; }
    }
}
