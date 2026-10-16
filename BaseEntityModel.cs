using System;
using System.Collections.Generic;
using System.Text;

namespace USS.Base.Model
{
    public class BaseEntityModel : ICloneable
    {
        public Guid Id { get; set; }

        public virtual object Clone()
        {
            return MemberwiseClone();
        }
    }
}
