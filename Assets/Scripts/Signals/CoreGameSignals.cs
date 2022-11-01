using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class CoreGameSignals : MonoBehaviour
{
    #region Singleton
    public static CoreGameSignals Instance;
    
    private void Awake()
    {
        if(Instance!= null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        Debug.LogWarning(Instance.GetInstanceID().ToString());

    }

    #endregion

    public UnityAction<GameStates> onChangeGameState = delegate { };
    public UnityAction<int> onLevelInitalizie = delegate { };
    public UnityAction onClearActiveLevel = delegate { };
    public UnityAction onLevelFailed = delegate { };
    public UnityAction onLevelSuccsessfuk = delegate { };
    public UnityAction onNextLevel = delegate { };
    public UnityAction onRestartLevel = delegate { };
    public UnityAction onReset = delegate { };


    //public UnityAction onSaveGameData = delegate { };
}
