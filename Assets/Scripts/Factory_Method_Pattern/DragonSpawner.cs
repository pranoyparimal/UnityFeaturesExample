using UnityEngine;

[CreateAssetMenu(fileName = "DragonSpawner", menuName = "EnemySpawner/Dragon")]
public class DragonSpawner : EnemySpawner
{
    public override IEnemy CreateEnemy()
    {
        return new Dragon();
    }
}
