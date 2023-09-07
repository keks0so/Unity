using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet1 : MonoBehaviour
{
    public GameObject PlayerBulletGO; //this is our players bullet prefab
    //public GameObject bulletPosition01;
    //public GameObject bulletPosition02;

    float speed;
    // Start is called before the first frame update
    void Start()
    {
       speed = 6.5f; 
    }

    // Update is called once per frame
    void Update()
    {
        //Get bullet curent position
        Vector2 position = transform.position;

        //compute the bullets new position
        position = new Vector2 (position.x, position.y + speed * Time.deltaTime);

        //update the bullet position
        transform.position = position;

        //this is the top-right point of the screen
        Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1,1));

        //if the bullet went outside of the top of the screen
        if(transform.position.y > max.y)
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "EnemyShipTag")
        {
            Destroy(gameObject);
        }
    }
}
