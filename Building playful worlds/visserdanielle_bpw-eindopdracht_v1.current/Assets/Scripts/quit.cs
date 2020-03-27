using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    public Texture2D cursorArrow;

    void OnGUI() //Mouse appears on UI: Quit canvas.
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void doquit()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }

    void Start()
    {
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }

}
