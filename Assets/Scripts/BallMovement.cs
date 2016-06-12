using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour {
    public int score;
    public Text text;
    Vector3 move;
    private float speed = 5f;
    int xDir = 1;
    int yDir = 1;
    public AudioClip audioClip;
    public AudioSource audioSource;
    private bool tapToPlay = false;
    public GameObject TextgameObject;
    public GameObject ballGameObject;
  
    void Start()
    {
        score = 0;
   }

    void Update()
    {
             transform.position += new Vector3(-1 * xDir * Time.deltaTime * speed, -1 * yDir * speed * Time.deltaTime, 0);
    }

    void OnMouseDown()
    {
        if (tapToPlay == false)
        {
            TextgameObject.SetActive(false);
            tapToPlay = true;
        }
            speed++;
            ++score;
            text.text = score.ToString();
            audioSource.clip = audioClip;
            audioSource.Play();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "left")
        {
            xDir = -1;
        }
        else if (collision.gameObject.tag == "right")
        {
            xDir = 1;
        }
        else if (collision.gameObject.tag == "up")
        {
            yDir = 1;
        }
        else if (collision.gameObject.tag == "down")
        {
            yDir = -1;
        }
    }
}
