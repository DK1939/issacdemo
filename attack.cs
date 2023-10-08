using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        attackmove();
    }


    void attackmove()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            ani.SetTrigger("right");
            
        }
        else if(Input.GetKeyDown(KeyCode.H))
            {
            ani.SetTrigger("left");
        }
        else if (Input.GetKeyDown(KeyCode.U))
            {
            ani.SetTrigger("up");
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            ani.SetTrigger("down");
        }
    }
}
