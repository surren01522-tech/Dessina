using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHP = 3;
    public int currentHP;

    public GameObject xpPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        Debug.Log("맞았음!");

        if(currentHP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (xpPrefab != null)
        {
            Instantiate(xpPrefab, transform.position, Quaternion.identity);
        }
            Destroy(gameObject);
    }


}
