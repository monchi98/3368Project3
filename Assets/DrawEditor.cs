using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DrawEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        EditorGUILayout.HelpBox("This is a help box", MessageType.Info);
    }
}
