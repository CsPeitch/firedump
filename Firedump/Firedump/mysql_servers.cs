//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Firedump
{
    using System;
    using System.Collections.Generic;
    
    public partial class mysql_servers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mysql_servers()
        {
            this.schedules = new HashSet<schedules>();
        }
    
        public long id { get; set; }
        public string name { get; set; }
        public long port { get; set; }
        public string host { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<schedules> schedules { get; set; }
    }
}
