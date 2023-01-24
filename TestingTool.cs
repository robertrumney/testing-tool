using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class TestingTool : MonoBehaviour
{
    // custom class that inherits from UnityEvent
    [System.Serializable]
    public class ActionEvent : UnityEvent { }

    // class that contains the key code, action event and delay for a single action
    [System.Serializable]
    public class ActionKey
    {
        public KeyCode[] keyCodes;   // array of key codes that trigger the action
        public ActionEvent actionEvent;  // the action event to invoke when the key code is pressed
        public float delay;          // delay between action invocations to prevent accidental rapid-fire
        private float timeStamp;     // keeps track of the last time the action was invoked

        // checks if the delay has passed before allowing the action to be invoked
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

    public List<ActionKey> actionKeys; // list of actions that can be assigned to key codes
    public bool active = true; // check if testing tool is active or not

    // Update is called once per frame
    private void Update()
    {
        if (!active) return; // return if testing tool is not active
        // iterate through all actions
        foreach (var actionKey in actionKeys)
        {
            // iterate through all key codes assigned to the action
            foreach (var keyCode in actionKey.keyCodes)
            {
                // check if the key code is pressed and the delay has passed
                if (Input.GetKeyDown(keyCode) && actionKey.CanInvoke())
                {
                    // invoke the action event
                    actionKey.actionEvent.Invoke();
                }
            }
        }
    }
}
