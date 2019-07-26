using System;

namespace Celebrity.Model
{
    public class ComboBaseItem
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public override string ToString() => Text;
        public override bool Equals(object obj)
        {
            if (obj is ComboBaseItem item)
                return Value.Equals(item.Value);
            return false;
        }
        public override int GetHashCode() => Value.GetHashCode();
    }
}
