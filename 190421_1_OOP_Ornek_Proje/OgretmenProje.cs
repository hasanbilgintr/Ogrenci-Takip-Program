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
    
    public partial class OgretmenProje
    {
        public int OgretmenProjeID { get; set; }
        public Nullable<int> ProjeID { get; set; }
        public Nullable<int> OgretmenID { get; set; }
    
        public virtual Ogretmenler Ogretmenler { get; set; }
        public virtual Projeler Projeler { get; set; }
    }
}
