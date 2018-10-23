using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    #region Properites
    private string SoundMode;
    private AudioSource SoundToPlay;
    public AudioClip CatSound;
    public AudioClip NormalSound;
    #endregion

    void Start()
    {
        SoundMode = SoundManager.PianoMode;
        SoundToPlay = GetComponent<AudioSource>();
    }

    public void Click()
    {
        GetComponent<Image>().color = Color.gray;
        //GetComponent<AudioSource>().Play();
        if (SoundMode == "normal")
        {
            SoundToPlay.clip = NormalSound;
            SoundToPlay.Play();
        }
        else
        {
            SoundToPlay.clip = CatSound;
            SoundToPlay.Play();
        }
        
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
            //GetComponent<AudioSource>().Play();
            if (SoundMode == "normal")
            {
                SoundToPlay.clip = NormalSound;
                SoundToPlay.Play();
            }
            else
            {
                SoundToPlay.clip = CatSound;
                SoundToPlay.Play();
            }
        }
    }
}
