using SLua;
using UnityEngine;

[CustomLuaClass]
public class UnityUtil
{
    public static bool GetInputKeyDown(KeyCode keyCode)
    {
        return Input.GetKeyDown(keyCode);
    }
}