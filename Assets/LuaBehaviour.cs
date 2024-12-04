using SLua;
using UnityEngine;

public class LuaBehaviour : MonoBehaviour
{
    public string scriptName;
    private LuaTable _luaTable;
    private Circle.UpdateDelegate _start;
    private LuaFunction _update;
    private Circle.UpdateDelegate _onDestroy;

    // Start is called before the first frame update
    void Start()
    {
        _luaTable = (LuaTable)LuaSvr.mainState.doFile(scriptName);
        _luaTable["transform"] = transform;
        _luaTable["gameObject"] = gameObject;
        _start = ((LuaFunction)_luaTable["Start"]).cast<Circle.UpdateDelegate>();
        _update = (LuaFunction)_luaTable["Update"];
        _onDestroy = ((LuaFunction)_luaTable["OnDestroy"]).cast<Circle.UpdateDelegate>();
        _start(_luaTable);
    }

    // Update is called once per frame
    void Update()
    {
        if (_update != null)
        {
            _update.call(_luaTable);
        }
    }

    private void OnDestroy()
    {
        if (_onDestroy != null)
        {
            _onDestroy(_luaTable);
        }
        
        _start = null;
        _onDestroy = null;
    }
}