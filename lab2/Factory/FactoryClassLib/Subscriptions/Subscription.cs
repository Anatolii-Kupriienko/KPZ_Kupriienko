using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryClassLib
{
    public abstract class Subscription
    {
        private DateTime ExpieryDate;
        public virtual decimal Fee { get; protected set; }
        public virtual TimeSpan MinDuration { get; protected set; }
        public virtual bool CanDownload { get; protected set; }
        public virtual string[] AvailableConent { get; init; }


        protected void SetExpieryDate(DateTime expieryDate)
        {
            if (expieryDate - DateTime.Now < this.MinDuration)
            {
                throw new InvalidOperationException("Subscription duration must be at least " + this.MinDuration.Days + " days");
            }
            this.ExpieryDate = expieryDate;
        }
        public DateTime GetExpieryDate()
        {
            return this.ExpieryDate;
        }
        public void Cancel()
        {
            this.ExpieryDate = DateTime.Now;
        }
        public Subscription Continue(TimeSpan timePeriod)
        {
            if (this.IsValid())
            {
                this.ExpieryDate = this.ExpieryDate.Add(timePeriod);
            }
            else
            {
                this.ExpieryDate = DateTime.Now.Add(timePeriod);
            }
            return this;
        }
        public bool IsValid()
        {
            return DateTime.Now < this.ExpieryDate;
        }

        public override string ToString()
        {
            return $"Subscription type: {this.GetType().Name}\n" +
                $"Fee: {this.Fee}\n" +
                $"Min duration: {this.MinDuration.Days} days\n" +
                $"Can download: {this.CanDownload}\n" +
                $"Expiry date: {this.ExpieryDate}\n" +
                $"Avaliable content: {string.Join(", ", this.AvailableConent)}\n";
        }

    }
}