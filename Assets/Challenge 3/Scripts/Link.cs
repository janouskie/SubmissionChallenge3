﻿using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

	public void OpenGitHub()
	{
		#if !UNITY_EDITOR
		openWindow("https://github.com/janouskie/SubmissionChallenge3");
		//openWindow("https://github.com/janouskie/Challenge-3-");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}