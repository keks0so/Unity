using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusHP : MonoBehaviour
{
   public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "PlayerShipTag")            
            {
                Destroy(gameObject);
            }
    }
    
         void Update()
    {
        //enemy curent position
        Vector2 position = transform.position;

        //compute the enemy new position
        position = new Vector2(position.x, position.y - speed * Time.deltaTime);

        //Update the enemy position
        transform.position = position;

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        if (transform.position.y < min.y)
        {
            Destroy(gameObject);
        }
    }
}
