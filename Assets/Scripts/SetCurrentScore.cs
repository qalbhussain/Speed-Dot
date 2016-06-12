using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SetCurrentScore : MonoBehaviour {

    public Text text;
    // Use this for initialization
    void Start()
    {
        text.text = PlayerPrefManager.GetCurrentScore().ToString();
    }
}
