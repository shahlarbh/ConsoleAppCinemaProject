using Core.Models;

namespace ConsoleAppCinemaProject.Models
{
    internal class Film : Entity
    {
        internal string Name { get; set; }
        internal int Minute { get; set; }

        public override string ToString()
        {
            return $"{"ID:",-7} {Id}\n{"Name:",-7} {Name}\n{"Minute:",-7} {Minute}";
        }
    }
}
