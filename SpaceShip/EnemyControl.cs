using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyControl : MonoBehaviour
{
    GameObject scoreUITextGO; // reference to the text UI gameObject
    public GameObject ExplosionGO;
    public GameObject Heal;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1.5f;
        //Get the score text UI
        scoreUITextGO = GameObject.FindGameObjectWithTag("ScoreTextTag");


    }

    // Update is called once per frame
    void Update()
    {
        //enemy curent position
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

    void OnTriggerEnter2D(Collider2D col)
    {
        //Detect collusion of the enemy ship with the player ship, or with a player bullet
        if((col.tag == "PlayerShipTag") || (col.tag == "PlayerBulletTag"))
        {
            int rnd = Random.Range(0, 10);
            if (rnd == 1)
            {
                
                GameObject heal = (GameObject)Instantiate(Heal);
                heal.transform.position = transform.position;
            }
            PlayExplosion();

            //add 50 points to the score
            scoreUITextGO.GetComponent<GameScore>().Score += 25;

            Destroy(gameObject);
        } 
    }

    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate (ExplosionGO);

        explosion.transform.position = transform.position;
    }

}
