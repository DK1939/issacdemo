using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target;
    public float smoothing;

    public Vector2 minposition;
    public Vector2 maxposition;
    // Start is called before the first frame update
    void Start()
    {

    }
    void LateUpdate()
    {
        if (target != null)
        {
            if (transform.position != target.position)
            {
                Vector3 targetpos = target.position;
                targetpos.x = Mathf.Clamp(targetpos.x, minposition.x, maxposition.x);
                targetpos.y = Mathf.Clamp(targetpos.y, minposition.y, maxposition.y);
                transform.position = Vector3.Lerp(transform.position, targetpos, smoothing);
            }
        }
    }

     public void setcamposlimit(Vector2 minpos, Vector2 maxpos)
    {
        minposition = minpos;
        maxposition = maxpos;
    }
     

}
