using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public string interactButton;
    public float interactDistance = 3f;
    public LayerMask interactLayer; //Filter

    public Image interactIcon; //picture showing when interacting

    public bool isInteracting;

    // Start is called before the first frame update
    void Start()
    {
        //set Interact icon to be visible
        if(interactIcon != null)
        {
            interactIcon.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        //shoots a ray
       if(Physics.Raycast(ray, out hit, interactDistance, interactLayer))
        {
            //Checks if the player is not interacting
            if(isInteracting == false)
            {
                if (interactIcon.enabled != null)
                {
                    interactIcon.enabled = true;
                }

                //If the player press the interaction button
                if(Input.GetButtonDown(interactButton))
                {
                    if(hit.collider.CompareTag("Note"))
                    {
                        hit.collider.GetComponent<Note>().ShowNoteImage();
                    }
                }
            }
        }

        else
        {
            interactIcon.enabled = false;
        }

    }
}
