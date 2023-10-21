
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ThrowObject : MonoBehaviour
{
    public float throwForce = 200000000f;
    private Rigidbody rb;

    public XRGrabInteractable grabInteractable;
    public GrabbedSphere grabbedSphere;
    public GameObject table;
    public TextMesh score;
    private bool wasThrown;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        grabbedSphere = GetComponent<GrabbedSphere>();
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onSelectExited.AddListener(Throw);
    }

    void Update()       
    {
        //if (grabbedSphere.isGrabbed)
        //{
        //    Debug.Log("isGrabbed is true");
        //}

        //Debug.Log(Vector3.Distance(table.transform.position, gameObject.transform.position));


        if (Hit())
        {
            if(wasThrown)
                IncreaseScore();
            wasThrown = false;
        }
    }

    void Throw(XRBaseInteractor interactor)
    {
        if(!grabbedSphere.isThrown)
        {
            return;
        }

        rb.isKinematic = false;
        Vector3 throwDirection = transform.forward;
        grabInteractable.transform.parent = null;
        rb.AddForce(throwDirection * throwForce, ForceMode.Impulse);

        grabbedSphere.isThrown = false;
        grabbedSphere.isGrabbed = false;
        wasThrown = true;

    }

    bool Hit()
    {
        return Vector3.Distance(table.transform.position, gameObject.transform.position) < 1.2;
    }

    void IncreaseScore()
    {
        float currentScore = float.Parse(score.text);
        currentScore += 1;
        score.text = currentScore.ToString();
    }
}
