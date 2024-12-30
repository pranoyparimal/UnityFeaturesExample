using UnityEngine;

public class Player : MonoBehaviour, IDamageable
{
    #region IDamageable Property Implementation
    public int Health { get; set; }
    #endregion

    #region Unity Default Callbacks
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health = 10;
    }
    #endregion

    #region IDamageable Method Implementation
    public void DealDamage(int damage)
    {
        Health -= damage;
        Debug.Log("<color=purple>Player took damage! Current Health: </color>" + Health);

        if (Health <= 0)
        {
            Die();
        }
    }
    #endregion

    #region Self Defined Functions
    private void Die()
    {
        Debug.Log("<color=red><size=25>Player has died.</size></color>");
        // Additional death logic here
    }
    #endregion
}
