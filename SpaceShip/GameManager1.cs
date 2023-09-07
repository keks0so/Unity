using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    //Reference to our game object
    public GameObject playButton;
    public GameObject playerShip;
    public GameObject enemySpawner;
    public GameObject GameOverGO;
    public GameObject scoreUITextGO;

    public enum GameManagerState
    {
        Opening,
        Gameplay,
        GameOver, 
    }

    GameManagerState GMState;

    // Start is called before the first frame update
    void Start()
    {
        GMState = GameManagerState.Opening;
    }

    
    //Function to update the game manager state
    void UpdateGameManagerState()
    {
        
        switch (GMState)
        {
        case GameManagerState.Opening:
            //hide gameover
            GameOverGO.SetActive(false);
            //set play button visible(active)
            playButton.SetActive(true);

            

            break;
        case GameManagerState.Gameplay:

            //Reset the score 
            scoreUITextGO.GetComponent<GameScore>().Score = 0;

            //hide play button on game play state
            playButton.SetActive(false);
            //set the player viseble active
            
            playerShip.GetComponent<PlayerControl>().Init();

            //start enemy spawner
            enemySpawner.GetComponent<EnemySpawner>().ScheduleEnemySpawner();

            break;
        case GameManagerState.GameOver:
            
            // stop enemy spawner
            enemySpawner.GetComponent<EnemySpawner>().UnscheduleEnemySpawner();
            // display gameover
            
            GameOverGO.SetActive(true);
            // change gamemanager state to opening state after 8 seconds
            Invoke("ChangeToOpeningState", 4f);

            break;
            
        }

    }
    public void SetGameManagerState(GameManagerState state)
    {
        GMState = state;
        UpdateGameManagerState();
    }

    //our play button will call this function
    public void StartGamePlay()
    {
        GMState = GameManagerState.Gameplay;
        UpdateGameManagerState();
    }

    //Function to change gamemanager state to opening state
    public void ChangeToOpeningState()
    {
        SetGameManagerState (GameManagerState.Opening);
    }

}

