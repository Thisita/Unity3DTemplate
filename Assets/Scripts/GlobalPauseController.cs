using UnityEngine;
using System.Collections;

public class GlobalPauseController : MonoBehaviour
{
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

    // Handle pause event
    void OnApplicationPause(bool pauseStatus)
    {
        Paused = pauseStatus;
    }
}
