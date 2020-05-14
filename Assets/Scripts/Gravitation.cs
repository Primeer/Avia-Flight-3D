using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Gravitation : MonoBehaviour
{
	void Update()
    {
		GetComponent<Rigidbody>().AddForce(-transform.position / 1000f);
	}
}
