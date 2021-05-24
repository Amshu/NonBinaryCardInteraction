using UnityEngine;

using Lean.Touch;

public class CustomTouchInputHandler : MonoBehaviour
{
    private int screenHeight = 0;

    private void Awake()
    {
        // et the height of the screen
        screenHeight = Screen.height;
    }

    public void OnFingerSwipe(LeanFinger finger)
    {
        int screenY = (int)finger.StartScreenPosition.y;

        // Check if the swipe was on top or bottom half of the screen
        if (screenY > screenHeight * 0.5)
        {
            Debug.Log( "Top");
            
            // Change top screen object
        }
        else
        {
            Debug.Log("Down");
            
            // Change bottom screen object
        }
    }
}
