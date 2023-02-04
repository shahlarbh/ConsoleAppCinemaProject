using ConsoleAppCinemaProject.Enum;
using Core.Models;

namespace ConsoleAppCinemaProject.Models
{
    internal class Session : Entity
    {
        internal Cinema Cinema { get; set; }
        internal Hall Hall { get; set; }
        internal Film Film { get; set; }
        internal State[,] Seats { get; set; }
        internal int CinemaId { get; set; }
        internal double Price { get; set; }

        public override string ToString()
        {
            return $"{"ID:",-7} {Id}\n{"Cinema:",-7} {Cinema.Name}\n{"Hall:",-7} {Hall}\n{"Film:",-7} {Film}\n{"Price:",-7} {Price}AZN\n{"Place:",-7}";
        }
    }
}
