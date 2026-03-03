using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;


public class GameManager : MonoBehaviour
{
    [SerializeField] private WaveSpawner _spawner;
    void Start()
    {
         _spawner.StartWave();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    
}
