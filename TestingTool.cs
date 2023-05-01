using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class TestingTool : MonoBehaviour
{
    // Custom class that inherits from UnityEvent.
    [System.Serializable]
    public class ActionEvent : UnityEvent { }

    // Class that contains the key code, action event and delay for a single action.
    [System.Serializable]
    public class ActionKey
    {
        // Array of key codes that trigger the action.
        public KeyCode[] keyCodes;
        
        // The action event to invoke when the key code is pressed.
        public ActionEvent actionEvent;
        
        // Delay between action invocations to prevent accidental rapid-fire.
        public float delay;
        
        // Keeps track of the last time the action was invoked.
        private float timeStamp;

        // Checks if the delay has passed before allowing the action to be invoked.
        public bool CanInvoke()
        {
            if (Time.time >= timeStamp + delay)
            {
                timeStamp = Time.time;
                return true;
            }
            return false;
        }
    }

    // List of actions that can be assigned to key codes.
    public List<ActionKey> actionKeys;
    
    // Check if testing tool is active or not.
    public bool active = true;

    // Update is called once per frame.
    private void Update()
    {
        // Return if testing tool is not active.
        if (!active) return;
        
        // Iterate through all actions.
        foreach (var actionKey in actionKeys)
        {
            // Iterate through all key codes assigned to the action.
            foreach (var keyCode in actionKey.keyCodes)
            {
                // Check if the key code is pressed and the delay has passed.
                if (Input.GetKeyDown(keyCode) && actionKey.CanInvoke())
                {
                    // Invoke the action event.
                    actionKey.actionEvent.Invoke();
                }
            }
        }
    }
}
