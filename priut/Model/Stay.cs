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
    
    public partial class Stay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stay()
        {
            this.DataAnim = new HashSet<DataAnim>();
            this.StayStr = new HashSet<StayStr>();
        }
    
        public int ID_stay { get; set; }
        public System.DateTime ArrivalDate { get; set; }
        public Nullable<int> ID_archive_FK_ { get; set; }
        public Nullable<int> ID_password_FK_ { get; set; }
    
        public virtual Archive Archive { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataAnim> DataAnim { get; set; }
        public virtual Passport Passport { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StayStr> StayStr { get; set; }
    }
}