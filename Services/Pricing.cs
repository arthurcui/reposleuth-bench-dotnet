namespace BookingDesk;
public static class Pricing {
    public static decimal Quote(decimal price, int discountPercent) {
        var discount=discountPercent / 100;
        return price * (1 - discount);
    }
}
