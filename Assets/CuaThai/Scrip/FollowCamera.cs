using System.Collections;
using System.Collections.Generic;
using Unity.Cinemachine;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public CinemachineCamera FollowCamera;
    public void AssignCamera(Transform target)
    {
        FollowCamera.Follow = target;
        FollowCamera.LookAt = target;
    }

    private void Update()
    {
        OnMouseScroll();
    }

    void OnMouseScroll()
    {
        if(Input.mouseScrollDelta.y>0)
        {
            FollowCamera.Lens.FieldOfView -= 1;

        }
        else if(Input.mouseScrollDelta.y<0)
        {
            FollowCamera.Lens.FieldOfView += 1;
        }
    }

}
