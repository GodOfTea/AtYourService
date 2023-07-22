using PixelCrushers.DialogueSystem;
using UnityEngine;
using Zenject;

namespace EntityComponents
{
    public class NPC : MonoBehaviour, IInteractable
    {
        private DialogueSystemController _dialogueSystem;
        
        [Inject]
        public void Construct(DialogueSystemController dialogueSystem)
        {
            _dialogueSystem = dialogueSystem;
        }
        
        public Vector3 GetPosition()
        {
            return transform.position;
        }

        public void Interact()
        {
            _dialogueSystem.StartConversation("Dialogue With Karl");
        }

        public void PrepareToInteract()
        {
            Debug.Log($"{gameObject.name} ready to interact");
        }
    }
}