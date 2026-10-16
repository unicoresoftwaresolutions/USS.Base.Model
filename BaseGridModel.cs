namespace USS.Base.Model
{
    public class BaseGridModel<T> where T : new()
    {
        public T data { get; set; }
        public T EditData { get; set; }
        public bool IsEdit { get; set; }
    }
}
