using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorHelper : MonoBehaviour
{
	public static Color city = new Color(0.8f, 0.8f, 0.8f);
	
	public static void Repaint(GameObject obj, Color color)
	{
		foreach(MeshRenderer renderer in obj.GetComponentsInChildren<MeshRenderer>())
		{
			renderer.material.color = color;
		}
	}
}
