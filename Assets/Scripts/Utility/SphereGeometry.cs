using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGeometry : MonoBehaviour
{
    
	public static Vector3 SphereToWorld(Vector2 geoCoords)
	{

		return Vector3.zero;
	}

	public static Vector3 Lerp(Vector3 a, Vector3 b, float t, float radius = 311f)
	{
		Vector3 rawPoint = Vector3.Lerp(a, b, t);

		return rawPoint.normalized * radius;
	}

	public static Vector3 MoveTowards(Vector3 a, Vector3 b, float delta, float radius = 311f)
	{
		Vector3 rawPoint = Vector3.MoveTowards(a, b, delta);

		return rawPoint.normalized * radius;
	}
}
