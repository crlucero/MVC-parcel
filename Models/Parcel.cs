using System.Collections.Generic;

namespace Parcels.Models
{
    public class Parcel
    {
        private int _weight;
        private int _length;
        private int _width;
        private int _cost;

        public Parcel(int weight, int length, int width)
        {
            _weight = weight;
            _length = length;
            _width = width;
        }

        public int ParcelCost ()
        {
            _cost = _weight + _length * _width;
            return _cost;
        }
    }
}