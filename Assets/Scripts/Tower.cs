using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;

public class Tower : MonoBehaviour
{
    public TextMeshPro hpText;
    public float maxHp;
    public float hp {
        get => _health;
        set
        {
            if (value <= 0)
                Destroy(gameObject);

            _health = value;
            hpText.text = $"{(int) _health}/{(int) maxHp}hp";
		}
    }

    [SerializeField]
    private float _health;
}
