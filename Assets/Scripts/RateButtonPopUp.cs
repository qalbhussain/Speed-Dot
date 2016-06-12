using UnityEngine;
using System.Collections;

public class RateButtonPopUp : MonoBehaviour {

    public void OnClick()
    {
        Application.OpenURL("http://play.google.com/store/apps/details?id=" + Application.bundleIdentifier);
    }
}
