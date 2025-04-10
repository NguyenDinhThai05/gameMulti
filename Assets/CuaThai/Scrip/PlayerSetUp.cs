using Fusion;
using UnityEngine;

public class PlayerSetUp : NetworkBehaviour
{
    public void SetUpCamera()
    {
        if(Object.HasStateAuthority)
        {
            var cameraFollow = FindFirstObjectByType<CameraFollow>();
            if(cameraFollow!= null)
            {
                cameraFollow.AssignCamera(transform);

            }
        }
    }
}
