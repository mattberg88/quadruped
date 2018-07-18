using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class SerialPortHandler : MonoBehaviour {
	
	SerialPort sp = new SerialPort("/dev/cu.wchusbserial1410", 38400);
	string alphaNumeric = "0123456789abcdefghijklmnopqrstuvwxyz";
//	public GameObject FLShoulder;
//	public GameObject FRShoulder;
//	public GameObject RLShoulder;
//	public GameObject RRShoulder;
	public GameObject FLBicep;
	public GameObject FRBicep;
	public GameObject RLBicep;
	public GameObject RRBicep;
	public GameObject FLForearm;
	public GameObject FRForearm;
	public GameObject RLForearm;
	public GameObject RRForearm;

//	int fl_shoulder;
//	int fr_shoulder;
//	int rl_shoulder;
//	int rr_shoulder;
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

	void Update ()
	{
		if (!sp.IsOpen) {
			sp.Open ();
		}
//		
//			fl_shoulder = 120;
//			fr_shoulder = 20;
//			rl_shoulder = 120;
//			rr_shoulder = 20;
//		fl_shoulder = Mathf.RoundToInt(90 + (FLShoulder.transform.localEulerAngles.y) * -1);
//		fr_shoulder = Mathf.RoundToInt(120 - (FRShoulder.transform.localEulerAngles.y));
//		rl_shoulder = Mathf.RoundToInt(120 -(RLShoulder.transform.localEulerAngles.y));
//		rr_shoulder = Mathf.RoundToInt(-1 * (RRShoulder.transform.localEulerAngles.y) - 100);

		fl_bicep = Mathf.RoundToInt ((260 - FLBicep.transform.localEulerAngles.z)/5);
		fr_bicep = Mathf.RoundToInt ((FRBicep.transform.localEulerAngles.z - 60)/5);
		rl_bicep = Mathf.RoundToInt ((RLBicep.transform.localEulerAngles.z - 60)/5);
		rr_bicep = Mathf.RoundToInt ((240 - RRBicep.transform.localEulerAngles.z)/5);

		fl_forearm = Mathf.RoundToInt ((FLForearm.transform.localEulerAngles.z - 230)/5);
		fr_forearm = Mathf.RoundToInt ((400 - FRForearm.transform.localEulerAngles.z)/5);
		rl_forearm = Mathf.RoundToInt ((400 - RLForearm.transform.localEulerAngles.z)/5);
		rr_forearm = Mathf.RoundToInt ((RRForearm.transform.localEulerAngles.z - 180)/5);


//			Debug.Log (
//				(fl_forearm.ToString ("000")) +
//				(fr_forearm.ToString ("000")) +
//				(rl_forearm.ToString ("000")) +
//				(rr_forearm.ToString ("000")) 
//				(fl_bicep.ToString ("000")) 
//				(fr_bicep.ToString ("000")) + 
//				(rl_bicep.ToString ("000")) + 
//				(rr_bicep.ToString ("000")) 
//			);
		Debug.Log(
			(alphaNumeric[fl_forearm].ToString()) +
			(alphaNumeric[fr_forearm].ToString()) +
			(alphaNumeric[rl_forearm].ToString()) +
			(alphaNumeric[rr_forearm].ToString()) +
			(alphaNumeric[fl_bicep].ToString()) +
			(alphaNumeric[fr_bicep].ToString()) +
			(alphaNumeric[rl_bicep].ToString()) +
			(alphaNumeric[rr_bicep].ToString()) 
		);
			sp.Write (
			(alphaNumeric[fl_forearm].ToString()) +
			(alphaNumeric[fr_forearm].ToString()) +
			(alphaNumeric[rl_forearm].ToString()) +
			(alphaNumeric[rr_forearm].ToString()) +
			(alphaNumeric[fl_bicep].ToString()) +
			(alphaNumeric[fr_bicep].ToString()) +
			(alphaNumeric[rl_bicep].ToString()) +
			(alphaNumeric[rr_bicep].ToString()) 

//				(rl_forearm.ToString ("000")) +
//				(rr_forearm.ToString ("000")) 
//				(fl_bicep.ToString ("000")) 
//				(fr_bicep.ToString ("000")) + 
//				(rl_bicep.ToString ("000")) + 
//				(rr_bicep.ToString ("000")) 
		);

	
		

//		
	}


}
