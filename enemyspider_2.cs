using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspider_2 : enemy_2
{
    public float speed;
    public float startwaittime;
    private float waittime;

    public Transform movepos;
    public Transform leftdownpos;
    public Transform rightuppos;

    // Start is called before the first frame update
    public void Start()
    {
        base.Start();
        waittime = startwaittime;
        movepos.position = getrandompos();
    }

    // Update is called once per frame
    public void Update()
    {
        base.Update();
        transform.position = Vector2.MoveTowards(transform.position, movepos.position, speed * Time.deltaTime);


        if(Vector2.Distance(transform.position,movepos.position)<0.1f)
        {
            if(waittime<=0)
            {
                movepos.position = getrandompos();
            }
            else
            {
                waittime -= Time.deltaTime;
            }
        }
    }

    Vector2 getrandompos()
    {
        Vector2 rndpos = new Vector2(Random.Range(leftdownpos.position.x, rightuppos.position.x), Random.Range(leftdownpos.position.y, rightuppos.position.y));
        return rndpos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("obstacle"))
        {
            movepos.position = getrandompos();
        }
    }
}
