using UnityEngine;

public class DragonSpawner : EnemySpawner
{
    public override IEnemy CreateEnemy()
    {
        return new Dragon();
    }
}
