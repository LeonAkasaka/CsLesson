using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SceneChangeButton : MonoBehaviour
{
    [SerializeField]
    private SceneManager _manager = null;

    [SerializeField]
    private Scenes _scene = Scenes.Home;

    private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();
        var e = new Button.ButtonClickedEvent();
        e.AddListener(() =>
        {
            _manager.Change(_scene);
        });
        _button.onClick = e;
    }
}
