using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class SerialPortHandler : MonoBehaviour {
	SerialPort sp = new SerialPort("/dev/cu.usbmodem1411", 9600);
	public GameObject cylinder;
	public GameObject cylinder2;
	float xAngle;
	float xAngle2;
	void Start () {
		
		sp.Open ();
		sp.ReadTimeout = 1;
	}

	void Update () 
	{
		if (!sp.IsOpen) {
			Debug.Log ("hmm");
			sp.Open ();
		}
		xAngle2 = (cylinder2.transform.rotation.y)*180 + 1000;
		xAngle = (cylinder.transform.rotation.y)*180;
			Debug.Log (xAngle2.ToString());
		sp.Write (xAngle.ToString());
		sp.Write (xAngle2.ToString());
		

			
	
	}
}