# Testing Tool for Unity

A simple testing tool for Unity that allows users to assign a function manually in the inspector and fire it off with a Keycode of their choice. It enables users to configure multiple actions and keys in a list, and has several additional features to make it more comprehensive.

## Features

- Assign multiple key codes to the same action, this way you can fire the action using different key combinations.
- Specify a delay between action invocations to prevent accidental rapid-fire.
- Enable or disable the testing tool by toggling the `active` variable in the inspector, this way you can use it only when you need it.
- Drag and drop a method from any other script in the scene to the "Action Event" field.

## How to use

1. Add the `TestingTool.cs` script to any GameObject in your Unity scene.
2. In the inspector, add new elements to the "actionKeys" list.
3. Assign a Keycode or multiple keycodes to the action key, and drag and drop a method from any other script in the scene to the "Action Event" field.
4. Set the delay between action invocations to prevent accidental rapid-fire.
5. Enable or disable the testing tool by toggling the `active` variable in the inspector.

## Tips and suggestions

- Create an empty GameObject in your scene and attach the `TestingTool.cs` script to it. This way, you can easily access it from anywhere in your scene.
- Use the `TestingTool.cs` script to test your game mechanics and debug your game logic.
- Use the `TestingTool.cs` script to test different variations of your game mechanics and find the best one.
- You can also use the `TestingTool.cs` script to test different input methods and find the best one for your game.

## Conclusion

The `TestingTool.cs` script is a simple, yet powerful tool that can help you test your Unity game mechanics and debug your game logic. It allows you to assign multiple key codes to the same action and specify a delay between invocations, this way you can fire the action using different key combinations and prevent accidental rapid-fire. It also allows you to enable or disable the testing tool by toggling the `active` variable in the inspector, this way you can use it only when you need it.

Please let me know if you have any questions or suggestions, I would be happy to help you.

## Note
Please feel free to use and adapt this code to your needs.
