using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
	public bool mobile;
	void Update()
	{
		if (mobile)
		{
			if (Input.touchCount > 0)
			{
				Touch touch = Input.GetTouch(0);

				switch (touch.phase)
				{
					case TouchPhase.Began:
						Ray ray = Camera.main.ScreenPointToRay((Vector3)touch.position);
						RaycastHit hit;
						if (Physics.Raycast(ray, out hit))
						{
							if (hit.collider.gameObject.tag == "City")
								Debug.Log(hit.collider.gameObject.name);
								GameManager.Instance.OnCityTouch(hit.collider.gameObject);
						}
						break;

					case TouchPhase.Moved:

						break;

					case TouchPhase.Ended:

						break;
				}
			}
		}
		else
		{
			if (Input.GetMouseButtonDown(0))
			{
				Ray ray = Camera.main.ScreenPointToRay((Vector3)Input.mousePosition);
				RaycastHit hit;
				if (Physics.Raycast(ray, out hit))
				{
					if (hit.collider.gameObject.tag == "City")
						Debug.Log(hit.collider.gameObject.name);
						GameManager.Instance.OnCityTouch(hit.collider.gameObject);
				}
			}
		}
	}
}
