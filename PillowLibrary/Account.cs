using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PillowLibrary
{
    public class Account
    {
        private string name;
        private string street;
        private string city;
        private string state;
        private string zipCode;
        private string phoneNumber;
        private string email;
        private string username;
        private string password;
        private string company;
        private string workAddress;
        private string workCity;
        private string workState;
        private string workZip;
        private string workPhone;
        private string workEmail;
        private ArrayList agentInfo = new ArrayList();

        public Account(string _name, string _street, string _city, string _state, string _zipCode, string _phoneNumber, string _email, string _username, string _password, string _company, string _workAddress, string _workCity, string _workState, string _workZip, string _workPhone, string _workEmail)
        {
            this.name = _name;
            this.street = _street;
            this.city = _city;
            this.state = _state;
            this.zipCode = _zipCode;
            this.phoneNumber = _phoneNumber;
            this.email = _email;
            this.username = _username;
            this.password = _password;
            this.company = _company;
            this.workAddress = _workAddress;
            this.workCity = _workCity;
            this.workState = _workState;
            this.workZip = _workZip;
            this.workPhone = _workPhone;
            this.workEmail = _workEmail;

            agentInfo.Add(_name);
            agentInfo.Add(_street);
            agentInfo.Add(_city);
            agentInfo.Add(_state);
            agentInfo.Add(_zipCode);
            agentInfo.Add(_phoneNumber);
            agentInfo.Add(_email);
            agentInfo.Add(_username);
            agentInfo.Add(_password);
            agentInfo.Add(_company);
            agentInfo.Add(_workAddress);
            agentInfo.Add(_workCity);
            agentInfo.Add(_workState);
            agentInfo.Add(_workZip);
            agentInfo.Add(_workPhone);
            agentInfo.Add(_workEmail);
        }

        public ArrayList AgentInfo
        {
            get { return agentInfo; }
            set { agentInfo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
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
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        public string WorkAddress
        {
            get { return workAddress; }
            set { workAddress = value; }
        }
        public string WorkCity
        {
            get { return workCity; }
            set { workCity = value; }
        }
        public string WorkState
        {
            get { return workState; }
            set { workState = value; }
        }
        public string WorkZip
        {
            get { return workZip; }
            set { workZip = value; }
        }
        public string WorkPhone
        {
            get { return workPhone; }
            set { workPhone = value; }
        }
        public string WorkEmail
        {
            get { return workEmail; }
            set { workEmail = value; }
        }
        
    }
}
