using UnityEngine;
using System.Collections;

public class PollfishDemo : MonoBehaviour
{
	public void OnGUI()
	{
		if (GUI.Button(new Rect(10, 10, 150, 100), "Open Pollfish"))
		{
			Pollfish.ShowPollfish();
		}

		if (GUI.Button(new Rect(10, 120, 150, 100), "Close Pollfish"))
		{
			Pollfish.ClosePollfish();
		}
	}
}
