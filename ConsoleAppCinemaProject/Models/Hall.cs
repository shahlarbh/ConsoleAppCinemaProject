using Core.Models;

namespace ConsoleAppCinemaProject.Models
{
    internal class Hall : Entity
    {
        internal string Name { get; set; }
        internal int RowCount { get; set; }
        internal int ColumnCount { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {RowCount}x{ColumnCount}";
        }
    }
}
