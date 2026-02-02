using Flashcards.m1chael888.Repositories;

namespace Flashcards.m1chael888.Services
{
    public interface IStackService
    {
        void CallStackRepoCreate(string stackName);
    }
    public class StackService : IStackService
    {
        private IStackRepository _stackRepository;
        public StackService(IStackRepository stackRepository)
        {
            _stackRepository = stackRepository;
        }

        public void CallStackRepoCreate(string stackName)
        {
            _stackRepository.Create(stackName);
        }

        public void CallStackRepoRead()
        {

        }

        public void CallStackRepoUpdate()
        {

        }

        public void CallStackRepoDelete()
        {

        }
    }
}
