using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//class dung de spawn nhan vat khi vaof game
public class PlayerSpawner : SimulationBehaviour, IPlayerJoined
{
    public GameObject PlayerPrefab;

    public void PlayerJoined(PlayerRef player)
    {
       if(player == Runner.LocalPlayer)
        {
            var position = new Vector3(0, 1, 0);
            Runner.Spawn(
                PlayerPrefab,
                position,
                Quaternion.identity,
                Runner.LocalPlayer,
                (runner, obj) =>
                {
                    var playerSetUp = obj.GetComponent<PlayerSetUp>();
                    if (playerSetUp != null)
                    {
                        playerSetUp.SetUpCamera();

                    }
                });
        };
    }
}
    

