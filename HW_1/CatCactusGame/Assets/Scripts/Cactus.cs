using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{
    public GameObject catObject;
    public Animator animator;
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, catObject.transform.position) < 50)
        {
            animator.SetBool("attacking", true);
        }
        else
        {
            animator.SetBool("attacking", false);
        }
    }
}

