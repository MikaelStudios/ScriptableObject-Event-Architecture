
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(WeaponDataEvent), editorForChildClasses: true)]
public class WeaponDataEventEditor : Editor
{
        
    public override void OnInspectorGUI()
    {

        base.OnInspectorGUI();
        //EditorGUILayout.PropertyField(serializedObject.FindProperty("m"));
        GUI.enabled = Application.isPlaying;
        WeaponDataEvent e = target as WeaponDataEvent;
        if (GUILayout.Button("Raise"))
            e.Raise(e.testProperty);
        }
    }

                     