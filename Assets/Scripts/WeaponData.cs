using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu]
public class WeaponData : ScriptableObject
{
    [SerializeField] string m_name;
    [SerializeField] int m_damageAmount;

    [ShowAssetPreview(126, 128)]
    [SerializeField] Sprite m_sprite;

    public Sprite Sprite { get => m_sprite; set => m_sprite = value; }
}
