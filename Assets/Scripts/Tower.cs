using System.Collections;
using System.Collections.Generic;
using TMPro;

using UnityEngine;

public class Tower : MonoBehaviour
{
    public TextMeshPro hpText;
    public float maxHp;
    public float hp {
        get => _hp;
        set
        {
            if (value <= 0)
                Destroy(gameObject);

            _hp = value;
            hpText.text = $"{(int) _hp}/{(int) maxHp}hp";
		}
    }

    [SerializeField]
    private float _hp;
}
