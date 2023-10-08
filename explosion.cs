using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;


public class explosion : MonoBehaviour
{

    private Animator animator;
    private AnimatorStateInfo Info;
    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    
        
    

    // Update is called once per frame
    void Update()
    {
        Info = animator.GetCurrentAnimatorStateInfo(0);
        if(Info.normalizedTime>=1)
        {
            Destroy(gameObject);
        }
    }
}
