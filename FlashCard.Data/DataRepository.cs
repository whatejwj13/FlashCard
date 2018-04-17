namespace FlashCard.Data
{
    public class DataRepository
    {
        public static CardData Card { get; } = new CardData();

        public static CardImageData CardImage { get; } = new CardImageData();

        public static ReviewData Review { get; } = new ReviewData();

        public static FormLocationData FormLocation { get; } = new FormLocationData();
    }
}