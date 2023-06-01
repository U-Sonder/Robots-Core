using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Game
{
    public class Robot : MonoBehaviour
    {
        [SerializeField] private bool _executeOnAwake;
        [SerializeField] private Instruction[] _instructions;

        private void Awake()
        {
            if (_executeOnAwake)
            {
                Execute();
            }
        }

        [ContextMenu("Execute")]
        private void Execute()
        {
            ExecuteInstructionsAsync().Forget();
        }

        private async UniTask ExecuteInstructionsAsync()
        {
            foreach (var instruction in _instructions)
            {
                await instruction.ExecuteAsync();
            }
        }
    }
}