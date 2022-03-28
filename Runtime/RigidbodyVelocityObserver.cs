using HyperGnosys.Core;
using UnityEngine;

namespace HyperGnosys.PhysicsUtilities
{
    public class RigidbodyVelocityObserver : MonoBehaviour
    {
        [SerializeField] private bool debugging = true;
        [SerializeField] private Rigidbody observedRigidbody;
        [SerializeField] private FloatObservablePropertyComponent xVelocity;
        [SerializeField] private FloatObservablePropertyComponent zVelocity;
        private Vector3 localVelocityVector = Vector3.zero;
        private Vector3 cachedVelocity = Vector3.zero;


        private void FixedUpdate()
        {
            if (observedRigidbody.velocity == cachedVelocity)
            {
                return;
            }
            cachedVelocity = observedRigidbody.velocity;
            LocalVelocityVector = observedRigidbody.transform.InverseTransformDirection(observedRigidbody.velocity);
            if (XVelocity)
            {
                XVelocity.Value = LocalVelocityVector.x;
            }
            else
            {
                HGDebug.Log("No se ha asignado XVelocity en " + transform.name, debugging);
            }
            if (ZVelocity)
            {
                ZVelocity.Value = LocalVelocityVector.z;
            }
            else
            {
                HGDebug.Log("No se ha asignado ZVelocity en " + transform.name, debugging);
            }
        }
        public FloatObservablePropertyComponent XVelocity { get => xVelocity; set => xVelocity = value; }
        public FloatObservablePropertyComponent ZVelocity { get => zVelocity; set => zVelocity = value; }
        public Vector3 LocalVelocityVector { get => localVelocityVector; set => localVelocityVector = value; }
        public Rigidbody ObservedRigidbody { get => observedRigidbody; set => observedRigidbody = value; }
        public Vector3 CachedVelocity { get => cachedVelocity; set => cachedVelocity = value; }
    }
}