using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 38f;
    private float lowerBound = -15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Destroys game object if it leaves the screen
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if(transform.position.z < lowerBound) {
            Debug.Log("GAME OVER");
            Destroy(gameObject); 
        }
    }
}
