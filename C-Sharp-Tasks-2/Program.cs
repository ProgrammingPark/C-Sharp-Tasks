using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    static class Program
    {
        static void Main(string[] args)
        {
            Language currentLanguage = Language.RU;
            Console.WriteLine(currentLanguage.GetDescription());
            Console.ReadKey();
        }

        public static string GetDescription(this Enum value)
        {
            if (value == null)
                return string.Empty;

            var member = value.GetType().GetMember(value.ToString()).FirstOrDefault();
            var description = member?.GetCustomAttribute<DescriptionAttribute>()?.Description;

            return description ?? string.Empty;
        }
    }

    public enum Language
    {
        [Description("Russian")]
        RU,
        [Description("Latvian")]
        LV,
        [Description("English")]
        EN
    }
}
