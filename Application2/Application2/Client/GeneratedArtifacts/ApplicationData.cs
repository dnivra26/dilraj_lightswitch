﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 5/8/2013 10:55:59 PM
namespace LightSwitchApplication.Implementation
{
    
    /// <summary>
    /// There are no comments for ApplicationDataObjectContext in the schema.
    /// </summary>
    public partial class ApplicationDataObjectContext : global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext
    {
        /// <summary>
        /// Initialize a new ApplicationDataObjectContext object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public ApplicationDataObjectContext(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("LightSwitchApplication", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("LightSwitchApplication.Implementation", typeName.Substring(22)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("LightSwitchApplication.Implementation", global::System.StringComparison.Ordinal))
            {
                return string.Concat("LightSwitchApplication.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Table1Items in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Table1Item> Table1Items
        {
            get
            {
                if ((this._Table1Items == null))
                {
                    this._Table1Items = base.CreateQuery<Table1Item>("Table1Items");
                }
                return this._Table1Items;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Table1Item> _Table1Items;
        /// <summary>
        /// There are no comments for Table1Items in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToTable1Items(Table1Item table1Item)
        {
            base.AddObject("Table1Items", table1Item);
        }
    }
    /// <summary>
    /// There are no comments for LightSwitchApplication.Table1Item in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Table1Items")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Table1Item : global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityBase, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Table1Item object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="rowVersion">Initial value of RowVersion.</param>
        /// <param name="name">Initial value of name.</param>
        /// <param name="father_name">Initial value of father_name.</param>
        /// <param name="dob">Initial value of dob.</param>
        /// <param name="phone">Initial value of phone.</param>
        /// <param name="address1">Initial value of address1.</param>
        /// <param name="city">Initial value of city.</param>
        /// <param name="state">Initial value of state.</param>
        /// <param name="country">Initial value of country.</param>
        /// <param name="zipcode">Initial value of zipcode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Table1Item CreateTable1Item(int ID, byte[] rowVersion, string name, string father_name, global::System.DateTime dob, string phone, string address1, string city, string state, string country, double zipcode)
        {
            Table1Item table1Item = new Table1Item();
            table1Item.Id = ID;
            table1Item.RowVersion = rowVersion;
            table1Item.name = name;
            table1Item.father_name = father_name;
            table1Item.dob = dob;
            table1Item.phone = phone;
            table1Item.address1 = address1;
            table1Item.city = city;
            table1Item.state = state;
            table1Item.country = country;
            table1Item.zipcode = zipcode;
            return table1Item;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                if (object.Equals(this.Id, value))
                {
                    return;
                }
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property RowVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public byte[] RowVersion
        {
            get
            {
                if ((this._RowVersion != null))
                {
                    return ((byte[])(this._RowVersion.Clone()));
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnRowVersionChanging(value);
                if (object.Equals(this.RowVersion, value))
                {
                    return;
                }
                this._RowVersion = value;
                this.OnRowVersionChanged();
                this.OnPropertyChanged("RowVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private byte[] _RowVersion;
        partial void OnRowVersionChanging(byte[] value);
        partial void OnRowVersionChanged();
        /// <summary>
        /// There are no comments for Property name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this.OnnameChanging(value);
                if (object.Equals(this.name, value))
                {
                    return;
                }
                this._name = value;
                this.OnnameChanged();
                this.OnPropertyChanged("name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _name;
        partial void OnnameChanging(string value);
        partial void OnnameChanged();
        /// <summary>
        /// There are no comments for Property father_name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string father_name
        {
            get
            {
                return this._father_name;
            }
            set
            {
                this.Onfather_nameChanging(value);
                if (object.Equals(this.father_name, value))
                {
                    return;
                }
                this._father_name = value;
                this.Onfather_nameChanged();
                this.OnPropertyChanged("father_name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _father_name;
        partial void Onfather_nameChanging(string value);
        partial void Onfather_nameChanged();
        /// <summary>
        /// There are no comments for Property dob in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime dob
        {
            get
            {
                return this._dob;
            }
            set
            {
                this.OndobChanging(value);
                if (object.Equals(this.dob, value))
                {
                    return;
                }
                this._dob = value;
                this.OndobChanged();
                this.OnPropertyChanged("dob");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _dob;
        partial void OndobChanging(global::System.DateTime value);
        partial void OndobChanged();
        /// <summary>
        /// There are no comments for Property phone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string phone
        {
            get
            {
                return this._phone;
            }
            set
            {
                this.OnphoneChanging(value);
                if (object.Equals(this.phone, value))
                {
                    return;
                }
                this._phone = value;
                this.OnphoneChanged();
                this.OnPropertyChanged("phone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _phone;
        partial void OnphoneChanging(string value);
        partial void OnphoneChanged();
        /// <summary>
        /// There are no comments for Property address1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string address1
        {
            get
            {
                return this._address1;
            }
            set
            {
                this.Onaddress1Changing(value);
                if (object.Equals(this.address1, value))
                {
                    return;
                }
                this._address1 = value;
                this.Onaddress1Changed();
                this.OnPropertyChanged("address1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _address1;
        partial void Onaddress1Changing(string value);
        partial void Onaddress1Changed();
        /// <summary>
        /// There are no comments for Property address2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string address2
        {
            get
            {
                return this._address2;
            }
            set
            {
                this.Onaddress2Changing(value);
                if (object.Equals(this.address2, value))
                {
                    return;
                }
                this._address2 = value;
                this.Onaddress2Changed();
                this.OnPropertyChanged("address2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _address2;
        partial void Onaddress2Changing(string value);
        partial void Onaddress2Changed();
        /// <summary>
        /// There are no comments for Property city in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string city
        {
            get
            {
                return this._city;
            }
            set
            {
                this.OncityChanging(value);
                if (object.Equals(this.city, value))
                {
                    return;
                }
                this._city = value;
                this.OncityChanged();
                this.OnPropertyChanged("city");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _city;
        partial void OncityChanging(string value);
        partial void OncityChanged();
        /// <summary>
        /// There are no comments for Property state in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string state
        {
            get
            {
                return this._state;
            }
            set
            {
                this.OnstateChanging(value);
                if (object.Equals(this.state, value))
                {
                    return;
                }
                this._state = value;
                this.OnstateChanged();
                this.OnPropertyChanged("state");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _state;
        partial void OnstateChanging(string value);
        partial void OnstateChanged();
        /// <summary>
        /// There are no comments for Property country in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string country
        {
            get
            {
                return this._country;
            }
            set
            {
                this.OncountryChanging(value);
                if (object.Equals(this.country, value))
                {
                    return;
                }
                this._country = value;
                this.OncountryChanged();
                this.OnPropertyChanged("country");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _country;
        partial void OncountryChanging(string value);
        partial void OncountryChanged();
        /// <summary>
        /// There are no comments for Property zipcode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public double zipcode
        {
            get
            {
                return this._zipcode;
            }
            set
            {
                this.OnzipcodeChanging(value);
                if (object.Equals(this.zipcode, value))
                {
                    return;
                }
                this._zipcode = value;
                this.OnzipcodeChanged();
                this.OnPropertyChanged("zipcode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private double _zipcode;
        partial void OnzipcodeChanging(double value);
        partial void OnzipcodeChanged();
        /// <summary>
        /// There are no comments for Property picture in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public byte[] picture
        {
            get
            {
                if ((this._picture != null))
                {
                    return ((byte[])(this._picture.Clone()));
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnpictureChanging(value);
                if (object.Equals(this.picture, value))
                {
                    return;
                }
                this._picture = value;
                this.OnpictureChanged();
                this.OnPropertyChanged("picture");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private byte[] _picture;
        partial void OnpictureChanging(byte[] value);
        partial void OnpictureChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}