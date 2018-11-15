using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeManagerBL.Domain
{
    public class Shoe : BaseEntity<int>
    {
        public virtual string Brand { get; set; }
        public virtual string Name { get; set; }
    }
}
