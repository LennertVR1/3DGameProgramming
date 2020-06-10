using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject tutorialDoor;
    public List<GameObject> elevatorDoor;
    public int keycardPickup = 0;
    public int thingPickup = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(tutorialDoor == null)
        {
            tutorialDoor = GameObject.FindWithTag("TutorialDoor");
        }
        if (elevatorDoor.Count == 0)
        {
            foreach (GameObject door in GameObject.FindGameObjectsWithTag("ElevatorDoor"))
            {
                elevatorDoor.Add(door);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(keycardPickup == 2)
        {
            Destroy(tutorialDoor);
        }
        if(thingPickup == 1)
        {
            foreach (GameObject door in elevatorDoor)
            {
                Destroy(door);
            }
        }
    }
}
