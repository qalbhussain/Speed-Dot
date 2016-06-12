using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
    public AudioSource audioSource;
    public bool isPlaying;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    void Start()
    {
        isPlaying = true;
    }

    public void PlayMusic()
    {
        audioSource.Play();
        isPlaying = true;
    }

    public void StopMusic()
    {
        audioSource.Stop();
        isPlaying = false;
    }

    public bool isPlay(){
    return isPlaying ;
    }
}
