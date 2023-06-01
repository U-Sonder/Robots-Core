using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace Game.Commands
{
    public class RotateCommand : BaseCommand<Vector3>
    {
        [SerializeField] private Transform _target;
        
        public override async UniTask ExecuteAsync()
        {
            await _target.DORotate(_toValue, _duration).ToUniTask();
        }
    }
}