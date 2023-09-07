using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{
    public GameObject Player;
    public int speed = 3;
    public int hp = 5;
    public GameObject pt;
    public Animator anim;

    public AudioSource audioSrc1;
    public bool isMooving = false;
    
    
   
    // Start is called before the first frame update
    void Start()
    {
        pt.SetActive(true);
        //audioSrc1 = GetComponent<AudioSource> ();
    }

    void Update()
    {
        

        if (isMooving == true)
        {
            audioSrc1.Play();
        }
        

        
            
    }

    // Update is called once per frame
    void FixedUpdate()
    {

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
        Vector2 popo = transform.position;

        //calculate the new players position
        pos += direction * speed * Time.deltaTime;

        //Make sure the player is not outside of the screen
        pos.x = Mathf.Clamp (pos.x, min.x, max.x);
        pos.y = Mathf.Clamp (pos.y, min.y, max.y);


        transform.position = pos;
        if (pos == popo)
        {   
            
            isMooving = true;
        }
        else
        {
            
            isMooving = false;
        }
        
        
    }
    
   }
 
