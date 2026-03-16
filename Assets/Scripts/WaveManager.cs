using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public RewardManager rewardManager;

    [SerializeField] private int enemiesAlive = 0;

    // Add the enemy in the system when he spawns
    public void RegisterEnemy()
    {
        enemiesAlive++;
    }

    // After enemy died 
    public void EnemyDied()
    {

        enemiesAlive--;

        if (enemiesAlive <= 0)
        {
            
            StartCoroutine(EndWaveSequence());
        }
    }
    private System.Collections.IEnumerator EndWaveSequence()
    {
        Debug.Log("Wave is completed");
        yield return new WaitForSeconds(1f);
        rewardManager.ShowRewards();
    }
}
   
    