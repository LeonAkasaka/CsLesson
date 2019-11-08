using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    [SerializeField]
    private HomeScene _homePanel = null;

    [SerializeField]
    private StoreScene _storePanel = null;

    [SerializeField]
    private EnhancerScene _enhancerPanel = null;

    public Scenes CurrentScene { get; private set; }

    public IEnumerable<GameObject> Panels
    {
        get
        {
            yield return _homePanel.gameObject;
            yield return _storePanel.gameObject;
            yield return _enhancerPanel.gameObject;
        }
    }
    
    void Start()
    {
        CurrentScene = Scenes.Home;
    }

    public Task Change(Scenes scene)
    {
        if (CurrentScene == scene) { return Task.CompletedTask; }

        var beforePanel = GetCurrentScenePanel();
        beforePanel.SetActive(false);

        CurrentScene = scene;
        var afterPanel = GetCurrentScenePanel();
        afterPanel.SetActive(true);

        return Task.CompletedTask;
    }

    public GameObject GetCurrentScenePanel()
    {
        switch (CurrentScene)
        {
            case Scenes.Home:
                return _homePanel.gameObject;
            case Scenes.Store:
                return _storePanel.gameObject;
            case Scenes.Enhancer:
                return _enhancerPanel.gameObject;
        }
        return null;
    }
}
