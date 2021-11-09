using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
	void Update()
	{
		try
		{
			if (Input.GetMouseButtonUp(0))
				((CastableSpell) this).Cast();
		}
		catch (InvalidCastException e) { } // Ignore, UNITY is just kinda bald
	}

	void FixedUpdate()
	{
		transform.position = GameManager.mousePos;
	}
}
