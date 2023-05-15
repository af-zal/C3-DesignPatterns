using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational
{
    public class House //complex obj to build
    {
        public string Foundation { get; set; }
        public string Walls { get; set; }
        public string Roof { get; set; }
        public string Windows { get; set; }
        public string Doors { get; set; }
    }

    public interface IHouseBuilder
    {
        void BuildFoundation();
        void BuildWalls();
        void BuildRoof();
        void BuildWindows();
        void BuildDoors();
        House GetHouse();
    }

    public class HouseBuilder : IHouseBuilder //to build a House
    {
        private House _house = new House();

        public void BuildFoundation()
        {
            _house.Foundation = "Concrete";
        }

        public void BuildWalls()
        {
            _house.Walls = "Brick";
        }

        public void BuildRoof()
        {
            _house.Roof = "Tile";
        }

        public void BuildWindows()
        {
            _house.Windows = "Glass";
        }

        public void BuildDoors()
        {
            _house.Doors = "Wooden";
        }

        public House GetHouse()
        {
            return _house;
        }
    }

    public class Director
    {
        private IHouseBuilder _builder;

        public Director(IHouseBuilder builder)
        {
            _builder = builder;
        }

        public void BuildHouse()
        {
            _builder.BuildFoundation();
            _builder.BuildWalls();
            _builder.BuildRoof();
            _builder.BuildWindows();
            _builder.BuildDoors();
        }
    }

}
