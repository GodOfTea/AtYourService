using System.Collections.Generic;
using EntityComponents;

namespace PlayerComponents
{
    public class DetectorBank
    {
        private List<IInteractable> _interactablesOjbects;

        public List<IInteractable> InteractablesObjects => _interactablesOjbects;
        public bool IsEmpty => _interactablesOjbects.Count <= 0;

        public DetectorBank()
        {
            _interactablesOjbects = new List<IInteractable>();
        }

        public void Add(IInteractable interactable)
        {
            if (_interactablesOjbects.Contains(interactable))
                return;
            
            _interactablesOjbects.Add(interactable);
        }

        public void Remove(IInteractable interactable)
        {
            _interactablesOjbects.Remove(interactable);
        }

        
    }
}