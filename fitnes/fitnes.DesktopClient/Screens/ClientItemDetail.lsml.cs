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
    public partial class ClientItemDetail
    {
        partial void ClientItem_Loaded(bool succeeded)
        {
            // Добавьте сюда свой код.
            this.SetDisplayNameFromEntity(this.ClientItem);
        }

        partial void ClientItem_Changed()
        {
            // Добавьте сюда свой код.
            this.SetDisplayNameFromEntity(this.ClientItem);
        }

        partial void ClientItemDetail_Saved()
        {
            // Добавьте сюда свой код.
            this.SetDisplayNameFromEntity(this.ClientItem);
        }
    }
}