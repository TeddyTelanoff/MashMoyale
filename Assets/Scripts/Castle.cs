using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : Tower
{
	void FixedUpdate()
	{
		if (Input.GetMouseButton(0))
			hp--;
	}
}
