using Fusion;
using Photon.Pun.Demo.Asteroids;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerGun : NetworkBehaviour
{
    public GameObject BulletPre;
    public Transform FirePoint;


    public NetworkRunner networkRunner;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (networkRunner is not null && networkRunner.LocalPlayer.IsRealPlayer)
            { 

            var bullet = networkRunner.Spawn(BulletPre, FirePoint.position, FirePoint.rotation);

                var bulletdirrection = FirePoint.forward;
                bullet.GetComponent<Rigidbody>().AddForce(bulletdirrection * 20f, ForceMode.Impulse);
          }
        }
    }

}
