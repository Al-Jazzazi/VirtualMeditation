using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControlScript : MonoBehaviour
{
    // Creates a static varible for a MusicControlScript instance
    public static MusicControlScript instance; 

    private void Awake() // Runs before void Start()
    {
        // If the There is no instance variable meaning it is null
        if (instance == null) 
        {
            // The music will play
            instance = this; 
        }

        // If there is any other instances of this object 
        else
        {
            // Destroy this gameObject
            Destroy(gameObject); 
        }
        //The else segment is added in case in futre development we decide to add more music or instructor voices in the same scene to the project 
    }
}
