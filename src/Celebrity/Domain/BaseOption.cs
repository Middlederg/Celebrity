namespace Celebrity
{
    public class BaseOption<T>
    {
        public T Entity { get; }
        public bool IsChecked { get; set; }
        public void Toggle() => IsChecked = !IsChecked;

        public BaseOption(T entity, bool isChecked)
        {
            Entity = entity;
            IsChecked = isChecked;
        }

        public override string ToString() => Entity.ToString();
    }
}
