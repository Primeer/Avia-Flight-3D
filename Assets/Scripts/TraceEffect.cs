using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraceEffect : MonoBehaviour
{
	public LineRenderer line;
	private int index;

	public void Init()
	{
		line = new GameObject("Line").AddComponent<LineRenderer>();
		
		line.useWorldSpace = false;
		line.transform.parent = transform.parent;
		line.transform.localRotation = Quaternion.identity;
		
		index = -1;
		line.positionCount = index + 1;

		line.startWidth = 3f;

		line.material = Resources.Load<Material>("Materials/Trace");
		line.startColor = Color.green;
		line.endColor = Color.green;
	}
	
	public void AddPoint(Vector3 point)
	{
		index++;
		line.positionCount = index + 1;
		
		line.SetPosition(index, point);

		// line.transform.rotation = Quaternion.identity;

		// if (line.positionCount >= 1000)
		// {
		// 	line.Simplify(1f);
		// 	index = line.positionCount;
		// 	line.positionCount++;
		// }
	}

	public void DestroyLine()
	{
		Destroy(line.gameObject);
	}
}
