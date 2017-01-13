using UnityEngine;
using System;

public class GoBackToEarth : MonoBehaviour {

	public static Action CloseThisHolographicView;
	// Use this for initialization

	void OnSelect () {
		if (!this.GetComponent<Rigidbody>())
		{
			CloseThisHolographicView();
		}
	}

}