using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroVideoToGameplay : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private string gameplaySceneName = "Gameplay";
    private const string INTRO_KEY = "IntroPlayed";

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoFinished;
        videoPlayer.Play();
    }

    private void OnVideoFinished(VideoPlayer vp)
    {
        LoadGameplay();
    }

    public void SkipVideo()
    {
        LoadGameplay();
    }

    private void LoadGameplay()
    {
        SceneManager.LoadScene(gameplaySceneName);
    }
}
