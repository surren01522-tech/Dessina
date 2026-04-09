using UnityEngine;

public class xpPickup : MonoBehaviour
{
    public int xpAmount = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        PlayerLevel playerLevel = other.GetComponent<PlayerLevel>();

        if (PlayerLevel != null)
        {
            playerLevel.Addxp(xpAmount);
        }

        Destroy(gameObject);
    }
}
