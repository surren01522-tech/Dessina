using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHp = 10;
    public int currentHP;

    public bool IsDead = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHP = maxHp;
    }


    public void TakeDamge(int damge)
    {
        if (IsDead) return;
 
        currentHP -= damge;

        if(currentHP <=0)
        {
            currentHP = 0;
            Die();
        }

        Debug.Log("Player HP: " + currentHP);
    }

    void Die()
    {
        IsDead = true;
        Debug.Log("GameOver");
    }
}
