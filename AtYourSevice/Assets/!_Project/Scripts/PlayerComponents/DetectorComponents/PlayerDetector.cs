using EntityComponents;
using PlayerComponents.DetectorComponents;
using UnityEngine;

namespace PlayerComponents
{
    public class PlayerDetector : MonoBehaviour
    {
        /* TODO-AYS: Убрать */
        public Transform DetectorPoint;
        
        private DetectorHandler _detectorHandler;
        private IInteractable _nearestInteractableObject;

        public IInteractable NearestInteractableObject => _nearestInteractableObject;
        
        private void OnEnable()
        {
            _detectorHandler = new DetectorHandler();
        }

        private void OnDisable()
        {
            _detectorHandler = null;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IInteractable interactableObject))
                _detectorHandler.DetectObject(interactableObject);
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out IInteractable interactableObject))
                _detectorHandler.LostObject(interactableObject);
        }

        private void Update()
        {
            if (_detectorHandler.NothingToInteract)
            {
                _nearestInteractableObject = null;
                return;
            }

            IInteractable closestObject = _detectorHandler.GetNearestInteractableObject(DetectorPoint.position);
            
            if (closestObject == _nearestInteractableObject)
                return;
            
            _nearestInteractableObject = closestObject;
            _nearestInteractableObject.PrepareToInteract();
        }
    }
}
