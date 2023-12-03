using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pererobka8
{
    static void Main(string[] args)
    {
        var configurationManager = ConfigurationManager.Instance;

        // Зміна конфігураційних налаштувань

        Console.WriteLine("Введіть ключ конфігурації:");
        string key = Console.ReadLine();

        Console.WriteLine("Введіть значення конфігурації:");
        string value = Console.ReadLine();

        configurationManager.SetSetting(key, value);

        // Збереження конфігураційних налаштувань

        configurationManager.Save();

        // Перевірка, що зміни відображені

        Console.WriteLine("Значення конфігурації для ключа {0}: {1}", key, configurationManager.GetSetting(key));
    }
}