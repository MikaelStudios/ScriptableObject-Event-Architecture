using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(menuName = "New Boss")]
public class BossData : ScriptableObject
{
    [SerializeField] private string m_name;
    [SerializeField] private int m_maxHealth;
    [Space]
    [ShowAssetPreview(128, 128)]
    [SerializeField] private Sprite m_sprite;


    [SerializeField] private WeaponData m_weaknessWeapon;

    public int MaxHealth { get => m_maxHealth; set => m_maxHealth = value; }
    public WeaponData WeaknessWeapon { get => m_weaknessWeapon; set => m_weaknessWeapon = value; }
}
