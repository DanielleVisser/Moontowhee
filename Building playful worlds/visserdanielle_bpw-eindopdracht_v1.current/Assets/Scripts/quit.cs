using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    void OnGUI() //Mouse appears is UI
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void doquit()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }

}
