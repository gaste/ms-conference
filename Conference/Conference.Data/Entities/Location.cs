using System;

namespace Conference.Data.Entities
{
    public class Location
    {
        public Location(Guid locationId, string addressStreet, string addressNumber, string addressPostCode, string addressCity,
                        string addressCountry, decimal addressCoordinatesLongitude, decimal addressCoordinatesLatitude,
                        string roomName, int floor, decimal squareMetersOfAvailableSpace, int amountOfAvailableSeats,
                        decimal expensesPerDay, decimal cateringCostsPerSeat)
        {
            this.LocationId = locationId;
            this.AddressStreet = addressStreet;
            this.AddressNumber = addressNumber;
            this.AddressPostCode = addressPostCode;
            this.AddressCity = addressCity;
            this.AddressCountry = addressCountry;
            this.AddressCoordinatesLongitude = addressCoordinatesLongitude;
            this.AddressCoordinatesLatitude = addressCoordinatesLatitude;
            this.RoomName = roomName;
            this.Floor = floor;
            this.SquareMetersOfAvailableSpace = squareMetersOfAvailableSpace;
            this.AmountOfAvailableSeats = amountOfAvailableSeats;
            this.ExpensesPerDay = expensesPerDay;
            this.CateringCostsPerSeat = cateringCostsPerSeat;
        }

        public Guid LocationId { get; private set; }
        public string AddressStreet { get; private set; }
        public string AddressNumber { get; private set; }
        public string AddressPostCode { get; private set; }
        public string AddressCity { get; private set; }
        public string AddressCountry { get; private set; }
        public decimal AddressCoordinatesLongitude { get; private set; }
        public decimal AddressCoordinatesLatitude { get; private set; }
        public string RoomName { get; private set; }
        public int Floor { get; private set; }
        public decimal SquareMetersOfAvailableSpace { get; private set; }
        public int AmountOfAvailableSeats { get; private set; }
        public decimal ExpensesPerDay { get; private set; }
        public decimal CateringCostsPerSeat { get; private set; }
    }
}
