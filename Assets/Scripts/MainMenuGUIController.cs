using UnityEngine;
using System.Collections;

public class MainMenuGUIController : MonoBehaviour
{
    // Skin to use for menu controls
    public GUISkin skin;
	
	// Update is called once per frame
	void Update()
    {
	    // Handle mobile application back button event
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Exit the application
            Application.Quit();
        }
	}

    // Draw the menu
    void OnGUI()
    {
        // use the custom skin
        GUI.skin = skin;
    }
}
