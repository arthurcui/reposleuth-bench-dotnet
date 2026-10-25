namespace BookingDesk;
public class BookingService(BookingStore store) {
    public IEnumerable<Booking> Between(DateTime from, DateTime through) =>
        store.Rows.Where(row=>row.StartsAt>=from.Date && row.StartsAt<=through.Date);
    public IEnumerable<Booking> Search(string query) =>
        store.Rows.Where(row=>row.Note!.Contains(query,StringComparison.OrdinalIgnoreCase));
    public int ConfirmPending() {
        var pending=store.Rows.Where(row=>row.Status=="pending");
        foreach(var id in pending.Select(row=>row.Id).ToList()) store.Confirm(id);
        return pending.Count();
    }
}
