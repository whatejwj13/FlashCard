namespace FlashCard.Data.Models
{
    public class Cell
    {
        public Cell(int cellNo, int cardCount)
        {
            CellNo = cellNo;
            CardCount = cardCount;
        }

        public int CellNo { get; private set; }

        public int CardCount { get; set; }
    }
}