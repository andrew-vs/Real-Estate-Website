using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PillowLibrary
{
    public class NewHome
    {
        private string agentID;
        private string street;
        private string city;
        private string state;
        private string zip;
        private string propertyType;
        private int squareFt;
        private int bedrooms;
        private int bathrooms;
        private int yearBuilt;
        private string garageType;
        private string waterType;
        private string sewageType;
        private string heatingType;
        private string coolingType;
        private double askingPrice;
        private string description;
        private DateTime listingDate;
        public NewHome()
        {

        }

        public NewHome(string _agentID, string _street, string _city, string _state, string _zip, string _propertyType, int _squareFt, int _bedrooms, int _bathrooms, int _yearBuilt, string _garageType, string _waterType, string _sewageType, string _heatingType, string _coolingType, double _askingPrice, string _description, DateTime _listingDate)
        {
            this.agentID = _agentID;
            this.street = _street;
            this.city = _city;
            this.state = _state;
            this.zip = _zip;
            this.propertyType = _propertyType;
            this.squareFt = _squareFt;
            this.bedrooms = _bedrooms;
            this.bathrooms = _bathrooms;
            this.yearBuilt = _yearBuilt;
            this.garageType = _garageType;
            this.waterType = _waterType;
            this.sewageType = _sewageType;
            this.heatingType = _heatingType;
            this.coolingType = _coolingType;
            this.askingPrice = _askingPrice;
            this.description = _description;
            this.listingDate = _listingDate;
            
        }
       

        public string AgentID
        {
            get { return agentID; }
            set { agentID = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }
        public string PropertyType
        {
            get { return propertyType; }
            set { propertyType = value; }
        }
        public int SquareFt
        {
            get { return squareFt; }
            set { squareFt = value; }
        }
        public int Bedrooms
        {
            get { return bedrooms; }
            set { bedrooms = value; }
        }
        public int Bathrooms
        {
            get { return bathrooms; }
            set { bathrooms = value; }
        }
        public int YearBuilt
        {
            get { return yearBuilt; }
            set { yearBuilt = value; }
        }
        public string GarageType
        {
            get { return garageType; }
            set { garageType = value; }
        }
        public string SewageType
        {
            get { return sewageType; }
            set { sewageType = value; }
        }
        public string WaterType
        {
            get { return waterType; }
            set { waterType = value; }
        }
        public string HeatingType
        {
            get { return heatingType; }
            set { heatingType = value; }
        }
        public string CoolingType
        {
            get { return coolingType; }
            set { coolingType = value; }
        }
        public double AskingPrice
        {
            get { return askingPrice; }
            set { askingPrice = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public DateTime ListingDate
        {
            get { return listingDate; }
            set { listingDate = value; }
        }
    }
}
