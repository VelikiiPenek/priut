//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace priut.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistoryMedical
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HistoryMedical()
        {
            this.MedData = new HashSet<MedData>();
        }
    
        public int ID_medical { get; set; }
        public string Diagnosis { get; set; }
        public System.DateTime DateStart { get; set; }
        public Nullable<System.DateTime> Date_End { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedData> MedData { get; set; }
    }
}
