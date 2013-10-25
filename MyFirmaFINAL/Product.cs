using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirma
{
    public class Product
    {
        string _name, _category, _imagePath, _description;
        private string _strAvailabled;
        private bool _available, _unavailable, _preOrader;
        private double _price;

        #region свойства доступа
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public string Image_path
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public bool Available
        {
            get { return _available; }
            set { _available = value; }
        }
        public bool Unavailable
        {
            get { return _unavailable; }
            set { _unavailable = value; }
        }
        public bool PreOrder
        {
            get { return _preOrader; }
            set { _preOrader = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string StrAvailabled
        {
            get { return _strAvailabled; }
            set { _strAvailabled = value; }
        }

        #endregion
        
        public Product()
        {
            StrAvailabled = "";
            _name = "";
            _category = "";
            _imagePath = "";
            _description = "";
            _available = false;
            _unavailable = false;
            _preOrader = false;
            _price = 0;
        }
        public Product(string name, string category, string description, string price, string imagePath, string availabled)// for XML reading
        {
            _name = name;
            _category = category;
            _imagePath = imagePath;
            _description = description;
            _available = false;
            _unavailable = false;
            _preOrader = false;
            _price = 0;
            _strAvailabled = availabled;
            if(!string.IsNullOrEmpty(availabled))// is availabled product? 
            {
                if (availabled == "YES")
                    _available = true;
                else if (availabled == "NO")
                    _unavailable = true;
                else if(availabled == "PreOrder") 
                    _preOrader = true;
           }
           double.TryParse(price, out _price);
        }

        public Product(string name, string category, string description, string price, string imagePath, bool available, bool unavailable, bool preOrder)// for dialog creating
            : this(name, category, description, price, imagePath, null)
        {
            _available = available;
            _unavailable = unavailable;
            _preOrader = preOrder;
            if (_available)
                StrAvailabled = "YES";
            else if (_preOrader)
                StrAvailabled = "PreOrder";
            else StrAvailabled = "NO";
        }

        //public Product(string name, string category, string description, string price, string imagePath, bool available, bool unavailable, bool preOrder)// for dialog
        //{
        //    _name = name;
        //    _category = category;
        //    _imagePath = imagePath;
        //    _description = description;
        //    _available = available;
        //    _unavailable = unavailable;
        //    _preOrader = preOrder;
        //    _price = 0;
            
        //    double.TryParse(price, out _price);
        //}
    }
    
}
