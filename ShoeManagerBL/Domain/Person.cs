using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeManagerBL.Domain
{
    public class Person : BaseEntity<int>
    {

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Gender { get; set; }
        //public virtual int Id { get; set; }
    }
}
