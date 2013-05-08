using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using WebcamExtension.Presentation.Controls;

namespace LightSwitchApplication
{
    public partial class AddCustomer
    {
        private WebcamControl WebCam;
        partial void AddCustomer_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.Table1ItemProperty = new Table1Item();
        }

        partial void AddCustomer_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.Table1ItemProperty);
        }

        partial void AddCustomer_Created()
        {
            // Write your code here.
            var ctrl = this.FindControl("ScreenContent");
            ctrl.ControlAvailable += new EventHandler<ControlAvailableEventArgs>(WebCamHandler);

        }

        public void WebCamHandler(object sender, ControlAvailableEventArgs e)
        {
            this.WebCam = (WebcamControl)e.Control;
            this.WebCam.CaptureCompleted += new WebcamControl.CaptureCompletedEventHandler(WebCam_CaptureCompleted);
        }

        public void WebCam_CaptureCompleted()
        {
            this.Table1ItemProperty.picture = this.WebCam.CapturedImage;
        }
    }
}