namespace csharp
{
    class ItemAgedBad: Item
    {
        private int QualityFactor = -1;

        public void UpdateQuality (Item item)
        {
            item.Quality = item.Quality + QualityFactor;
        }
    }
}
