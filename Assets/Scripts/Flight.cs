using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{
	private float speed => GameManager.Instance.planeSpeed;
	private float height => GameManager.Instance.flightHeight;
	private Task task;
	private Vector3 destination;
	private float radius;
	private TraceEffect trace;

	public void Init(Task t)
	{
		task = t;

		radius = task.destinationCity.transform.position.magnitude;
		SetPosition(task.originCity);

		trace = GetComponent<TraceEffect>();
		trace?.Init();
	}

    void Update()
    {
		destination = task.destinationCity.transform.position + task.destinationCity.transform.up * height;
		Vector3 newPosition = SphereGeometry.MoveTowards(transform.position, destination, Time.deltaTime * speed, radius + height);
		transform.rotation = Quaternion.LookRotation(newPosition - transform.position, transform.position);
		transform.position = newPosition;

		trace?.AddPoint(transform.localPosition);

		if((transform.position - task.destinationCity.transform.position).sqrMagnitude < height * height + 10)
			FinishFlight();
	}

	private void SetPosition(GameObject city)
	{
		transform.parent = city.transform.parent;
		transform.position = city.transform.position;
		transform.position += city.transform.up * height;
		transform.rotation = Quaternion.LookRotation(newPosition - transform.position, transform.position);
	}

	private void FinishFlight()
	{
		trace?.DestroyLine();
		Destroy(gameObject);
	}
}
