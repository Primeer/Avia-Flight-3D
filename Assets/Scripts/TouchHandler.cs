using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

[ExecuteInEditMode]
public class TouchHandler : MonoBehaviour
{
	public Transform obj;

	private void Update() {
		if (obj)
		{
			transform.position = obj.position;
			transform.rotation = obj.rotation;
		}
	}

	public void OnMouseDown() {
		// if (obj)
		{
			Debug.Log("touch");
			// Debug.Log($"{obj.name} touch");
			// GameManager.Instance.OnCityTouch(obj.gameObject);
		}
	}
}
