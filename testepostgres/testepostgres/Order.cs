namespace testepostgres
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int iD, double latitude, double longitude, int status)
        {
            ID = iD;
            Latitude = latitude;
            Longitude = longitude;
            Status = status;
        }

        public int ID { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        // 1 - aberto; 2 - fechado
        public int Status { get; private set; }
    }
}
