using UnityEngine;

public class Troll: IEnemy
{
    public void Attack()
    {
        Debug.Log("Toll attacks with a rocks!");
        // Troll attack logic
    }

    public void Die()
    {
        Debug.Log("Troll has been slain!");
        // Troll death logic
    }

    public void Spawn(Vector3 position)
    {
        Debug.Log("Spawning an Troll at " + position);
        // Instantiate Orc prefab or set up Troll-specific data here
    }
}
