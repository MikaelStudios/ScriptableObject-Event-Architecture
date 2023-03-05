using NaughtyAttributes;
using UnityEngine;

public class BossController : MonoBehaviour
{
    [SerializeField] private BossData m_boss;
    [SerializeField] FloatEvent onBossDamaged;
    [SerializeField] GameEvent onBossKilled;

    [SerializeField, ReadOnly] float m_bossCurrentHealth;

    [Space]
    [SerializeField, ReadOnly] WeaponData m_currentWeapon = null;
    [SerializeField] SpriteEvent onWeaponSpriteChanged;
    public void Start()
    {
        m_bossCurrentHealth = m_boss.MaxHealth;
    }

    public void BossAttacked()
    {
        if (m_boss.WeaknessWeapon == m_currentWeapon)
            m_bossCurrentHealth -= 10;
        else
            m_bossCurrentHealth -= 1;
        onBossDamaged.Raise(m_bossCurrentHealth / m_boss.MaxHealth);
        // if health = 80 send 80/100 = 0.8
        if (m_bossCurrentHealth <= 0)
        {
            onBossKilled.Raise();
        }
    }

    public void WeaponChanged(WeaponData _w)
    {
        if (m_currentWeapon == _w) return;
        m_currentWeapon = _w;
        onWeaponSpriteChanged.Raise(_w.Sprite);
    }
}
