using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddDevicePanel : MonoBehaviour
{
    public GameObject SmartDevicePrefab;
    public Transform DevicePanel;
    public Transform DeviceParent;

    public void AddDeviceEntry()
    {
        Instantiate(SmartDevicePrefab, DevicePanel);
    }

    public void SwitchParentToDeviceParent()
    {
        Transform[] allChildren = DevicePanel.GetComponentsInChildren<Transform>();

        foreach (Transform child in allChildren)
        {
            if (child.tag == "Device")
                child.transform.SetParent(DeviceParent, false);
        }
    }

    public void SwitchParentToDevicePanel()
    {
        Transform[] allChildren = DeviceParent.GetComponentsInChildren<Transform>();

        foreach (Transform child in allChildren)
        {
            if (child.tag == "Device")
                child.transform.SetParent(DevicePanel, false);
        }
    }


}
