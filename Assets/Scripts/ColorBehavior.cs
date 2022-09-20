using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorBehavior : MonoBehaviour
{
    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
        _image.color = Color.yellow;
    }

    public void ConnectStatusColor()
    {
        _image.color = Color.green;
    }

    public void DisconnectedStatusColor()
    {
        _image.color = Color.red;
    }
}
