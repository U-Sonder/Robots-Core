using Cysharp.Threading.Tasks;

namespace Game.Commands
{
    public interface ICommand
    {
        UniTask ExecuteAsync();
    }
}