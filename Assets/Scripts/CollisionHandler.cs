using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other) 
    {
        switch(other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This is friendly!");
                break;
            case "Finish":
                Debug.Log("This is the finish line!");
                break;
            case "Fuel":
                Debug.Log("This is fuel!");
                break;
            default:
                Debug.Log("You blew up!");
                break;
        }

    }
}
