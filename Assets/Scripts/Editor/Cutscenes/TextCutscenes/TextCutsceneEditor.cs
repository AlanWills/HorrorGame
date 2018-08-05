using CelesteEngine.Cutscenes.TextCutscenes;
using CelesteEngineEditor.Utilities;
using UnityEditor;

namespace CelesteEngineEditor.Cutscenes.TextCutscenes
{
    public class TextCutsceneEditor
    {
        #region Factory Creation

        [MenuItem("Assets/Create/Celeste Engine/Text Cutscene")]
        public static void CreateAsset()
        {
            ScriptableObjectUtility.CreateAsset<TextCutscene>();
        }

        #endregion
    }
}