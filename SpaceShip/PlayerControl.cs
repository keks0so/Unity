using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public GameObject GameManagerGO;
    public GameObject PlayerBulletGO; //this is our players bullet prefab
    public GameObject BulletPosition01;
    public GameObject BulletPosition02;
    public GameObject ExplosionGO;
    public float StartTimeBtwShots;
    private float TimeBtwShots;

    //Reference to the live UI text
    public Text LivesUIText;

    const int MaxLives = 3; //maximum player lives
    int lives;

    

    public void Init()
    {
        
        lives = MaxLives;
        //Update the lives UI
        LivesUIText.text = lives.ToString ();

        //reset the player position to the centre of the screen
        transform.position = new Vector2 (0, 0);

        // set this player object to active
        gameObject.SetActive (true);
    }
    // Start is called before the first frame update
    void Start()
    {
       TimeBtwShots = StartTimeBtwShots; 
    }

    // Update is called once per frame
    void Update()
    {
        // fire bullets when the enter is presed

        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();

            GameObject bullet01 = (GameObject)Instantiate(PlayerBulletGO);
            bullet01.transform.position = BulletPosition01.transform.position; // set the bullet initial position

            //instantitate the first bullet
            GameObject bullet02 = (GameObject)Instantiate (PlayerBulletGO);
            bullet02.transform.position = BulletPosition02.transform.position;
        }
        
        
        if (Input.GetMouseButton(0))
        {
            GetComponent<AudioSource>().Play();
            
            if (TimeBtwShots <= 0)
            {

                
                GameObject bullet01 = (GameObject)Instantiate(PlayerBulletGO);
                bullet01.transform.position = BulletPosition01.transform.position; // set the bullet initial position

                //instantitate the first bullet
                GameObject bullet02 = (GameObject)Instantiate (PlayerBulletGO);
                bullet02.transform.position = BulletPosition02.transform.position;

                TimeBtwShots = StartTimeBtwShots;

            }
            else
            {

                TimeBtwShots -= Time.deltaTime;
            }
        
        }
        /*/

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet01 = (GameObject)Instantiate(PlayerBulletGO);
            bullet01.transform.position = BulletPosition01.transform.position; // set the bullet initial position

            //instantitate the first bullet
            GameObject bullet02 = (GameObject)Instantiate (PlayerBulletGO);
            bullet02.transform.position = BulletPosition02.transform.position;
        }
        /*/

        float x = Input.GetAxisRaw ("Horizontal"); //the value will be -1 0 or 1 (for left no input, and right)
        float y = Input.GetAxisRaw ("Vertical"); //the value will be -1 0 or 1 (for down no input, and up)

        //now based on the input we compute a direction vector, and we normolize it to get one vector
        Vector2 direction = new Vector2 (x, y).normalized;

        //now we call the function that computes and sets players
        Move (direction);
    }

    void Move(Vector2 direction)
    {
        //Find the screen limets to the players movement (edges of the screen)
        Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint (new Vector2 (1, 1));

        max.x = max.x - 0.255f; //subtract the player sprite half width
        min.x = min.x + 0.255f; //add the player sprite half width

        max.y = max.y - 0.285f; //subtract the player sprite half hight
        min.y = min.y + 0.285f; //add the player sprite half hight

        //get the player current position
        Vector2 pos  = transform.position;

        //calculate the new players position
        pos += direction * speed * Time.deltaTime;

        //Make sure the player is not outside of the screen
        pos.x = Mathf.Clamp (pos.x, min.x, max.x);
        pos.y = Mathf.Clamp (pos.y, min.y, max.y);

        //Update the players position
        transform.position = pos;
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        //healing our ship
        if(col.tag == "Heal")
        {
            lives = lives + 1;
            LivesUIText.text = lives.ToString();
        }

        //Detect collusion of the player ship with the enemy ship, or with an enemy bullet
        if((col.tag == "EnemyShipTag") || (col.tag == "EnemyBulletTag") || (col.tag == "EnemyBulletTag") || (col.tag == "MeteorTag"))
        {
            PlayExplosion();
            
            lives--;
            
            LivesUIText.text = lives.ToString();
            if (lives == 0)
            {
                GameManagerGO.GetComponent<GameManager1>().SetGameManagerState(GameManager1.GameManagerState.GameOver);

                gameObject.SetActive(false);
                //Destroy(gameObject);  
            }
            
        }
    }

    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate (ExplosionGO);

        explosion.transform.position = transform.position;
    }

    
}

