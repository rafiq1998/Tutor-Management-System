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
    
    public partial class attendance
    {
        public int attendance_id { get; set; }
        public Nullable<int> student_id { get; set; }
        public Nullable<int> course_id { get; set; }
        public Nullable<System.DateTime> attendance_time { get; set; }
        public Nullable<bool> attendance1 { get; set; }
    
        public virtual cours cours { get; set; }
        public virtual student student { get; set; }
    }
}
