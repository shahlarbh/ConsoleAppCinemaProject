using Core.Models;

namespace ConsoleAppCinemaProject.Models
{
    internal class Cinema : Entity
    {
        internal string Name { get; set; }
        internal Hall[] Halls { get; set; } = new Hall[3];

        public override string ToString()
        {
            string halls = "";

            foreach (var item in Halls)
            {
                if(item == null)
                    continue;

                halls += item.ToString() + "\n";
            }

            return $"{Id} {Name}\nHalls:\n{halls}";
        }
    }
}
