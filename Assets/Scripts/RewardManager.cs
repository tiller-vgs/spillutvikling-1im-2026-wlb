using UnityEngine;

public class RewardManager : MonoBehaviour
{
    // Need to add some different rewards for eks. health, dmg and idk
    public GameObject rewardPanel;
    
    public void ShowRewards()
    {
        rewardPanel.SetActive(true); 
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
    }
   
    public void SelectReward(int rewardType)
    {
        Debug.Log("You chose reward: " + rewardType);

        if (rewardType == 1)
        {
            // upgrades for character: 
        }

        rewardPanel.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}