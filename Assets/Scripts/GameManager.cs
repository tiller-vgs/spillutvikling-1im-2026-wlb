using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;


public class GameManager : MonoBehaviour
{
    public GameObject objectToSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Keyboard.current.gKey.wasPressedThisFrame)
        {
           ShouldSpawn();
        }
    }
    public void ShouldSpawn()
        {
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }

}
