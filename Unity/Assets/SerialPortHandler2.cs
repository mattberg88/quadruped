using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class SerialPortHandler2 : MonoBehaviour {

	SerialPort sp = new SerialPort("/dev/cu.wchusbserial1410", 38400);

	string alphaNumeric = "0123456789abcdefghijklmnopqrstuvwxyz";
	string sendString;

	public GameObject FLShoulder;
	public GameObject FRShoulder;
	public GameObject RLShoulder;
	public GameObject RRShoulder;
	public GameObject FLBicep;
	public GameObject FRBicep;
	public GameObject RLBicep;
	public GameObject RRBicep;
	public GameObject FLForearm;
	public GameObject FRForearm;
	public GameObject RLForearm;
	public GameObject RRForearm;

	int fl_shoulder;
	int fr_shoulder;
	int rl_shoulder;
	int rr_shoulder;
	int fl_bicep;
	int fr_bicep;
	int rl_bicep;
	int rr_bicep;
	int fl_forearm;
	int fr_forearm;
	int rl_forearm;
	int rr_forearm;

	void Start () {

		sp.Open ();
		sp.ReadTimeout = 1;

	}

	void Update () {

		if (!sp.IsOpen) {
			sp.Open ();
		}

		fl_forearm = Mathf.RoundToInt (FLForearm.transform.localEulerAngles.z);
		fr_forearm = Mathf.RoundToInt (FRForearm.transform.localEulerAngles.z);
		rl_forearm = Mathf.RoundToInt (RLForearm.transform.localEulerAngles.z);
		rr_forearm = Mathf.RoundToInt (RRForearm.transform.localEulerAngles.z);

		fl_bicep = Mathf.RoundToInt (FLBicep.transform.localEulerAngles.z);
		fr_bicep = Mathf.RoundToInt (FRBicep.transform.localEulerAngles.z);
		rl_bicep = Mathf.RoundToInt (RLBicep.transform.localEulerAngles.z);
		rr_bicep = Mathf.RoundToInt (RRBicep.transform.localEulerAngles.z);

		fl_shoulder = Mathf.RoundToInt(FLShoulder.transform.localEulerAngles.y);
		fr_shoulder = Mathf.RoundToInt(FRShoulder.transform.localEulerAngles.y);
		rl_shoulder = Mathf.RoundToInt(RLShoulder.transform.localEulerAngles.y);
		rr_shoulder = Mathf.RoundToInt(RRShoulder.transform.localEulerAngles.y);

		sendString = (
			(fl_forearm.ToString("000")) +
			(fr_forearm.ToString("000")) +
			(rl_forearm.ToString("000")) +
			(rr_forearm.ToString("000")) +
			(fl_bicep.ToString("000")) +
			(fr_bicep.ToString("000")) +
			(rl_bicep.ToString("000")) +
			(rr_bicep.ToString("000")) +
			(fl_shoulder.ToString("000")) +
			(fr_shoulder.ToString("000")) +
			(rl_shoulder.ToString("000")) +
			(rr_shoulder.ToString("000"))
		);

		Debug.Log(sendString);

		sp.Write (sendString);

	}
}
