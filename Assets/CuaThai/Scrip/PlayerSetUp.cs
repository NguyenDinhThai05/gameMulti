using Fusion;
using UnityEngine;

public class PlayerSetUp : NetworkBehaviour
{
    public void SetUpCamera()
    {
        if(Object.HasStateAuthority)
        {
            var camera = FindFirstObjectByType<CameraFollow>();
            if(camera!= null)
            {
                camera.AssignCamera(transform);

            }
        }
    }
}
