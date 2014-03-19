using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour
{

    // Skin to use for menu controls
    public GUISkin skin;

    // Handle pausing
    private bool _paused = false;
    public bool Paused
    {
        get
        {
            return _paused;
        }
        set
        {
            if (value != _paused)
            {
                Time.timeScale = value ? 0.0f : 1.0f;
                _paused = value;
            }
        }
    }
	
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

    // Handle pause event
    void OnApplicationPause(bool pauseStatus)
    {
        Paused = pauseStatus;
    }

    // Draw the menu
    void OnGUI()
    {
        // use the custom skin
        GUI.skin = skin;
    }
}
