using UnityEngine;

[CreateAssetMenu(fileName = "OrcSpawner", menuName = "EnemySpawner/Orc")]
public class OrcSpawner : EnemySpawner
{
    public override IEnemy CreateEnemy()
    {
        return new Orc();
    }
}
