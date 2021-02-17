using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace Behaviors
{
    public class KeyPickup : MonoBehaviour, IInteractable
    {
        private Inventory playerInv;
        private void Awake()
        {
            this.playerInv = GameObject.FindWithTag("Player").GetComponent<Inventory>();
        }

        public void Interact()
        {
            switch (this.gameObject.transform.name)
            {
                case "Key01":
                    playerInv.key1 = true;
                    break;
                case "Key02":
                    playerInv.key2 = true;
                    break;
                case "Key03":
                    playerInv.key3 = true;
                    break;
                default:
                    Debug.Log("CBA TO FIND NAME");
                    break;
            }
        playerInv.ShowActiveKeys(gameObject.transform.name);    
        Destroy(gameObject);
        }
    }
}