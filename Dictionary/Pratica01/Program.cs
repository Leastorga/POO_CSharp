using System;

namespace Pratica01  {
    class Program {
        static void Main(string[] args) {

            Dictionary<string,string> cookies = new();

            cookies["User"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "99712235"; // Não tolera repetições logo o valor é subescrito

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");
            if(cookies.ContainsKey("email")){
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("All cookies: ");
            foreach (KeyValuePair<string, string> item in cookies)
            {
             Console.WriteLine(item.Key + ": " + item.Value);  
            }
        }
    }
}