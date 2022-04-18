using UnityEngine;
using TMPro;

public class AssignName : MonoBehaviour
{
    public TMP_Text DeviceName;
    
    void Start()
    {
        DeviceName.text = transform.name;
    }
}
