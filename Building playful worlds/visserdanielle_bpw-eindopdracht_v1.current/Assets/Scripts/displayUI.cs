using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class displayUI : MonoBehaviour
{
    public string myString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;

    // Initialization
    void Start()
    {
        myText = GameObject.Find ("Text").GetComponent<Text> ();
        myText.color = Color.clear;
        //Screen.showCursor = false;
        //Screen.LockCursor = true;
    }

    // Update is called once per frame
    void Update()
    {
        FadeText();

        /*if (Input.getKeyDown (KeyCode.Escaoe))
        {
            Screen.LockCursor = false;
        }
        */
    }

    void OnMouseOver()
    {
        displayInfo = true;
    }

    void OnMouseExit()
    {
        displayInfo = false;
    }

    void FadeText()
    {
        if(displayInfo)
        {
            myText.text = myString;
            myText.color = Color.Lerp (myText.color, Color.white, fadeTime * Time.deltaTime);
        }

        else
        {
            myText.color = Color.Lerp (myText.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }
}
