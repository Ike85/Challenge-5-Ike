using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public void openurl(string urlname)
    {
        Application.OpenURL("https://github.com/Ike85/Challenge-5-Ike");
    }
}