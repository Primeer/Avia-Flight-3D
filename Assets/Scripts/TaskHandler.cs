using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskHandler
{
	public Task task;

	public bool completed;
	private bool isOriginCityCheck;

	public TaskHandler(Task t)
	{
		task = t;
	}

	public bool CheckCity(GameObject city)
	{
		if(!isOriginCityCheck)
		{
			if (IsOriginCity(city))
			{
				Debug.Log("Origin City checked");
				isOriginCityCheck = true;
				return true;
			}
		}
		else
		{
			if (IsDestinationCity(city))
			{
				Debug.Log("Destination City checked");
				completed = true;
				return true;
			}
		}
		return false;
	}

	public bool IsOriginCity(GameObject city)
	{
		return city == task.originCity;
	}

	public bool IsDestinationCity(GameObject city)
	{
		return city == task.destinationCity;
	}
}
