using System;
using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet.Inventory.Money
{
    public class Money
    {
        public static readonly Money OneThousand = new Money(1000);

        public static readonly Money OneHundred = new Money(100);

        public decimal value { get; }

        public Money(int value) => this.value = value;

        public Money(decimal value) => this.value = value;

        public static Money operator +(Money a, Money b) => new Money(a.value + b.value);
        public static Money operator -(Money a, Money b) => new Money(a.value - b.value);
        public static Money operator %(Money a, int p) => new Money(a.value * (100m - p) / 100m);

        public static bool operator >(Money a, Money b) => a.value.CompareTo(b.value) > 0;
        public static bool operator <(Money a, Money b) => a.value.CompareTo(b.value) < 0;
        public static bool operator >=(Money a, Money b) => a.value.CompareTo(b.value) > 0 || a.value.CompareTo(b.value) == 0;
        public static bool operator <=(Money a, Money b) => a.value.CompareTo(b.value) < 0 || a.value.CompareTo(b.value) == 0;

        //public static bool operator ==(Money a, Money b) => a.value.CompareTo(b.value) == 0;
        //public static bool operator !=(Money a, Money b) => a.value.CompareTo(b.value) != 0;

        public virtual Money ReduceBy(int p)
        {
            return new Money(value * (100m - p) / 100m);
        }

        public virtual bool MoreThan(Money other)
        {
            return this.value.CompareTo(other.value) > 0;
        }

        public override bool Equals(object other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            if (ReferenceEquals(null, other) || other.GetType() != this.GetType())
            {
                return false;
            }
            var that = (Money)other;
            return this.value.Equals(that.value);
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

    }
}
