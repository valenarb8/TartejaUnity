using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    public string url;

    private void OnMouseDown()
    {
        Application.OpenURL(url);
    }
}
