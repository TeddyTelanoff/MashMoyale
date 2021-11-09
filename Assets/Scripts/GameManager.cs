using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
	public static Vector3 mousePos {
		get
		{
			Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			pos.y = 0;
			return pos;
		}
	}

	public GameObject lightningPrefab;

	void Awake() =>
		instance = this;

	public void SpawnLightning()
	{
		GameObject obj = Instantiate(lightningPrefab);
		obj.transform.position = mousePos;
	}
}
