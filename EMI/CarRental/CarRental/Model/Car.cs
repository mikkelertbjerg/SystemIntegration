using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Model
{
    class Car
    {
        #region Instancefields
        private int _carId;
        private int _doors;
        private string _fuelType;
        private string _type;
        private float _price;
        private bool _animalsAllowed;
        #endregion

        #region Constructor
        public Car(int carId, int doors, string fuelType, string type, float price, bool animals)
        {
            _carId = carId;
            _doors = doors;
            _fuelType = fuelType;
            _type = type;
            _price = price;
            _animalsAllowed = animals;
        }
        #endregion

        #region Properties
        public int Doors 
        {
            get { return _doors; }
            set { _doors = value; }
        }
        public string FuelType
        {
            get { return _fuelType; }
            set { _fuelType = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public bool AnimalsAllowed
        {
            get { return _animalsAllowed; }
            set { _animalsAllowed = value; }
        }
        #endregion
    }
}
