using Flashcards.m1chael888.Repositories;
using Flashcards.m1chael888.Models;

namespace Flashcards.m1chael888.Services
{
    public interface IManageService
    {
        void StackCreate(string stackName);
        List<StackModel> StacksRead();
        void StackUpdate(StackModel stack);
        void StackDelete(StackModel stack);

    }
    public class ManageService : IManageService
    {
        private IStackRepository _stackRepository;
        public ManageService(IStackRepository stackRepository)
        {
            _stackRepository = stackRepository;
        }

        public void StackCreate(string stackName)
        {
            _stackRepository.Create(stackName);
        }

        public List<StackModel> StacksRead()
        {
            return _stackRepository.Read();
        }

        public void StackUpdate(StackModel stack)
        {
            _stackRepository.Update(stack);
        }

        public void StackDelete(StackModel stack)
        {
            _stackRepository.Delete(stack.StackId);
        }
    }
}
