using System;
using UnityEngine;

namespace PlayerComponents
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerDetector _playerDetector;

        public void Interact()
        {
            _playerDetector.NearestInteractableObject.Interact();
        }
        
        #region Editor

        [ContextMenu("Find Detector")]
        private void FindDetector()
        {
            _playerDetector = FindObjectOfType<PlayerDetector>();
        }

        #endregion
    }
}