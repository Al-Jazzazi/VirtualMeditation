/*
The popus exist in the forest class as mean to communicate with the user, giving 
them some background about the scenes and some essentials of meditating 

There are three popups that appear consecultively as the user presses next 
*/


using UnityEngine;

public class Popups : MonoBehaviour
{

    //Three instances repreasenting the three popups 
    [SerializeField]
    private GameObject popup1;
    [SerializeField]
    private GameObject popup2;
    [SerializeField]
    private GameObject popup3;

    
//The first time the user presses next, it removes the first popup and moves to the second popup  
    public void next1()
    {
        popup1.SetActive(false);
        popup2.SetActive(true);
        popup3.SetActive(false);
    }

//THe second next, it closes the scond popup and moves to the third popup
    public void next2()
    {
        popup2.SetActive(false);
        popup3.SetActive(true);
    }
//When the user presses close it removes all the popups, allowing the user to enjoy the scene
    public void close()
    {
        popup3.SetActive(false);
    }
}
