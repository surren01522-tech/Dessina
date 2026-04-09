using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    public int level = 1;
    public int curretXP = 0;
    public int xpToNextLevel = 5;

    public AutoShooter autoShooter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Addxp(int amount)
    {
        curretXP += amount;

        Debug.Log("XP: " + currentXP + " / " + xpToNextLevel);

        if (currentXP <= xpToNextLevel)
        {
            LevelUP();
        }
    }

    void LevelUP()
    {
        level++;
        currentXP = 0;
        xpToNextLevel += 3;

        Debug.Log("Level UP! Current Level: " + level);

        if(autoShooter != null)
        {
            autoShooter.attackInterval = Mathf.Max(0.2f, autoShooter.attackInterval - 0.1f);
        }
    }
}
