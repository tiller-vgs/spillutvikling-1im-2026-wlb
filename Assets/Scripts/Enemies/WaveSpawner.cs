using System.Runtime.CompilerServices;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] private Transform _player;

    [SerializeField]
    private GameObject _enemyPrefab;

    [SerializeField]
    private float _minimumSpawnTime;

    [SerializeField]
    private float _maximumSpawnTime;

    private float _timeUntilSpawn;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        SetTimeUntilSpawn();
    }

    // Update is called once per frame
    private bool _WaveActive = false;
    void Update()
    {

     if (!_WaveActive) return;

    _timeUntilSpawn -= Time.deltaTime;

    if (_timeUntilSpawn <= 0)
    {
        GameObject enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        enemy.GetComponent<EnemyFollow>().player = _player;

        SetTimeUntilSpawn();
    }}    
    private void SetTimeUntilSpawn()
    {
        _timeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }
    
    public void StartWave()
    {
        
        Debug.Log("Wave Started");
        _WaveActive = true;
        SetTimeUntilSpawn();
    }

    public void StopWave()
    {
        _WaveActive = false;
    }
   
   
}
