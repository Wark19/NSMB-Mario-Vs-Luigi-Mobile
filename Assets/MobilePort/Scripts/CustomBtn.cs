using System;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.OnScreen
{
    [AddComponentMenu("Input/On-Screen Button")]
    public class CustomBtn : OnScreenControl, IPointerDownHandler, IPointerUpHandler
    {
        public void OnPointerDown(PointerEventData eventData)
        {
            SendValueToControl(1.0f);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            SendValueToControl(0.0f);
        }

        [InputControl(layout = "Button")]
        [SerializeField]
        private string m_ControlPath;

        protected override string controlPathInternal
        {
            get => m_ControlPath;
            set => m_ControlPath = value;
        }
    }
}

