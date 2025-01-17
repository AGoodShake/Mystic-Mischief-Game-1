using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoboltAI : BaseEnemyAI
{
    float attackCooldown = 3f;
    float currentAttack;

    [SerializeField]
    bool attackedPlayer = false;
    public float pushForce = 20;

    PlayerController player;

    [SerializeField]
    private float knockbackForce;
    public Animator anim;
    
    new void Start()
    {
        base.Start();
        player = Player.GetComponent<PlayerController>();
        currentAttack = attackCooldown;
    } 

    new void Update()
    {
        if (player != null) //Checks whether the player is null. Prevents red error messages -Emilie 
        {
            float dist = Vector3.Distance(player.transform.position, transform.position);
            base.Update();
            if (attackedPlayer)
            {
                LostPlayer();
                currentAttack -= Time.deltaTime;
                if (currentAttack <= 0)
                {
                    currentAttack = attackCooldown;
                    attackedPlayer = false;
                }
            }
            if (base.spottedPlayer == true)
            {
                anim.SetBool("FoundPlayer", true);
            }
            else { anim.SetBool("FoundPlayer", false); }
            if (base.ai.speed > 0.1)
            {
                anim.SetFloat("RunSpeed", 1f);
            }
            if (dist <= 2f)
            {
                anim.SetTrigger("Bite");
            }

            if (base.stunned == true)
            {
                anim.SetBool("Hurt", true);
            }
            else
            {
                anim.SetBool("Hurt", false);
            }
        }
    }
    // Start is called before the first frame update
    private void OnCollisionEnter (Collision collision)
    {
        if(!attackedPlayer && collision.gameObject.CompareTag("Player"))
        {
            if(!stunned)
            {
                anim.SetTrigger("Bite");
                attackedPlayer = true;
                LostPlayer();
                player.TakeDamage(1);
                //Knockback
                // player.rb.AddForce((-transform.forward) * pushForce);
            } 
        }
        if (collision.gameObject.tag == "Poop")
        {
            stunned = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.tag == "Whip")
        {
            stunned = true;
            base.ai_Rb.AddForce(Player.transform.position * ai.speed, ForceMode.Impulse);
        }
    }
}
