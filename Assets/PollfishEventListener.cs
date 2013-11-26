using UnityEngine;
using System.Collections;

public class PollfishEventListener : MonoBehaviour
{
	public void OnEnable()
	{
		/*
		Pollfish.surveyCompletedEvent += surveyCompleted;
		Pollfish.surveyOpenedEvent += surveyOpened;
		Pollfish.surveyClosedEvent += surveyClosed;
		Pollfish.surveyReceivedEvent += surveyReceived;
		*/
	}

	public void OnDisable()
	{
		/*
		Pollfish.surveyCompletedEvent -= surveyCompleted;
		Pollfish.surveyOpenedEvent -= surveyOpened;
		Pollfish.surveyClosedEvent -= surveyClosed;
		Pollfish.surveyReceivedEvent -= surveyReceived;
		*/
	}

	public void surveyCompleted()
	{
		Debug.Log("Survey was completed.");
	}

	public void surveyOpened()
	{
		Debug.Log("Survey was opened.");
	}

	public void surveyClosed()
	{
		Debug.Log("Survey was closed.");
	}

	public void surveyReceived()
	{
		Debug.Log("Survey was received.");
	}
}
