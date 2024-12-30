using UnityEngine;

public class Dragon : IEnemy
{
    public void Attack()
    {
        Debug.Log("Dragon breathes fire!");
        // Dragon attack logic
    }

    public void Die()
    {
        Debug.Log("Dragon has been vanquished!");
        // Dragon death logic
    }

    public void Spawn(Vector3 position)
    {
        Debug.Log("Spawning a Dragon at " + position);
        // Instantiate Dragon prefab or set up Dragon-specific data here
    }
}
