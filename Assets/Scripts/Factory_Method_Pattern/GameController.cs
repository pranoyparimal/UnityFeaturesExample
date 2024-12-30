using UnityEngine;
public class GameController : MonoBehaviour
{
    private EnemySpawner _enemySpawner;
    void Start()
    {
        // Decide which enemy to spawn based on game conditions
        // For example, we can spawn different enemies based on the level number
        int level = GetCurrentLevel();
        if (level < 5)
        {
            _enemySpawner = new OrcSpawner();
        }
        else if (level >= 5 && level < 10)
        {
            _enemySpawner = new TrollSpawner();
        }
        else
        {
            _enemySpawner = new DragonSpawner();
        }
        SpawnEnemiesInWave(3);
    }
    void SpawnEnemiesInWave(int numberOfEnemies)
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {
            Vector3 spawnPosition = GetRandomSpawnPosition();
            _enemySpawner.SpawnEnemy(spawnPosition);
        }
    }
    int GetCurrentLevel()
    {
        // Placeholder for actual level retrieval logic
        return 6;
    }
    Vector3 GetRandomSpawnPosition()
    {
        // Placeholder for actual spawn position logic
        return new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
    }
}