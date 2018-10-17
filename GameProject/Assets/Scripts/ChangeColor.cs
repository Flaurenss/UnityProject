using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public void Click()
    {
        GetComponent<Image>().color = Color.gray;
        //Notes should be played here
        GetComponent<AudioSource>().Play();
    }
    //Start Same functions
    public void ClickUp()
    {
        if (transform.parent.name == "Tonos")
        {
            GetComponent<Image>().color = Color.white;
        }
        else
        {
            GetComponent<Image>().color = Color.black;
        }
        
    }

    public void OnClickExit()
    {
        if (transform.parent.name == "Tonos")
        {
            GetComponent<Image>().color = Color.white;
        }
        else
        {
            GetComponent<Image>().color = Color.black;
        }
        
    }
    //End from same functions

    //This function will be called when the user pass the mouse over the key and after having clicked
    public void OnClickEnter()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            GetComponent<Image>().color = Color.gray;
            //Notes should be played here
            GetComponent<AudioSource>().Play();
        }
    }
}
