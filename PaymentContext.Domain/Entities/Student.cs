using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValueObject;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        private IList<Subscription> _subscriptions;
        public Student(string v, Name name, string document, string email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public Name Name { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            // 1 - Opção se já tiver uma assinatura ativa, cancela

            // 2 - Opção Cancela todas as assinaturas e coloca esta
            //     como principal
            foreach (var subs in Subscriptions)
                subs.Inactivate();

            _subscriptions.Add(subscription);
        }
    }
}