using UnityEngine;

public class Troll: IEnemy
{
    public void Attack()
    {
        Debug.Log("Orc attacks with a club!");
        // Orc attack logic
    }

    public void Die()
    {
        Debug.Log("Orc has been defeated!");
        // Orc death logic
    }

    public void Spawn(Vector3 position)
    {
        Debug.Log("Spawning an Orc at " + position);
        // Instantiate Orc prefab or set up Orc-specific data here
    }
}
