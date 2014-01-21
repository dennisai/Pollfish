using UnityEngine;
using System;
using System.Collections;
using System.Runtime.InteropServices;

public class Pollfish : MonoBehaviour
{
	#region Properties

	public string DeveloperKey;

	#endregion


	#region Initialization

	public void Awake()
	{
#if UNITY_IPHONE
		// Pollfish.Initialize(DeveloperKey);
#endif
	}

	#endregion

#if UNITY_IPHONE

	#region API
	/*
	[DllImport ("__Internal")]
    private static extern void _Initialize(string developerKey);

    // Initializes Pollfish.
	public static void Initialize(string developerKey)
	{
		if (!string.IsNullOrEmpty(developerKey))
		{
			_Initialize(developerKey);
		}
	}
	*/

	[DllImport ("__Internal")]
    private static extern void _ShowPollfish();

    // Manually show Pollfish.
    public static void ShowPollfish()
    {
    	_ShowPollfish();
    }

    [DllImport ("__Internal")]
    private static extern void _HidePollfish();

    // Manually hide Pollfish.
    public static void HidePollfish()
    {
    	_HidePollfish();
    }

	#endregion


	#region Events

    public static event Action surveyCompletedEvent;
    public static event Action surveyOpenedEvent;
    public static event Action surveyClosedEvent;
    public static event Action surveyReceivedEvent;

    public void surveyCompleted()
    {
    	if (surveyCompletedEvent != null)
    		surveyCompletedEvent();
    }

    public void surveyOpened()
    {
    	if (surveyOpenedEvent != null)
    		surveyOpenedEvent();
    }

    public void surveyClosed()
    {
    	if (surveyClosedEvent != null)
    		surveyClosedEvent();
    }

    public void surveyReceived()
    {
    	if (surveyReceivedEvent != null)
    		surveyReceivedEvent();
    }

    #endregion

#endif

}
