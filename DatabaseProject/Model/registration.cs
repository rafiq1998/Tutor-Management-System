//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseProject.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class registration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public registration()
        {
            this.fees_details = new HashSet<fees_details>();
        }
    
        public int registration_id { get; set; }
        public Nullable<int> student_id { get; set; }
        public Nullable<int> course_id { get; set; }
        public Nullable<System.DateTime> doj { get; set; }
    
        public virtual cours cours { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fees_details> fees_details { get; set; }
        public virtual student student { get; set; }
    }
}
