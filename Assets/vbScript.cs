using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour,IVirtualButtonEventHandler
{

	private GameObject vbbuttonobject;
	private GameObject zombie;
	// Use this for initialization
	void Start ()
	{
		vbbuttonobject = GameObject.Find ("actionbutton");
		zombie = GameObject.Find ("zombie");
		vbbuttonobject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}
	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
	{
		Debug.Log ("Button yeahhh");
		zombie.GetComponent<Animation> ().Play ();
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
	{
		zombie.GetComponent<Animation> ().Stop ();
	}

}
