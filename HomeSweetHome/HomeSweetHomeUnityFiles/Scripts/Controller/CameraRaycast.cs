using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CameraRaycast : MonoBehaviour {

    public Camera camera;
    RaycastHit hit;
    Ray ray;
    public TextMeshProUGUI txt;
    public float raycastRange;
    public bool canInteract;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        CheckObjDistance();
	}
    void CheckObjDistance()
    {
        Vector3 fwd = camera.transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(camera.transform.position, fwd * 50, Color.green);


        //ray = camera.ViewportPointToRay(new Vector3(0,0,3));
        if (Physics.Raycast(camera.transform.position, fwd, out hit, 50))
        {
            if (hit.distance <= raycastRange)
            {
                if (hit.collider.GetComponent<IInteractable>() != null)
                {
                    if (hit.collider.GetComponent<DisableInteraction>() == null)
                    {

                        //Debug.Log(Mathf.Round(hit.distance));
                        //Debug.Log(hit.collider.name);

                        txt.text = "Press E to Interact";
                        canInteract = true;
                        CheckInteraction();
                    }
                    else if (hit.collider.GetComponent<DisableInteraction>() != null)
                    {
                        if (!hit.collider.GetComponent<DisableInteraction>().hasInteracted)
                        {
                            txt.text = "Press E to Interact";
                            canInteract = true;
                            CheckInteraction();
                        }
                        else
                        {
                            txt.text = "";
                            canInteract = false;
                        }
                    }
                }
            }
            else
            {
                txt.text = "";
                canInteract = false;
            }
        }
    }
    void CheckInteraction()
    {
            if (Input.GetKeyDown(KeyCode.E) && canInteract)
            {
                if (hit.collider != null)
                {
                    hit.collider.GetComponent<IInteractable>().Interact();
                    if (hit.collider.GetComponent<DisableInteraction>() != null)
                    {
                        hit.collider.GetComponent<DisableInteraction>().hasInteracted = true;
                    }
                }
            }
    }
}
