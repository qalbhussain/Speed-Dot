using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetHighScore : MonoBehaviour {
    public Text text;
    // Use this for initialization
	void Start () {
      text.text = PlayerPrefManager.GetPlayerScore().ToString();
	}

}
