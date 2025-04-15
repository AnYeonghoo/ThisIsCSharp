using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter18
{
    internal class SerializingCollection
    {
        static void MainSerializingCollection()
        {
            var fileName = "a.json";
            using (Stream ws = new FileStream(fileName, FileMode.Create))
            {
                var list = new List<NameCard>();
                list.Add(new NameCard() { Name = "dasd", Phone = "2123", Age = 33 });
                list.Add(new NameCard() { Name = "asdas", Phone = "123213", Age=32 });

                string jsonString = JsonSerializer.Serialize<List<NameCard>>(list);
                byte[] jsonBytes = System.Text.Encoding.UTF8.GetBytes(jsonString);
                ws.Write(jsonBytes, 0, jsonBytes.Length);

            }

            using (Stream rs = new FileStream(fileName, FileMode.Open))
            {
                byte[] json = new byte[rs.Length];
                rs.Read(json, 0, json.Length);
                string jString = System.Text.Encoding.UTF8.GetString(json);

                var list2 = JsonSerializer.Deserialize<List<NameCard>>(jString);

                foreach (NameCard d in list2)
                {
                    Console.WriteLine(d.Name);
                }
            }
        }
    }
}
