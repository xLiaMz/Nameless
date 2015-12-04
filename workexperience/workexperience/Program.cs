using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workexperience
{
    public class Movie
    {
        public string name;
        public string[] times = new string[4];
        public Movie(string p_name, string[] p_times)
        {
            name = p_name;
            times = p_times;
        }
        public string GetTimes()
        {
            return times[0] + times[1] + times[2] + times[3];
        }
    }

    class Program
    {      
        static void Main(string[] args)
        {

           // Movie Movie1 = new Movie("James Bond: Spectre (1)", new string[4] {  "12:00, ", "14:00, ", "17:00, ", "20:00" });
           // Movie Movie2 = new Movie("Star Wars: VII (2)", new string[4] { "11:00, ", "13:00, ", "16:00, ", "19:00" });
           // Movie Movie3 = new Movie("Hunger Games: Mocking Jay II (3)", new string[4] { "13:00, ", "15:00, ", "19:00, ", "22:00" });

            Movie[] movieDatabase = new Movie[10]{
                new Movie("James Bond: Spectre (1) ", new string[4] { "12:00, ", "14:00, ", "17:00, ", "20:00" }),
                new Movie("Star Wars: VII (2) ", new string[4] { "11:00, ", "13:00, ", "16:00, ", "19:00" }),
                new Movie("Hunger Games: Mocking Jay II (3) ", new string[4] { "13:00, ", "15:00, ", "19:00, ", "22:00" }),
                new Movie("Ratchet & Clank (4) ", new string[4] {"13:00, ", "15:00, ", "19:00, ", "22:00"}),
                new Movie("Minions (5) ", new string[4] { "12:00, ", "14:00, ", "17:00, ", "20:00" }),
                new Movie("Boruto (6) ", new string[4] { "11:00, ", "13:00, ", "16:00, ", "19:00" }),
                new Movie("One Piece (7) ", new string[4] { "13:00, ", "15:00, ", "19:00, ", "22:00" }),
                new Movie("Attack on Titan (8) ", new string[4] {"13:00, ", "15:00, ", "19:00, ", "22:00"}),
                new Movie("Kung Foo Panda 3 (9) ", new string[4] { "13:00, ", "15:00, ", "19:00, ", "22:00" }),
                new Movie("Home (10) ", new string[4] {"13:00, ", "15:00, ", "19:00, ", "22:00"})

            };
            
            Console.WriteLine("Please select a movie - Out of 1, 2 and 3 ");
            for (int i = 0; i < movieDatabase.Length; i++)
            {
                Console.WriteLine(movieDatabase[i].name);
            }

            while (true)
            {
                int choice = int.Parse(Console.ReadLine()) -1;
                Console.WriteLine(movieDatabase[choice].name + movieDatabase[choice].GetTimes());
            }
        }
    }
}
