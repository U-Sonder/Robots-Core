using System.Threading;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace Game.Commands
{
    public class MoveCommand : BaseCommand
    {
        [SerializeField] private Transform _target;
        [SerializeField] private Vector3 _toValue;
        
        public override async UniTask ExecuteAsync(CancellationToken token)
        {
            await _target.DOMove(_toValue, _duration).ToUniTask(cancellationToken: token);
        }
    }
}