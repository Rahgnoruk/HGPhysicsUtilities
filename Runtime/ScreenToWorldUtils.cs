using UnityEngine;

public static class ScreenToWorldUtils
{
    public static Vector3 ScreenToWorld(Camera camera, Vector3 position)
    {
        position.z = camera.nearClipPlane+1;
        return camera.ScreenToWorldPoint(position);
    }
}