using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : Spell, CastableSpell
{
	readonly List<Tower> hits = new List<Tower>();

	public float totalDamage;
	public float minDamage;

	public void Cast()
	{
		foreach (Tower hit in hits)
			hit.hp -= Mathf.Max(totalDamage / hits.Count, minDamage);
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
