namespace BookingDesk;
public record Booking(int Id, string Guest, string? Note, DateTime StartsAt, decimal Price, string Status);
public class BookingStore {
    public List<Booking> Rows { get; } = [
        new(1,"Avery",null,new DateTime(2026,10,1,10,0,0,DateTimeKind.Utc),100m,"pending"),
        new(2,"Blair","window",new DateTime(2026,10,2,10,0,0,DateTimeKind.Utc),80m,"pending"),
        new(3,"Casey","quiet",new DateTime(2026,10,2,18,0,0,DateTimeKind.Utc),60m,"confirmed")];
    public void Confirm(int id) { var i=Rows.FindIndex(row=>row.Id==id); Rows[i]=Rows[i] with {Status="confirmed"}; }
    public void Add(Booking row) => Rows.Add(row);
}
