using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagPole : MonoBehaviour
{
    void OnTriggerenter()
    {
        //Trigger to win
        GameManager.instance.Win();
    }
}
