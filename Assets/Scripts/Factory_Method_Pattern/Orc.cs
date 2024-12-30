using UnityEngine;

public class Orc : IEnemy
{
    public void Attack()
    {
        Debug.Log("Troll attacks by throwing rocks!");
        // Troll attack logic
    }

    public void Die()
    {
        Debug.Log("Troll has been slain!");
        // Troll death logic
    }

    public void Spawn(Vector3 position)
    {
        Debug.Log("Spawning a Troll at " + position);
        // Instantiate Troll prefab or set up Troll-specific data here
    }
}
