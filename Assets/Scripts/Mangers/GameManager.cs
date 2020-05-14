using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
	public float radius = 311f;
	public float flightHeight = 40f;
	public float planeSpeed = 40f;

	public List<GameObject> cities;

	private UIManager UI;
	private FlightManager flightManager;

	private TaskHandler taskHandler;
	void Start()
    {
		UI = FindObjectOfType<UIManager>();
		flightManager = GetComponent<FlightManager>();

		CreateTask();
	}

	public void OnCityTouch(GameObject city)
	{
		if(taskHandler.CheckCity(city))
			UI?.RemoveMarker(city);

		if(taskHandler.completed)
			OnTaskComplete();
	}

	public void OnTaskComplete()
	{
		Debug.Log("Task Complete");

		flightManager?.StartFlight(taskHandler.task);

		CreateTask();
	}

    private void CreateTask()
	{
		taskHandler = TaskCreator.CreateRandomTask();
		UI?.SetTask(taskHandler.task);
	}
}
