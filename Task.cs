//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DailyToDoManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public Task()
        {
            this.TaskUsers = new HashSet<TaskUser>();
        }
    
        public int TaskId { get; set; }
        public string Todo { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public string State { get; set; }
    
        public virtual ICollection<TaskUser> TaskUsers { get; set; }
    }
}
