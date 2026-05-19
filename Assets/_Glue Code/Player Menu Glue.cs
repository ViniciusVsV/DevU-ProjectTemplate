using MenuSystem;
using UnityEngine;

public class PlayerMenuGlue : MonoBehaviour
{
    private PauseMenuController pauseMenuController;

    private void Start()
    {
        pauseMenuController = PauseMenuController.Instance;
    }

    private void OnEnable()
    {
        Player.InputHandler.OnPausePressed += TogglePause;
    }
    private void OnDisable()
    {
        Player.InputHandler.OnPausePressed -= TogglePause;
    }

    public void TogglePause(bool activate)
    {
        pauseMenuController.TogglePause(activate);
    }
}
