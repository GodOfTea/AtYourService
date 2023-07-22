using PixelCrushers.DialogueSystem;
using Zenject;

namespace Infrastructure
{
    public class DialogueInstaller : MonoInstaller
    {
        public DialogueSystemController DialogueSystemController;
        
        public override void InstallBindings()
        {
            var dialogueInstance = Container.InstantiatePrefabForComponent<DialogueSystemController>(
                DialogueSystemController);

            Container.Bind<DialogueSystemController>().FromInstance(dialogueInstance).AsSingle();
        }
    }
}
