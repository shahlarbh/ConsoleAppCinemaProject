using Core.Models;
namespace ConsoleAppCinemaProject.Models
{
    internal class CinemaPlus : Entity
    {
        internal string Name { get; set; }
        internal Cinema[] Cinemas { get; set; } = new Cinema[3];

        public override string ToString()
        {
            string cinemas = "";

            foreach (var item in Cinemas)
            {
                if(item == null)
                    continue;

                cinemas += item.ToString() + "\n";
            }

            return $"{Id} {Name}\nCinemas:\n{cinemas}";
        }
    }
}
