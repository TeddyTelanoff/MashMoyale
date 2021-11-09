using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troop : Tower
{
	public Tower target;
	public float speed;

	void FixedUpdate()
	{
		if (target == null)
			FindTarget();
	}
}
