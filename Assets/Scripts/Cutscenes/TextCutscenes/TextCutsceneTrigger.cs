using UnityEngine;

namespace CelesteEngine.Cutscenes.TextCutscenes
{
    public class TextCutsceneTrigger : MonoBehaviour
    {
        #region Properties and Fields

        public TextCutscene textCutscene;

        #endregion

        #region Unity Methods

        public void Start()
        {
            TextCutsceneManager.Instance.ShowCutscene(textCutscene);
        }

        #endregion
    }
}