using InputComponents;
using PlayerComponents;
using UnityEngine;

public class PlayerControls : MonoBehaviour, IControllable
{
    /* TODO-AYS: Убрать */
    public float MoveSpeed;

    /* TODO-AYS: Убрать */
    public CharacterController CharacterController;
    public Player Player;
    
    public void Move(Vector3 direction)
    {
        CharacterController.Move(direction * (Time.deltaTime * MoveSpeed));
    }

    public void Interaction()
    {
        Player.Interact();
    }
}
