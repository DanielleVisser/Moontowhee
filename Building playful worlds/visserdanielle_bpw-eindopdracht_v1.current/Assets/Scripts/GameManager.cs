using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public GameObject youWinText;
    public float resetDelay;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null) //! does not...
            Destroy(gameObject); //no 2 game managers
    }

    public void Win()
    {
        //The winning message
        youWinText.SetActive (true);
        Time.timeScale = .5f; //Dramatic effect when winning the game
        //Invoke("Reset", resetDelay); //It resets the game, an not needed but handy.
    }

    void Reset()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel(Application.loadedLevel);
    }
}
