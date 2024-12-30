// Purpose: Implementing the Factory Method Pattern for spawning enemies.
using UnityEngine;

public abstract class EnemySpawner
{
    /// <summary>
    /// Factory Method for creating enemies
    /// </summary>
    /// <returns></returns>
    public abstract IEnemy CreateEnemy();

    /// <summary>
    /// Common method for spawning enemies
    /// </summary>
    /// <param name="position"></param>
    public void SpawnEnemy(Vector3 position)
    {
        IEnemy enemy = CreateEnemy();
        enemy.Spawn(position);
        Debug.Log("Enemy spawned at " + position);
    }

    
    
}
