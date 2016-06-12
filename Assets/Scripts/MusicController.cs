using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MusicController : MonoBehaviour {
   
    public MusicManager mManager ;
    public Sprite musicOn, musicOff;
    public Image image;
   
    void Start()
    {
        mManager = GameObject.FindObjectOfType<MusicManager>();
       
    }

    public void OnMouseClick()
    {
        if (mManager.isPlay() == true)
        {
            mManager.StopMusic();
            image.GetComponent<Image>().sprite = musicOff;
        }
        else
        {
            mManager.PlayMusic();
            image.GetComponent<Image>().sprite = musicOn ;
        }
    }
}
