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
        else if (instance != null)
            Destroy(gameObject);
    }

    public void Win()
    {
        //Winning message
        youWinText.SetActive (true);
        //Dramatic effect
        Time.timeScale = .5f;
        Invoke("Reset", resetDelay);
        //reset the game
    }

    void Reset()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel(Application.loadedLevel);
    }
}
