using UnityEngine;

[CreateAssetMenu(fileName = "TrollSpawner", menuName = "EnemySpawner/Troll")]
public class TrollSpawner: EnemySpawner
{
    public override IEnemy CreateEnemy()
    {
        return new Troll();
    }
}
