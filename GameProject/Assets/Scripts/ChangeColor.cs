using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    #region Properites
    private string soundMode;
    private AudioSource soundToPlay;
    private Image thisImage;

    public AudioClip CatSound;
    public AudioClip NormalSound;
    public Color ActiveColor;
    public Color NotActiveColor;
    #endregion

    void Start()
    {
        soundMode = SoundManager.PianoMode;
        soundToPlay = GetComponent<AudioSource>();
        thisImage = GetComponent<Image>();
    }

    public void Click()
    {
        thisImage.color = ActiveColor;
        PlayPianoSound();
    }

    public void OnClickExit()
    {
        thisImage.color = NotActiveColor;
    }

    //This function will be called when the user pass the mouse over the key after having clicked
    public void OnClickEnter()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            thisImage.color = ActiveColor;
            PlayPianoSound();
        }
    }

    public void PlayPianoSound()
    {
        if (soundMode == "normal")
        {
            soundToPlay.clip = NormalSound;
            soundToPlay.Play();
        }
        else
        {
            soundToPlay.clip = CatSound;
            soundToPlay.Play();
        }
    }
}
