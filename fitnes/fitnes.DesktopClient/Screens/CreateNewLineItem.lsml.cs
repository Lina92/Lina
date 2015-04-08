using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class CreateNewLineItem
    {
        partial void CreateNewLineItem_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Добавьте сюда свой код.
            this.LineItemProperty = new LineItem();
        }

        partial void CreateNewLineItem_Saved()
        {
            // Добавьте сюда свой код.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.LineItemProperty);
        }
    }
}