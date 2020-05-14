using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Task
{
	public GameObject originCity;
	public GameObject destinationCity;
}

public class TaskCreator
{
    public static TaskHandler CreateRandomTask()
	{
		Task task = new Task();

		int index1 = Random.Range(0, GameManager.Instance.cities.Count);
		
		int delta = Random.Range(-3, 4);
		if(delta == 0) delta++;

		int index2 = index1 + delta;

		if(index2 < 0) index2 += GameManager.Instance.cities.Count;
		if(index2 >= GameManager.Instance.cities.Count) index2 -= GameManager.Instance.cities.Count;

		while(index1 == index2)
		{
			index2 = Random.Range(0, GameManager.Instance.cities.Count);
		}

		task.originCity = GameManager.Instance.cities[index1];
		task.destinationCity = GameManager.Instance.cities[index2];

		return new TaskHandler(task);
	}
}
