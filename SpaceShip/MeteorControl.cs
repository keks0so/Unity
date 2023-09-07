using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorControl : MonoBehaviour
{
    public float speed;
    private Transform player;
    public GameObject ExplosionGO;
    GameObject scoreUITextGO;
    public GameObject Heal;
    Vector2  _direction;

    void Start()
    {
        
        //Get the score text UI
        scoreUITextGO = GameObject.FindGameObjectWithTag("ScoreTextTag");


    }
    
    
    void Update()
    {
        
        player = GameObject.FindGameObjectWithTag("PlayerShipTag").GetComponent<Transform>();
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        
        Vector2 position = transform.position;

        //compute the enemy new position
        position = new Vector2 (position.x, position.y - speed * Time.deltaTime);

        //Update the enemy position
        transform.position = position;

        Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));

        if(transform.position.y < min.y)
        {
            Destroy(gameObject);
        }
        
       
        
    
    }
    
    
    // Update is called once per frame
    
    void OnTriggerEnter2D(Collider2D col)
    {
        //Detect collusion of the enemy ship with the player ship, or with a player bullet
        if ((col.tag == "PlayerShipTag") || (col.tag == "PlayerBulletTag"))
        {
            
            
            int rnd = Random.Range(0, 10);
            if (rnd == 1)
            {
                
                GameObject heal = (GameObject)Instantiate(Heal);
                heal.transform.position = transform.position;
            }

            PlayExplosion();
            scoreUITextGO.GetComponent<GameScore>().Score += 10;

            Destroy(gameObject);
        }
    }
    

    
    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);

        explosion.transform.position = transform.position;
    }
}
