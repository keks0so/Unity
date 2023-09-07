using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public GameObject EnemyBulletGO;
    int i;
    //public GameObject EnemyGO;
    // Start is called before the first frame update
    void Start()
    {
        
        i = 0;
        while (i < 1) //чем больше значение тем больше пуль, я сидел и понял что это было настолько просто 
        {
            Invoke("FireEnemyBullet", 0.5f); 
            i = i+1; 
        }
        i = 0;
        while (i < 1) //чем больше значение тем больше пуль, я сидел и понял что это было настолько просто 
        {
            Invoke("FireEnemyBullet", 1.5f); 
            i = i+1; 
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    

    void FireEnemyBullet()
    {
        GameObject playerShip = GameObject.Find ("spaceships1");

        if (playerShip != null)// if the player is no dead
        {
            GameObject bullet = (GameObject)Instantiate(EnemyBulletGO);

            // set the bullet instant position
            bullet.transform.position = transform.position;

            //compute the bullet direction
            Vector2 direction = playerShip.transform.position - bullet.transform.position;
            

            //set the bullet direction
            //bullet.GetComponent<EnemyBullet>();
            bullet.GetComponent<EnemyBullet>().SetDirection(direction);
            
            
            
        }
    }
}
