
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.InputSystem.Layouts;

public class StickSprinting : UnityEngine.InputSystem.OnScreen.OnScreenControl
{
    [HideInInspector]
    public CustomStick cStick;

    [InputControl(layout = "Btn")]
    [SerializeField]
    private string m_ControlPath;

    protected override string controlPathInternal { get => m_ControlPath; set => m_ControlPath = value; }

    void Start()
    {
        cStick = GetComponent<CustomStick>();
    }

    void Update()
    {
        if (cStick.prevPos.x >= 0.7 || cStick.prevPos.x <= -0.7)
        {
            SendValueToControl(1.0f);
        }
        else
        {
            SendValueToControl(0.0f);
        }
    }
}