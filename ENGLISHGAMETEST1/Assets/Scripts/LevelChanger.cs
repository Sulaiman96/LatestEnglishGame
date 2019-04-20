using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator anim;

    public string nextSceneName;
    private string nextScene;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            FadeToLevel(nextSceneName);

        }
    }

    public void FadeToLevel(string sceneName)
    {
        nextScene = sceneName;
        anim.SetTrigger("FadeOut");
    }

    public void FadeCompletion()
    {
        SceneManager.LoadScene(nextScene);
    }
}
