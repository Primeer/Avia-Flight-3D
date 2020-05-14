using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragHandler : MonoBehaviour
{
	public bool mobile;

	public Vector3 PlayerInput;
    public Vector3 LastPlayerInput;
    public float LastMagnitude;
    public bool Pressed;
	

    void Update()
    {
        if(mobile)
		{
			if(Input.touchCount > 0)
			{
				Touch touch = Input.GetTouch(0);

				switch(touch.phase)
				{
					case TouchPhase.Began:
						Pressed = true;
						break;

					case TouchPhase.Moved:
						var horizontalRotation = -touch.deltaPosition.x / 100f;
						var verticalRotation = touch.deltaPosition.y / 100f;

						PlayerInput = new Vector3(horizontalRotation, verticalRotation, 0);
						break;

					case TouchPhase.Ended:
						LastPlayerInput = PlayerInput;
						LastMagnitude = PlayerInput.magnitude;
						PlayerInput = Vector3.zero;
						Pressed = false;
						break;
				}
			}
		}
		else
		{
			Pressed = Input.GetMouseButton(0);

			if (Input.GetMouseButton(0))
			{
				var horizontalRotation = -Input.GetAxis("Mouse X");
				var verticalRotation = Input.GetAxis("Mouse Y");

				PlayerInput = new Vector3(horizontalRotation, verticalRotation, 0);
			}

			if (Input.GetMouseButtonUp(0))
			{
				LastPlayerInput = PlayerInput;
				LastMagnitude = PlayerInput.magnitude;
				PlayerInput = Vector3.zero;
			}
		}
	}

}