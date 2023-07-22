using UnityEngine;

namespace EntityComponents
{
    public interface IInteractable : IEntity
    {
        void Interact();
        void PrepareToInteract();
    }
}