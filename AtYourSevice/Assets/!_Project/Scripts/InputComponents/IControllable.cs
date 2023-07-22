using UnityEngine;

namespace InputComponents
{
    public interface IControllable
    {
        void Move(Vector3 direction);
        void Interaction();
    }
}
