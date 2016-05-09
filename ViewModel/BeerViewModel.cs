namespace TDC2016MVVM
{
    public class BeerViewModel : BaseViewModel
    {
        private const string BEER_IMAGE_1 = "beerImage1.jpg";
        private const string BEER_IMAGE_2 = "beerImage2.jpg";
        private const string BEER_IMAGE_4 = "beerImage4.jpg";
        private const string BEER_IMAGE_6 = "beerImage6.jpg";
        private const string BEER_IMAGE_8 = "beerImage8.jpg";
        private const string BEER_IMAGE_12 = "beerImage12.png";
        private const string BEER_IMAGE_16 = "beerImage16.jpg";
        private const string BEER_IMAGE_20 = "beerImage20.jpg";

        private int drankBeersCount;

        public BeerViewModel()
        {
            User = ServiceLocator.UserService.CurrentUser;
        }

        public User User { get; set; }

        public int DrankBeersCount
        {
            get
            {
                return this.drankBeersCount;
            }
            set
            {
                SetPropertyAndNotify(ref this.drankBeersCount, value);
                OnPropertyChanged(nameof(DrunkenPersonImage));
            }
        }

        public string DrunkenPersonImage
        {
            get { return GetBeerImage(DrankBeersCount); }
        }

        private string GetBeerImage(int beerCount)
        {
            if (beerCount <= 1)
            {
                return BEER_IMAGE_1;
            }

            if (beerCount == 20)
            {
                return BEER_IMAGE_20;
            }

            if (beerCount >= 2 && beerCount < 4)
            {
                return BEER_IMAGE_2;
            }

            if (beerCount >= 4 && beerCount < 6)
            {
                return BEER_IMAGE_4;
            }

            if (beerCount >= 6 && beerCount < 8)
            {
                return BEER_IMAGE_6;
            }

            if (beerCount >= 8 && beerCount < 12)
            {
                return BEER_IMAGE_8;
            }

            if (beerCount >= 12 && beerCount < 16)
            {
                return BEER_IMAGE_12;
            }

            if (beerCount >= 16 && beerCount < 20)
            {
                return BEER_IMAGE_16;
            }

            return BEER_IMAGE_1;
        }
    }
}

