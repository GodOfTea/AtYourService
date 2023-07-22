using PixelCrushers;
using UnityEngine;

namespace InputComponents
{
    public class DialogueInputsRegister : MonoBehaviour
    {
        private ControlMap _controlMap;

        private void Awake()
        {
            _controlMap = new ControlMap();
        }

        private void OnEnable()
        {
            _controlMap.Enable();
            InputDeviceManager.RegisterInputAction("Interaction", _controlMap.Gameplay.Interaction);
        }

        private void OnDisable()
        {
            _controlMap.Disable();
            InputDeviceManager.UnregisterInputAction("Interaction");
        }
    }
}
