/*
    Unity3DTemplate
    Copyright © 2014 Ian Zachary Ledrick, also known as Thisita.

    This file is part of Unity3DTemplate.

    Unity3DTemplate is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Foobar is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Unity3DTemplate.  If not, see <http://www.gnu.org/licenses/>.
*/

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
