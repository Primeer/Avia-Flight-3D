using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CityDeployer : MonoBehaviour
{
	public float radius = 311f;

	void Update()
    {
		transform.position = transform.position.normalized * radius;
		transform.rotation = Quaternion.LookRotation(transform.position) * Quaternion.Euler(90, 0, 0);
	}
}
