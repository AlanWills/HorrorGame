using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace CelesteEngine.Interactables
{
    public class ObjectActivator : InteractableObject
    {
        public GameObject objectToActivate;

        protected override void OnInteraction()
        {
            objectToActivate.SetActive(true);
        }

        protected override void OnPlayerCantInteract()
        {
            base.OnPlayerCantInteract();

            objectToActivate.SetActive(false);
        }
    }
}
