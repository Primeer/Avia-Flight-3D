using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightManager : MonoBehaviour
{
	public GameObject planePrefab;
	public void StartFlight(Task task)
	{
		GameObject plane = Instantiate(planePrefab);
		plane.GetComponent<Flight>().Init(task);
	}
}
