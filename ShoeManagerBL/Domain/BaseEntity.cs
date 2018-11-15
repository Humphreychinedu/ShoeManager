using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeManagerBL.Domain
{
   public class BaseEntity<T> where T : struct
    {
        public virtual T Id { get; set; }
    }
}
