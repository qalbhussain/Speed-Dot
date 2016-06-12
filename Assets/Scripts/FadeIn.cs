using UnityEngine.UI;
using UnityEngine;
using System.Collections;


public class FadeIn : MonoBehaviour {
    public float fadeInTime;
    private Image image;
    public Color color = Color.black;

	// Use this for initialization
	void Start () {
        image = GetComponent<Image>();
	}
	

	// Update is called once per frame
	void Update () {
        if (Time.timeSinceLevelLoad < fadeInTime)
        {
            float fadeInAlpha = Time.deltaTime / fadeInTime;
            color.a -= fadeInAlpha;
            image.color = color;
        }
        else
        {
            gameObject.SetActive(false);
        }
	}
}
