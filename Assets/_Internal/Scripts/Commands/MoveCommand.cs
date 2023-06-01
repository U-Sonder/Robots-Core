using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace Game.Commands
{
    public class MoveCommand : BaseCommand<Vector3>
    {
        [SerializeField] private Transform _target;
        
        public override async UniTask ExecuteAsync()
        {
            await _target.DOMove(_toValue, _duration).ToUniTask();
        }
    }
}