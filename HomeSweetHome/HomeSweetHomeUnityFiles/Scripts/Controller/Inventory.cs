using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Behaviors
{
    public class Inventory : MonoBehaviour
    {
        public bool key1 = false; //FOR EVERYTHING
        public bool key2 = false;
        public bool key3 = false;

        public string key1s = "Garage"; //FOR COMPARISON IN DOOR INTERACT
        public string key2s = "XDoor";
        public string key3s = "YDoor";

        public bool key1unl = false; //FOR SHOWUSEDKEY METHOD
        public bool key2unl = false;
        public bool key3unl = false;

        public bool showKeys = false;
        public float timer = 8.0f;
        public float timerDefault = 8.0f;
        public string displayMe;

        public bool colorAlphaReset = false;
        public TextMeshProUGUI uiKeyText;    //LINK TO CANVAS TEXT
        
        //ShowActiveKeys method is called only from key pickup script.
        public void ShowActiveKeys(string keyName)
        {
            if (keyName == "Key01")
            {
                displayMe = "Master Bedroom Key Obtained.";
                showKeys = true;
            }

            if (keyName == "Key02")
            {
                displayMe = "Garage Key Obtained.";
                showKeys = true;
            }

            if (keyName == "Key03")
            {
                displayMe = "Baby Room Key Obtained.";
                showKeys = true;
            }
        }

        //ShowUsedKey method is called only from doorInteract script.
        public void ShowUsedKey(string keyName)
        {
            switch (keyName)
            {
                case "Key01":
                    if (!key1unl) //bool to ensure message show happens 1 time.
                    {
                        displayMe = "Master Bedroom Key Used.";
                        showKeys = true; // starts the show 
                        timer = timerDefault; //reset the timer just in case 
                        key1unl = true;  //locks this message
                    }
                    break;
                case "Key02":
                    if (!key2unl)
                    {
                        displayMe = "Garage Key Used.";
                        showKeys = true;
                        timer = timerDefault; //reset the timer just in case 
                        key2unl = true;
                    }
                    break;
                case "Key03":
                    if (!key3unl) 
                    {
                        displayMe = "Baby Room Key Used.";
                        showKeys = true;
                        timer = timerDefault; //reset the timer just in case 
                        key3unl = true;
                    }
                    break;
            }
        }

        private void Update()
        {
            if (showKeys)
            {
                timer -= Time.deltaTime;
                uiKeyText.text = displayMe;

                if (timer < 5.0f)
                {

                    uiKeyText.text = "";
                    uiKeyText.CrossFadeAlpha(1f,0,true);
                    timer = 8.0f;
                    showKeys = false;
                    //transparency fade out effect
                    // uiKeyText.CrossFadeAlpha(0f, 0.9f, true);  //TODO: REQUIRES TESTING
                    //uiKeyText.color.a -= Time.deltaTime / t)
                }
                else if (timer <= 7.0f && timer >= 5.5f)
                {
                    uiKeyText.CrossFadeAlpha(0f, 0.9f, true);
                    //uiKeyText.color = new Color(uiKeyText.color.r, uiKeyText.color.g, uiKeyText.color.b, 1.0f);
                }
            }
        }
    }
}