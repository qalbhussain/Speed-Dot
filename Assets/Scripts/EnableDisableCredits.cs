using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EnableDisableCredits : MonoBehaviour {
    public GameObject gameObject;
    private int time = 2;

    public void OnClick()
    {
        gameObject.SetActive(true);
        Invoke("DisableGameobject", time);
    }

    void DisableGameobject()
    {
        gameObject.SetActive(false);
    }

}
