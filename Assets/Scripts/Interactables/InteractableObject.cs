using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CelesteEngine.Interactables
{
    public abstract class InteractableObject : MonoBehaviour
    {
        public KeyCode interactKey = KeyCode.UpArrow;

        private bool interactable = false;

        public void Update()
        {
            if (interactable && Input.GetKeyUp(interactKey))
            {
                OnInteraction();
            }
        }

        public void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Player"))
            {
                interactable = true;
                OnPlayerCanInteract();
            }
        }

        public void OnTriggerExit2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Player"))
            {
                interactable = false;
                OnPlayerCantInteract();
            }
        }

        protected abstract void OnInteraction();

        protected virtual void OnPlayerCanInteract() { }
        protected virtual void OnPlayerCantInteract() { }
    }
}