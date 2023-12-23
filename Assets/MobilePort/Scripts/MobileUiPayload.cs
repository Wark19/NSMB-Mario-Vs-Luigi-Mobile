using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MobileUiPayload : MonoBehaviour
{
    public Toggle HotSet_scrControlsToggle;
    public GameObject HotSett;


    void Start()
    {
        HotSet_scrControlsToggle.isOn = Settings.Instance.scrControls;
    }

    public void GPause()
    {
        if (HotSett.activeInHierarchy == true)
        {
           GameManager.Instance.paused = true;
        }
        else
        {
           GameManager.Instance.paused = false;
        }
    }
}
