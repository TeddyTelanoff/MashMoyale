using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
	public Castable castable;

	void Awake()
	{
		castable = (Castable) this;
	}

	void Update()
	{
		if (Input.GetMouseButtonUp(0))
			castable.Cast();
	}

	void FixedUpdate()
	{
		transform.position = GameManager.mousePos;
	}
}
