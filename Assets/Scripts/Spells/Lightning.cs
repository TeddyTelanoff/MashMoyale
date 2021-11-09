using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : Spell, Castable
{
	readonly List<Tower> hits = new List<Tower>();

	public float totalDamage;

	public void Cast()
	{
		foreach (Tower hit in hits)
			hit.hp -= totalDamage / hits.Count;
		Destroy(gameObject);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.TryGetComponent<Tower>(out Tower tower))
			hits.Add(tower);
	}

	void OnTriggerExit(Collider other)
	{
		if (other.TryGetComponent<Tower>(out Tower tower) && hits.Contains(tower))
			hits.Remove(tower);
	}
}
