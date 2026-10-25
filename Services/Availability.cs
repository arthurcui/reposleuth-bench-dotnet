namespace BookingDesk;
public class Availability(BookingStore store) {
    private int? cachedCount;
    public int Count() => cachedCount ??= store.Rows.Count;
    public void Add(string guest) {
        store.Add(new Booking(store.Rows.Count+1,guest,"",DateTime.UtcNow,100m,"pending"));
    }
}
