using UnityEngine;

public class TrollSpawner: EnemySpawner
{
    public override IEnemy CreateEnemy()
    {
        return new Troll();
    }
}
