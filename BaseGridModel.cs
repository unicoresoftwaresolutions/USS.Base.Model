using System.IO.Pipes;

namespace USS.Base.Model
{
    public class BaseGridModel<T> where T : BaseEntityModel
    {
        public T data { get; set; }
        public T EditData { get; set; }
        public bool IsEdit { get; set; }      

        public dynamic this[string PropName]
        {
            get
            {
                return GetType().GetProperty(PropName).GetValue(this); ;
            }
            set
            {
                GetType().GetProperty(PropName).SetValue(this, value);
            }
        }
    }
}
