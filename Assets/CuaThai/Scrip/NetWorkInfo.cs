using Fusion;
using System;
using UnityEngine;
[Serializable]
public struct PlayerNetworkInfo : INetworkStruct
{
    
    public float health;
    public float mana;
    public float score;
}