using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderSceneSO : MonoBehaviour
{
    [SerializeField] private SceneSO[] scenes;

    public void LoadScenes()
    {
        if (scenes.Length >0)
        {
            foreach (var item in scenes)
            {
                SceneManager.LoadSceneAsync(item.SceneName, LoadSceneMode.Additive);
            }
        }
        
    }
}
