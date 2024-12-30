using UnityEngine;

public class OrcSpawner : EnemySpawner
{
    public override IEnemy CreateEnemy()
    {
        return new Orc();
    }
}
