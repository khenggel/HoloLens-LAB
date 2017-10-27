using Assets.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AppController : MonoBehaviour {

    public GameObject manager;
    public GameObject view;
    public GameObject mainMenuPrefab;

    private GameObject eventSystem;

    private GameObject mainMenu;
    private World world;

	// Use this for initialization
	void Start () {
        world = new World();

        // create event system
        createEventSystem();

        // create main menu
        createMainMenu();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // still unused
    public void addBrick(Transform transform)
    {
        Brick newBrick = new Brick(1, 1, 1, new List<Brick>(), transform);
        world.addBrick(newBrick);
    }

    // just instantiate through this script instead of in unity
    private void createEventSystem()
    {
        eventSystem = new GameObject("EventSystem");
        eventSystem.transform.SetParent(manager.transform, true);
        EventSystem es = eventSystem.AddComponent<EventSystem>();
        es.sendNavigationEvents = true;
        es.pixelDragThreshold = 5;
        StandaloneInputModule sim = eventSystem.AddComponent<StandaloneInputModule>();
        sim.horizontalAxis = "Horizontal";
        sim.verticalAxis = "Vertical";
        sim.submitButton = "Submit";
        sim.cancelButton = "Cancel";
        sim.inputActionsPerSecond = 10;
        sim.repeatDelay = 0.5f;
        sim.forceModuleActive = false;
    }

    // just instantiate from prefab (in this script instead of in unity)
    private void createMainMenu()
    {
        mainMenu = Instantiate(mainMenuPrefab, new Vector3(2, 3, 2), Quaternion.identity);
        mainMenu.transform.SetParent(view.transform, true);
        mainMenu.transform.Find("PlacementButton").gameObject.GetComponent<AddMultipleCubes>().manager = manager;
    }
}
