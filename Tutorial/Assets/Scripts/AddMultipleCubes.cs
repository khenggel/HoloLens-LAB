using HoloToolkit.Examples.Prototyping;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMultipleCubes : MonoBehaviour
{
    public GameObject manager;
    private GameObject view;

	// Use this for initialization
	void Start () {

    }

    private void OnMouseUp()
    {
        // create variables
        view = manager.GetComponent<AppController>().view;
        GameObject mainMenu = view.transform.Find("MainMenu(Clone)").gameObject;

        // create new cube object and set it up
        GameObject newTarget = Instantiate(Resources.Load("Cube") as GameObject);
        newTarget.transform.position = mainMenu.transform.position;
        newTarget.transform.rotation = mainMenu.transform.rotation;
        newTarget.transform.SetParent(view.transform, true);

        // set up its SetMenu script
        newTarget.GetComponent<SetMenu>().Target = mainMenu;
        newTarget.GetComponent<SetMenu>().manager = manager;

        // set up its MoveWithObject script
        MoveWithObject newobject = newTarget.GetComponent<MoveWithObject>();
        newobject.ReferenceObject = view.transform.Find("HoloLensCamera").gameObject;
        newobject.StartRunning();

    }

    // Update is called once per frame
    void Update () {
		
	}
}
