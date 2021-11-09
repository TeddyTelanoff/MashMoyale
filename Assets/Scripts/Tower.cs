using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;

using TMPro;

using UnityEngine;

public class Tower : MonoBehaviour
{
    [Required, Label("Health Text")]
    public TextMeshPro hpText;
    [Label("Max Health")]
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

    public float attackSpeed;

    [SerializeField]
    private float _health;

    void FindTarget()
	{

	}
}
