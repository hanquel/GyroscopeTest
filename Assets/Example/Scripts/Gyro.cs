using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gyro : MonoBehaviour {

	[SerializeField]
	private Text attitude = null;

	[SerializeField]
	private Text gravity = null;

	[SerializeField]
	private Text rotationRate = null;

	[SerializeField]
	private Text rotationRateUnbiased = null;

	[SerializeField]
	private Text userAcceleration = null;

	[SerializeField]
	private Text deviceOrientation = null;

	[SerializeField]
	private Text screenOrientation = null;

	void Start() {
		Input.gyro.enabled = true;
	}

	void Update() {
		attitude.text = "Attitude: " + Input.gyro.attitude.eulerAngles.ToString ();
		gravity.text = "Gravity: " + Input.gyro.gravity.ToString ();
		rotationRate.text = "RotationRate: " + Input.gyro.rotationRate.ToString ();
		rotationRateUnbiased.text = "RotationRateUnbiased: " + Input.gyro.rotationRateUnbiased.ToString ();
		userAcceleration.text = "UserAcceleration: " + Input.gyro.userAcceleration.ToString ();
		deviceOrientation.text = "DeviceOrientation: " + Input.deviceOrientation.ToString ();
		screenOrientation.text = "ScreenOrientation: " + Screen.orientation.ToString ();
	}
}
