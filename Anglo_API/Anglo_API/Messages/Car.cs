namespace Anglo_API.Messages
{
    public class Car
    {
        protected bool Equals(Car other)
        {
            return make == other.make && model == other.model && year == other.year && type == other.type &&
                   zeroToSixty.Equals(other.zeroToSixty) && price == other.price;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Car)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (make != null ? make.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (model != null ? model.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (year != null ? year.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (type != null ? type.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ zeroToSixty.GetHashCode();
                hashCode = (hashCode * 397) ^ price;
                return hashCode;
            }
        }

        public string make { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public string type { get; set; }
        public double zeroToSixty { get; set; }
        public int price { get; set; }
    }
}