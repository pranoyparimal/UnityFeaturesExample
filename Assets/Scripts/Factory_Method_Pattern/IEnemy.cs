// Purpose: Interface for the enemy objects to implement the spawn, attack and die methods.
using UnityEngine;

public interface IEnemy
{
    void Spawn(Vector3 position);
    void Attack();
    void Die();
}
