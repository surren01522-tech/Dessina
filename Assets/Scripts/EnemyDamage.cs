using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 1;
    public float attackInterval = 1f;

    public float attackTimer = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackTimer += Time.deltaTime;
    }

    private void OnTriggerStat(Collider other)
    {
        if(!other.CompareTag("Player")) return;
        
        if(attackTimer < attackInterval) return;

        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

        if(playerHealth != null)
        {
            playerHealth.TakeDamge(damage);
            attackTimer = 0f;
        }
    }
}
