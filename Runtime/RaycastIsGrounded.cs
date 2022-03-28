using HyperGnosys.Core;
using UnityEngine;

namespace HyperGnosys.PhysicsUtilities
{
    public class RaycastIsGrounded : MonoBehaviour
    {
        /// Debugging no se debe marcar como solo de editor porque IsGrounded lo usa
        [SerializeField] private bool debugRaycastIsGrounded = false;
        [SerializeField] private BoolObservablePropertyComponent isGrounded;
        [SerializeField] private Collider objectCollider;
        [SerializeField] private ObservableProperty<float> floorSlope;

        private void FixedUpdate()
        {
            isGrounded.Value = ColliderIsGrounded.IsGrounded(objectCollider, floorSlope.Value,
                floorSlope.Value, debugRaycastIsGrounded);
        }
    }
}