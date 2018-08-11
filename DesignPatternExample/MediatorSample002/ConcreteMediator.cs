using System.Collections.Generic;
using System.Linq;

namespace MediatorSample002
{
    public class ConcreteMediator
    {
        private List<Colleague> _colleague;

        public ConcreteMediator()
        {
            _colleague = new List<Colleague>();
        }

        public void AddColleague(Colleague colleague)
        {
            if (!_colleague.Any((x) => x == colleague))
            {
                colleague.MessageSended += Colleague_MessageSended;
                _colleague.Add(colleague);
            }
        }

        public void RemoveColleague(Colleague colleague)
        {
            if (_colleague.Any((x) => x == colleague))
            {
                colleague.MessageSended -= Colleague_MessageSended;
                _colleague.Remove(colleague);
            }
        }

        private void Colleague_MessageSended(object sender, string e)
        {
            var items = _colleague.Where((x) => x != sender);
            foreach (var item in items)
            {
                item.Notify(e);
            }
        }
    }
}