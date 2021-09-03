namespace Celebrity.Web
{
    public class Constants
    {
        public const string Primary = "blue-800";
        public const string PrimaryLighter = "blue-700";
        public const string PrimaryDarker = "blue-900";

        public static string InputStyle => $"p-3 w-80 focus:border-{Primary} rounded-lg border-2 outline-none border-blue-300";

        public static string Button = $"text-white bg-{Primary} hover:bg-{PrimaryLighter} border-{Primary}  hover:border-{PrimaryLighter}";
        public static string ButtonOutlined = $"text-{Primary} hover:bg-{Primary} border-{Primary}";
    }

}
