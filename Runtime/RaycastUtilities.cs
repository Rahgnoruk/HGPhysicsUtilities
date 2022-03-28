using UnityEngine;

namespace HyperGnosys.PhysicsUtilities
{
    public static class RaycastUtilities
    {
        public static bool HasLineOfSight(Transform origin, Transform target, LayerMask obstacleLayerMask, bool debugging = false)
        {
            float distToTarget = Vector3.Distance(origin.position, target.transform.position);
            Vector3 dirToTarget = (target.position - origin.position).normalized;
            if (debugging) Debug.DrawRay(origin.position, target.position);
            ///Si no hay obstaculos que bloqueen al objetivo
            if (!Physics.Raycast(origin.position, dirToTarget, distToTarget, obstacleLayerMask))
            {
                return true;
            }
            return false;
        }
    }
}