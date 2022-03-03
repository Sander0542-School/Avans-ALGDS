using System;
using System.Collections.Generic;

namespace Alg1.Practica.Practicum5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var xmls = new Dictionary<string, bool>
            {
                ["<html><body>Hallo Wereld</html></body>"] = false,
                ["<html>Hallo Wereld</html>"] = true,
                ["<html>Hallo Wereld</hmtl>"] = false,
                ["<html><body>Hallo Wereld</body>"] = false,
                ["<html><body>Hallo Wereld</body></html>"] = true,
                ["<html><body><i>Hallo</i> <b>Wereld</b> !</body></html>"] = true,
                ["<html><body>Hallo Wereld</body></html></xml>"] = false,
                ["<html><body>Hallo Wereld</html>"] = false,
            };
            
            var validator = new XmlValidator();

            foreach (var xml in xmls)
            {
                bool result = validator.Validate(xml.Key);
                Console.WriteLine($"{xml.Key}: Excepted: {xml.Value}; Result: {result}; Success: {xml.Value == result}");
            }
        }
    }
}