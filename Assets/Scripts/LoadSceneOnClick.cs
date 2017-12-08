using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

  
public class LoadSceneOnClick : MonoBehaviour {
    public Slider m_slider;
    public Text m_text; 
     public void LoadByIndex(int _sceneIndex)
    {
        StartCoroutine(LoadLevelAsync(_sceneIndex));
    }
    IEnumerator LoadLevelAsync(int _sceneIndexToLoad) {
        AsyncOperation operation = SceneManager.LoadSceneAsync(_sceneIndexToLoad);
        
        while (!operation.isDone) {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            m_slider.value = progress;
            m_text.text = progress * 100 + "%";
            Debug.Log("Chargement:" + operation.progress);
            yield return new WaitForSeconds(0f);//Entre dans l'awake
        }
    }
}
