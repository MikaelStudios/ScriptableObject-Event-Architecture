
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BooleanEvent), editorForChildClasses: true)]
public class BooleanEventEditor : Editor
{
        
    public override void OnInspectorGUI()
    {

        base.OnInspectorGUI();
        //EditorGUILayout.PropertyField(serializedObject.FindProperty("m"));
        GUI.enabled = Application.isPlaying;
        BooleanEvent e = target as BooleanEvent;
        if (GUILayout.Button("Raise"))
            e.Raise(e.testProperty);
        }
    }

                     