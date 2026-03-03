using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;


public class GameManager : MonoBehaviour
{
    
    void Start()
    {
         
    }

    // Update is called once per frame
    [SerializeField] private WaveSpawner _spawner;
    void Update()
    {
      if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
           _spawner.StartWave(); 
        }
    }
    
}
