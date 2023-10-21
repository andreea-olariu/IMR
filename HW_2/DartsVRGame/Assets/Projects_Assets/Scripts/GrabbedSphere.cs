using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabbedSphere : MonoBehaviour
{
    public XRGrabInteractable grabInteractable;
    public bool isGrabbed;
    public bool isThrown;

    void Start()
    {
        isThrown = false;
        isGrabbed = false;
    }

    void Update()
    {
        if (grabInteractable.isSelected)
        {
            isGrabbed = true;

            if (Input.GetKeyDown(KeyCode.F))
            {
                isThrown = true;
            }
        }
        else
        {
            isGrabbed = false;
            isThrown = false;
        }
        if (gameObject.transform.position.y < -50)
        {
            ReturnToTable();
        }
    }
    void ReturnToTable()
    {
       gameObject.transform.position = new Vector3(0, 1, 1);
        
    }
}
