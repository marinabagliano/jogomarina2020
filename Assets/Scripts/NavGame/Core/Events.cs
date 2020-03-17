using UnityEngine;
namespace NavGame.Core
{
    // CHARACTER EVENTES
    public delegate void OnAttackHitEvent(Vector3 position);
    public delegate void OnHealthChangedEvent(int maxHealth, int currentHealth);
    public delegate void OnDiedEvent();

}