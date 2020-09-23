namespace csharp
{
    class ItemAgedWell: Item
    {
        private int QualityFactor = 1;

        public void UpdateQuality(Item item)
        {
            item.Quality = item.Quality + QualityFactor;
        }
    }
}
