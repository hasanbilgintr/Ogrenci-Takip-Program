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
    
    public partial class OgretmenBilgileri
    {
        public int OgretmenBilgileriID { get; set; }
        public int OgretmenID { get; set; }
        public System.DateTime GirisTarihi { get; set; }
        public Nullable<System.DateTime> CikisTarihi { get; set; }
    
        public virtual Ogretmenler Ogretmenler { get; set; }
    }
}