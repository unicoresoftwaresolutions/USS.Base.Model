using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace USS.Base.Model
{
    public class BaseEntityModel : ICloneable
    {
        public Guid Id { get; set; }
        public dynamic this[string PropName] 
        {
            get
            {
                try
                {
                    return GetType().GetProperty(PropName).GetValue(this);
                }catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
                return string.Empty;
            }
            set
            {
                GetType().GetProperty(PropName).SetValue(this,value);
            } 
        }
        public virtual object Clone()
        {
            return MemberwiseClone();
        }
    }
}
