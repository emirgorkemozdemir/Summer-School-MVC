//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yaz_Okulu_MVC_2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ÖğrenciTablosu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ÖğrenciTablosu()
        {
            this.BasvuruTablosu = new HashSet<BasvuruTablosu>();
        }
    
        public int OgrID { get; set; }
        public string OgrAd { get; set; }
        public string OgrSoyad { get; set; }
        public string OgrMail { get; set; }
        public string OgrSifre { get; set; }
        public Nullable<int> Bakiye { get; set; }
        public string OgrOkulNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BasvuruTablosu> BasvuruTablosu { get; set; }
    }
}
