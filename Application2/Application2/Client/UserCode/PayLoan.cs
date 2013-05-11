using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;


using System.ComponentModel;
using Microsoft.LightSwitch.Threading;
using System.ServiceModel.DomainServices.Client;


namespace LightSwitchApplication
{
    public partial class PayLoan
    {
        partial void PayLoan_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.Loan_PayProperty = new Loan_Pay();
        }

        partial void PayLoan_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.Loan_PayProperty);
            
        }

        partial void PayLoan_Created()
        {
            // Write your code here.
            Dispatchers.Main.BeginInvoke(() =>
            {
                ((INotifyPropertyChanged)this.Loan_PayProperty).PropertyChanged +=
                    new PropertyChangedEventHandler(CreateNewStudent_PropertyChanged);
            });


        }
        void CreateNewStudent_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Property3 = this.Loan_PayProperty.Customer.name;
        }

    }
}