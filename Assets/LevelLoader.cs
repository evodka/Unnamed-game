using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator transition;
    public float transitionTime;

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0){
            GameObject[] enemy = GameObject.FindGameObjectsWithTag("Enemy");
                if (enemy.Length == 0)
            {
                LoadNextLevel();
            }
        }

        else if (SceneManager.GetActiveScene().buildIndex == 1){
            GameObject[] boss = GameObject.FindGameObjectsWithTag("Boss");
            if (boss.Length == 0){
                LoadNextLevel();
            }
        }


    }

    public void LoadNextLevel()
    {

        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
