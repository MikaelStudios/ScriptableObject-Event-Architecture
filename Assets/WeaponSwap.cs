using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSwap : MonoBehaviour
{
    [SerializeField] private ToggleGroup m_toggleGroup;
    [SerializeField] List<WeaponData> weaponDatas;

    [Space]
    [SerializeField] WeaponDataEvent onWeaponChanged;
    private void Start()
    {
        OnSwapped();
    }
    public void OnSwapped()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).GetComponent<Toggle>().isOn)
            {
                onWeaponChanged.Raise(weaponDatas[i]);
            }

        }
    }
}
