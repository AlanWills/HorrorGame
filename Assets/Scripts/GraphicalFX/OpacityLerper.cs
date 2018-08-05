using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace CelesteEngine.GraphicalFX
{
    public class OpacityLerper : MonoBehaviour
    {
        public Graphic graphic;
        public Color startColor;
        public Color endColour;
        public float lerpTime = 1;

        private Coroutine lerpCoroutine;

        public void LerpIn()
        {
            if (lerpCoroutine != null)
            {
                StopCoroutine(lerpCoroutine);
            }

            lerpCoroutine = StartCoroutine(Lerp(startColor, endColour));
        }

        public void LerpOut()
        {
            if (lerpCoroutine != null)
            {
                StopCoroutine(lerpCoroutine);
            }

            // Lerp out by flipping around the start and end colour
            lerpCoroutine = StartCoroutine(Lerp(endColour, startColor));
        }

        private IEnumerator Lerp(Color startingColour, Color endingColour)
        {
            if (lerpTime == 0)
            {
                graphic.color = startingColour;
            }
            else
            {
                float elapsedTime = 0;

                while (elapsedTime < lerpTime)
                {
                    graphic.color = Color.Lerp(startingColour, endingColour, elapsedTime / lerpTime);
                    elapsedTime += Time.deltaTime;

                    yield return null;
                }
            }
        }
    }
}