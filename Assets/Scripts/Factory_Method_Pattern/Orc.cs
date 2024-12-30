using UnityEngine;

public class Orc : IEnemy
{
    public void Attack()
    {
        Debug.Log("Orc attacks by throwing club!");
        // Orc attack logic
    }

    public void Die()
    {
        Debug.Log("Orc has been defeated!");
        // Orc death logic
    }

    public void Spawn(Vector3 position)
    {
        Debug.Log("Spawning a Orc at " + position);
        // Instantiate Troll prefab or set up Orc-specific data here
    }
}
