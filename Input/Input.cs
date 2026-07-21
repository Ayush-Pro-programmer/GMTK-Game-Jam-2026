using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace GMTK_Game_Jam;

public static class Input
{
    private static KeyboardState _currentKeyboard;
    private static KeyboardState _previousKeyboard;

    private static MouseState _currentMouse;
    private static MouseState _previousMouse;

    public static void Update()
    {
        _previousKeyboard = _currentKeyboard;
        _currentKeyboard = Keyboard.GetState();

        _previousMouse = _currentMouse;
        _currentMouse = Mouse.GetState();
    }

    public static bool IsKeyDown(Keys key) => _currentKeyboard.IsKeyDown(key);
    public static bool IsKeyUp(Keys key) => _currentKeyboard.IsKeyUp(key);

    public static bool IsKeyPressed(Keys key) =>
        _currentKeyboard.IsKeyDown(key) && 
        _previousKeyboard.IsKeyUp(key);

    public static bool IsKeyReleased(Keys key) =>
        _currentKeyboard.IsKeyUp(key) &&
        _previousKeyboard.IsKeyDown(key);

    public static Vector2 MousePosition => _currentMouse.Position.ToVector2();
    public static int MouseWheelDelta => _currentMouse.ScrollWheelValue - _previousMouse.ScrollWheelValue;

    public static bool IsLeftMouseDown() => _currentMouse.LeftButton == ButtonState.Pressed;
    public static bool IsLeftMouseUp() => _currentMouse.LeftButton == ButtonState.Released;

    public static bool IsLeftMousePressed() => 
        _currentMouse.LeftButton == ButtonState.Pressed && 
        _previousMouse.LeftButton == ButtonState.Released;

    public static bool IsLeftMouseReleased() => 
        _currentMouse.LeftButton == ButtonState.Released && 
        _previousMouse.LeftButton == ButtonState.Pressed;

    public static bool IsRightMouseDown() => _currentMouse.RightButton == ButtonState.Pressed;
    public static bool IsRightMouseUp() => _currentMouse.RightButton == ButtonState.Released;

    public static bool IsRightMousePressed() => 
        _currentMouse.RightButton == ButtonState.Pressed && 
        _previousMouse.RightButton == ButtonState.Released;

    public static bool IsRightMouseReleased() => 
        _currentMouse.RightButton == ButtonState.Released && 
        _previousMouse.RightButton == ButtonState.Pressed;

    public static bool IsMiddleMouseDown() =>
    _currentMouse.MiddleButton == ButtonState.Pressed;

    public static bool IsMiddleMousePressed() =>
        _currentMouse.MiddleButton == ButtonState.Pressed &&
        _previousMouse.MiddleButton == ButtonState.Released;
}

