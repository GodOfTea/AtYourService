using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace InputComponents
{
    public class PlayerInputHandler : MonoBehaviour
    {
        private ControlMap _controlMap;
        private IControllable _controllable;
        
        private Vector3 _direction;

        private void Awake()
        {
            _controllable = GetComponent<IControllable>();

            _controlMap = new ControlMap();
            _controlMap.Enable();
        }

        private void OnEnable()
        {
            _controlMap.Gameplay.Interaction.performed += OnInteractionPerformed;
        }

        private void OnDisable()
        {
            _controlMap.Gameplay.Interaction.performed -= OnInteractionPerformed;
        }

        private void Update()
        {
            _direction = _controlMap.Gameplay.Move.ReadValue<Vector2>();
            _controllable.Move(new Vector3(_direction.x, 0f, 0f));
        }

        private void OnInteractionPerformed(InputAction.CallbackContext obj)
        {
            _controllable.Interaction();
        }
    }
}