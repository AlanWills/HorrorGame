using CelesteEngine.GraphicalFX;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace CelesteEngine.Cutscenes.TextCutscenes
{
    public class TextCutsceneManager : MonoBehaviour
    {
        #region Properties and Fields

        public static TextCutsceneManager Instance { get; private set; }

        public float secondsPerLetter = 0.05f;
        public Text cutsceneText;
        public Text quoteeText;

        private Coroutine cutsceneCoroutine;

        #endregion

        #region Unity Methods

        public void Awake()
        {
            if (Instance == null)
            {
                Instance = FindObjectOfType<TextCutsceneManager>();
            }
        }

        #endregion

        #region Utility Functions

        public void ShowCutscene(TextCutscene textCutscene)
        {
            cutsceneText.text = textCutscene.text;
            quoteeText.text = textCutscene.quotee;

            if (cutsceneCoroutine != null)
            {
                StopCoroutine(cutsceneCoroutine);
            }

            OpacityLerper cutSceneLerper = cutsceneText.GetComponent<OpacityLerper>();
            cutSceneLerper.LerpIn();
            quoteeText.GetComponent<OpacityLerper>().LerpIn();

            cutsceneCoroutine = StartCoroutine(TimeCutscene((secondsPerLetter * textCutscene.text.Length) + cutSceneLerper.lerpTime));
        }

        private IEnumerator TimeCutscene(float showTime)
        {
            float currentTime = 0;
            while (currentTime < showTime)
            {
                currentTime += Time.deltaTime;
                yield return null;
            }

            cutsceneText.GetComponent<OpacityLerper>().LerpOut();
            quoteeText.GetComponent<OpacityLerper>().LerpOut();
        }

        #endregion
    }
}
