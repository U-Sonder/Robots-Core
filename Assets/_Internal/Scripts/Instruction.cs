using Cysharp.Threading.Tasks;
using Game.Commands;
using UnityEngine;

namespace Game
{
    public class Instruction : MonoBehaviour
    {
        [SerializeField] private BaseCommand[] _commands;

        [ContextMenu("Execute")]
        private void Execute()
        {
            ExecuteAsync().Forget();
        }

        public async UniTask ExecuteAsync()
        {
            var token = this.GetCancellationTokenOnDestroy();
            foreach (var command in _commands)
            {
                await command.ExecuteAsync(token);
            }
        }
    }
}