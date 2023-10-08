using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_2 : MonoBehaviour
{
    public int health;
    public int damage;
    public float flashtime;
    private SpriteRenderer sr;
    private Color originalcolor;
    public GameObject blood;
    private playerhealth playerhealth;
    public GameObject dropcoin;
    // Start is called before the first frame update
    public void Start()
    {
        playerhealth = GameObject.FindGameObjectWithTag("Player").GetComponent<playerhealth>();
        sr = GetComponent<SpriteRenderer>();
        originalcolor = sr.color;
    }

    // Update is called once per frame
    public void Update()
    {
        if (health <= 0)
        {
            Instantiate(dropcoin, transform.position, transform.rotation);
            Destroy(gameObject);
            Instantiate(blood, transform.position, transform.rotation);

        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        flashcolor(flashtime);
    }

    void flashcolor(float time)
    {
        sr.color = Color.red;
        Invoke("resetcolor", time);
    }

    void resetcolor()
    {
        sr.color = originalcolor;
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            
                playerhealth.damageplayer(damage);
            
            
        }
    }
}
