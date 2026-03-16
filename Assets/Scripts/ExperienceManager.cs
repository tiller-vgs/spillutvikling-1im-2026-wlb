using UnityEngine;

public class ExperienceManager : MonoBehaviour
{
    public int currentXP = 0;
    public int currentLevel = 1;
    public int xpToNextLevel = 100;

    // Add the experience
    public void AddExperience(int amount)
    {
        currentXP += amount;
        Debug.Log("Added experience " + amount + ". currentXP: " + currentXP);

        if (currentXP >= xpToNextLevel)
        {
            LevelUp();
        }
    }

    void LevelUp()
    {
        currentLevel++;
        currentXP -= xpToNextLevel;
        xpToNextLevel = (int)(xpToNextLevel * 1.5f); // Improve next enemy

        Debug.Log("Level up! Your level: " + currentLevel);
    }
}