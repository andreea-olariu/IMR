using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ThrowObject : MonoBehaviour
{
    public XRGrabInteractable grabbable;
    public float throwForce = 5f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        grabbable.onSelectEnter.AddListener(Throw);
    }

    private void OnDisable()
    {
        grabbable.onSelectEnter.RemoveListener(Throw);
    }

    private void Throw(XRBaseInteractor interactor)
    {
        rb.velocity = new Vector3(2, 2, 2);
        rb.angularVelocity = new Vector3(2, 2, 2);
    }
}
