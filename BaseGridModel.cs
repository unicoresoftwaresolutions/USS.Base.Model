using System.IO.Pipes;

namespace USS.Base.Model
{
    public class BaseGridModel<T> : BaseModel where T : BaseEntityModel, new ()
    {
        public T data { get; set; }
        public T EditData { get; set; }
        public bool IsEdit { get; set; }      
    }
}
