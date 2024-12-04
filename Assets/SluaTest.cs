using System.Collections.Generic;
using System.IO;
using SLua;
using UnityEditor;
using UnityEngine;

public class SluaTest : MonoBehaviour
{
    private LuaSvr L;
    public GameObject prefab;
    private readonly List<GameObject> _objects = new List<GameObject>();

    [MenuItem("Tools/Test")]
    public static void Test()
    {
        var txt = File.ReadAllText($"{Application.dataPath}/Lua/SluaTest.lua");
        var asset = new TextAsset(txt);
        var asset1 = AssetDatabase.LoadAssetAtPath($"Assets/Lua/SluaTest.lua", typeof(UnityEngine.Object));
        Debug.Log(asset.text);
        Debug.Log(asset1 as TextAsset);
    }


    // Start is called before the first frame update
    void Start()
    {
        L = new LuaSvr();
        L.init(tick, Complete, LuaSvrFlag.LSF_BASIC | LuaSvrFlag.LSF_EXTLIB);
    }


    void tick(int p)
    {
        Debug.Log($"tick:{p}");
    }

    private void OnDestroy()
    {
        DelayedDestroy();
    }

    private void DelayedDestroy()
    {
        Debug.Log("DelayedDestroy");
        LuaSvr.mainState.Dispose();
        LuaSvr.mainState = null;
    }


    void Complete()
    {
        // l.start("");
        // object o = LuaSvr.mainState.getFunction("foo").call(1, 2, 3);
        // object[] array = (object[])o;
        // for (int n = 0; n < array.Length; n++)
        //     Debug.Log(array[n]);
        //
        // string s = (string)LuaSvr.mainState.getFunction("str").call(new object[0]);
        Debug.Log("SLua init complete.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            var canvas = GameObject.Find("Canvas");
            _objects.Add(Instantiate(prefab, canvas.transform));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            foreach (var o in _objects)
            {
                Destroy(o);
            }

            _objects.Clear();
        }
    }
}