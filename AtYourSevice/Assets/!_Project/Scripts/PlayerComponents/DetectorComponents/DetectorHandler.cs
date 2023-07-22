using EntityComponents;
using UnityEngine;

namespace PlayerComponents.DetectorComponents
{
    public class DetectorHandler
    {
        private DetectorBank _bank;

        public bool NothingToInteract => _bank.IsEmpty;
        
        public DetectorHandler()
        {
            _bank = new DetectorBank();
        }

        public void DetectObject(IInteractable interactableObject)
        {
            _bank.Add(interactableObject);
        }

        public void LostObject(IInteractable interactableObject)
        {
            _bank.Remove(interactableObject);
        }

        public IInteractable GetNearestInteractableObject(Vector3 playerPosition)
        {
            if (_bank.InteractablesObjects.Count == 1)
                return _bank.InteractablesObjects[0];
            
            float distance = float.MaxValue;
            IInteractable nearestObject = null;
            
            for (int i = 0; i < _bank.InteractablesObjects.Count; i++)
            {
                float distanceToObject = (playerPosition - _bank.InteractablesObjects[i].GetPosition()).sqrMagnitude;
                if (distanceToObject < distance)
                {
                    distance = distanceToObject;
                    nearestObject = _bank.InteractablesObjects[i];
                }
            }
            
            return nearestObject;
        }
    }
}