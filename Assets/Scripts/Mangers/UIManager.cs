using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
	public GameObject startMarkerPrefab;
	public GameObject finishMarkerPrefab;

	private Dictionary<GameObject, GameObject> markers;

	private Text task;

	private void Awake() {
		markers = new Dictionary<GameObject, GameObject>();

		task = transform.Find("TaskText").GetComponent<Text>();
	}

	public void SetTask(Task t)
	{
		task.text = $"{t.originCity.name} - {t.destinationCity.name}";

		ColorHelper.Repaint(t.originCity, Color.cyan);
		ColorHelper.Repaint(t.destinationCity, Color.magenta);

		// SetMarker(startMarkerPrefab, t.originCity);
		// SetMarker(finishMarkerPrefab, t.destinationCity);
	}

	private void SetMarker(GameObject prefab, GameObject city)
	{
		GameObject marker = Instantiate(prefab);
		marker.transform.parent = city.transform;
		marker.transform.localPosition = new Vector3(0f, 24f, 0f);
		marker.transform.localRotation = Quaternion.identity;

		markers.Add(city, marker);
	}

	public void RemoveMarker(GameObject city)
	{
		// Destroy(markers[city]);
		// markers.Remove(city);

		ColorHelper.Repaint(city, ColorHelper.city);
	}
}
