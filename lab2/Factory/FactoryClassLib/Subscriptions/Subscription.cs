using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryClassLib
{
    public abstract class Subscription
    {
        private DateTime ExpiryDate;
        public virtual decimal Fee { get; protected set; }
        public virtual TimeSpan MinDuration { get; protected set; }
        public virtual bool CanDownload { get; protected set; }
        public virtual string[] AvailableConent { get; init; }


        public void SetExpiryDate(DateTime expiryDate)
        {
            if (expiryDate - DateTime.Now < this.MinDuration)
            {
                throw new InvalidOperationException("Subscription duration must be at least " + this.MinDuration.Days + " days");
            }
            this.ExpiryDate = expiryDate;
        }
        public DateTime GetExpirationDate()
        {
            return this.ExpiryDate;
        }
        public void Cancel()
        {
            this.ExpiryDate = DateTime.Now;
        }
        public Subscription Continue(TimeSpan timePeriod)
        {
            if (this.IsValid())
            {
                this.ExpiryDate = this.ExpiryDate.Add(timePeriod);
            }
            else
            {
                this.ExpiryDate = DateTime.Now.Add(timePeriod);
            }
            return this;
        }
        public bool IsValid()
        {
            return DateTime.Now < this.ExpiryDate;
        }

        public override string ToString()
        {
            return $"Subscription type: {this.GetType().Name}\n" +
                $"Fee: {this.Fee}\n" +
                $"Min duration: {this.MinDuration.Days} days\n" +
                $"Can download: {this.CanDownload}\n" +
                $"Expiry date: {this.ExpiryDate}\n" +
                $"Avaliable content: {string.Join(", ", this.AvailableConent)}\n";
        }

    }
}