using System;
using System.Collections.Generic;
using System.Text;

namespace USS.Base.Model
{
    public class BaseModel : ICloneable
    {
        public dynamic this[string PropName]
        {
            get
            {
                try
                {
                    return GetType().GetProperty(PropName).GetValue(this);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                return string.Empty;
            }
            set
            {
                var prop = GetType().GetProperty(PropName);
                if (prop != null)
                {
                    if(value is null || prop.PropertyType == typeof(string) || prop.PropertyType == typeof(bool))
                    {
                        prop.SetValue(this, value);
                    }
                    else if (prop.PropertyType == typeof(DateOnly) || prop.PropertyType == typeof(DateOnly?))
                    {
                        value = DateOnly.Parse(value);
                    }
                    else if (prop.PropertyType == typeof(DateTime) || prop.PropertyType == typeof(DateTime?))
                    {
                        value = DateTime.Parse(value);
                    }
                    else if (prop.PropertyType == typeof(Single) || prop.PropertyType == typeof(Single?))
                    {
                        value = Single.Parse(value);
                    }
                    else if (prop.PropertyType == typeof(Int32) || prop.PropertyType == typeof(Int32?))
                    {
                        value = Int32.Parse(value);
                    }
                    else if (prop.PropertyType == typeof(Double) || prop.PropertyType == typeof(Double?))
                    {
                        value = Double.Parse(value);
                    }
                    else if (prop.PropertyType == typeof(Decimal) || prop.PropertyType == typeof(Decimal?))
                    {
                        value = Decimal.Parse(value);
                    }
                    else if (prop.PropertyType == typeof(Int64) || prop.PropertyType == typeof(Int64?))
                    {
                        value = Int64.Parse(value);
                    }
                    else if (prop.PropertyType == typeof(Int16) || prop.PropertyType == typeof(Int16?))
                    {
                        value = Int16.Parse(value);
                    }
                    else if (prop.PropertyType == typeof(Byte) || prop.PropertyType == typeof(Byte?))
                    {
                        value = Byte.Parse(value);
                    }
                    else if (prop.PropertyType == typeof(SByte) || prop.PropertyType == typeof(SByte?))
                    {
                        value = SByte.Parse(value);
                    }
                    else if (prop.PropertyType == typeof(UInt16) || prop.PropertyType == typeof(UInt16?))
                    {
                        value = UInt16.Parse(value);
                    }
                    else if (prop.PropertyType == typeof(UInt32) || prop.PropertyType == typeof(UInt32?))
                    {
                        value = UInt32.Parse(value);
                    }
                    else if (prop.PropertyType == typeof(UInt64) || prop.PropertyType == typeof(UInt64?))
                    {
                        value = UInt64.Parse(value);
                    }
                    prop.SetValue(this, value);
                }
            }
        }
        public virtual object Clone()
        {
            return MemberwiseClone();
        }
    }
}
