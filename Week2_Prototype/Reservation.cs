class Reservation
{
    public string GuestName { get; }
    public int RoomNumber { get; }
    public int NumberOfNights { get; private set; }
    public bool IsCancelled { get; private set; }

    public Reservation(string guestName, int roomNumber, int numberOfNights)
    {
        GuestName = guestName;
        RoomNumber = roomNumber;
        NumberOfNights = numberOfNights;
        IsCancelled = false;
    }

    public bool ExtendStay(int additionalNights)
    {
        if (IsCancelled || additionalNights <= 0)
        {
            return false;
        }

        NumberOfNights += additionalNights;
        return true;
    }

    public void Cancel()
    {
        IsCancelled = true;
    }
}
