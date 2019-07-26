namespace Celebrity.Model
{
    public class Color
    {
        private readonly string nombre;
        private readonly System.Drawing.Color color;
        public System.Drawing.Color GetColor => color;

        public Color(System.Drawing.Color selectedColor)
        {
            nombre = selectedColor.Name;
            color = selectedColor;
        }

        private Color(string nombre, System.Drawing.Color color)
        {
            this.nombre = nombre;
            this.color = color;
        }

        public static Color Azul => new Color("Azul", System.Drawing.Color.FromArgb(41, 128, 185));
        public static Color Rojo => new Color("Rojo", System.Drawing.Color.Red);
        public static Color Verde => new Color("Verde", System.Drawing.Color.Green);

        public override bool Equals(object obj)
        {
            if (obj is Color c)
                return c.color == color;
            return false;
        }

        public override int GetHashCode() => nombre.GetHashCode();
        public override string ToString() => nombre;        
    }
}
