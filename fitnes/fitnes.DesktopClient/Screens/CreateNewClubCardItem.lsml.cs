﻿using System;
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
    public partial class CreateNewClubCardItem
    {
        partial void CreateNewClubCardItem_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Добавьте сюда свой код.
            this.ClubCardItemProperty = new ClubCardItem();
        }

        partial void CreateNewClubCardItem_Saved()
        {
            // Добавьте сюда свой код.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.ClubCardItemProperty);
        }
    }
}