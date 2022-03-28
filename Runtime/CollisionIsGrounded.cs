using HyperGnosys.Core;
using UnityEngine;

namespace HyperGnosys.PhysicsUtilities
{
    public class CollisionIsGrounded : MonoBehaviour
    {
        [SerializeField] private bool debugging = true;
        [SerializeField] private LayerMask floorLayer;
        [SerializeField] private BoolObservablePropertyComponent isGrounded;
        public BoolObservablePropertyComponent IsGrounded { get => isGrounded; set => isGrounded = value; }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.layer.Equals(floorLayer))
                isGrounded.Value = true;
        }
        private void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.layer.Equals(floorLayer))
                isGrounded.Value = false;
        }
        public bool Debugging { get => debugging; set => debugging = value; }
    }
}