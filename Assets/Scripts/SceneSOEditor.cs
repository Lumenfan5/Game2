#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public partial class SceneSO : ScriptableObject, ISerializationCallbackReceiver
{
    public SceneAsset SceneAsset;

    public void OnAfterDeserialize()
    {
       
    }

    public void OnBeforeSerialize()
    {
        if (SceneAsset != null)
        {
            SceneName = SceneAsset.name;
        }
        else SceneName = string.Empty;
    }
}

 #endif