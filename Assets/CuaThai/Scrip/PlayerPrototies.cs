using Fusion;
using UnityEngine;
using TMPro;
public class PlayerPrototile : NetworkBehaviour
{
    [Networked, OnChangedRender(nameof(OnHealthChanged))]
    public float health { get; set; }
    public float maxHealth { get; set; }

    public TextMeshProUGUI healthText;
    public NetworkObject networkObj;
    public NetworkRunner NetworkRunner;


    [Networked, OnChangedRender(nameof(OnSpeedChanged))]
    public float speed { get; set; }
    public Animator animator;
    public int speedHash = Animator.StringToHash("Speed");

    public void OnSpeedChanged()
    {
        animator.SetFloat("Speed", speed);
    }




    public void OnHealthChanged()
    {
        healthText.text = $"{health}/{maxHealth}";
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("pig"))
        {
            health -= 10;
            if(health <= 0)
            {
                NetworkRunner.Despawn(networkObj);
            }
        }
    }
    private void Start()
    {

        maxHealth = 100;
        health = maxHealth;
        healthText.text = $"{health}/{maxHealth}";

    }


    [Networked, OnChangedRender(nameof(OnSpeedChanged))]
    public PlayerNetworkInfo playerInfo { get; set; }
    public void OnPlayerInfoChanged()
    {

    }

}
