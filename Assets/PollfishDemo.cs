using UnityEngine;
using System.Collections;

public class PollfishDemo : MonoBehaviour
{
	public void OnGUI()
	{
		if (GUI.Button(new Rect(10, 10, 620, 100), "Open Pollfish"))
		{
			Debug.Log("Open Pullfish Button pressed.");

			Pollfish.ShowPollfish();
		}

		if (GUI.Button(new Rect(10, 120, 620, 100), "Close Pollfish"))
		{
			Pollfish.HidePollfish();
		}
	}
}
