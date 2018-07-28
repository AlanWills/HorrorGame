using CelesteEngine.Environment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CelesteEngine.Interactables
{
    public class GravityConsole : InteractableObject
    {
        protected override void OnInteraction()
        {
            GravityManager.GravityEnabled = !GravityManager.GravityEnabled;
        }
    }
}