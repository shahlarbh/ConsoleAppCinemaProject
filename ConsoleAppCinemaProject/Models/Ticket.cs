using Core.Models;

namespace ConsoleAppCinemaProject.Models
{
    internal class Ticket : Entity
    {
        private static int Id;
        internal Session Session { get; set; }
        internal int Row { get; set; }
        internal int Column { get; set; }

        public override string ToString()
        {
            return $"{Session} {Row}x{Column}";
        }
    }
}
