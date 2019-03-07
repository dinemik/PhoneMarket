namespace PhoneMarket.Models
{
    using System;
    using System.Data.Entity;
    using System.IO;
    using System.Linq;

    public class PhonesDb : DbContext
    {
        public DbSet<Phone> Phones { get; set; }

        public PhonesDb()
            : base("name=PhonesDatabase")
        {
        }

        public class DropAndCreateDb : DropCreateDatabaseAlways<PhonesDb>
        {
            protected override void Seed(PhonesDb context)
            {
                context.Phones.Add(new Phone
                {
                    Firm = "Samsung",
                    Model = "Galaxy S8",
                    Processor = "exynos 7885",
                    Resolution = "2000x 1080",
                    ScreenSize = 5.5d,
                    Size = 6,
                    Storage = 64,
                    System = "android",
                    Weight = 1.1d,
                    Price = 300,
                    Img = "https://www.boostmobile.com/content/dam/boostmobile/en/products/phones/samsung/galaxy-s8/black/device-front.png.transform/pdpCarousel/image.jpg"
                });

                context.Phones.Add(new Phone
                {
                    Firm = "Samsung",
                    Model = "note 8",
                    Processor = "exynos 7885",
                    Resolution = "2000x 1080",
                    ScreenSize = 6.5d,
                    Size = 6,
                    Storage = 64,
                    System = "android",
                    Weight = 1.4d,
                    Price = 400,
                    Img = "https://image.coolblue.nl/422x390/products/871336",
                    Video = "https://www.youtube.com/embed/IZMA3G3HSoM?autoplay=0"
                });

                context.Phones.Add(new Phone
                {
                    Firm = "Apple",
                    Model = "Iphone 6s",
                    Processor = "apple a11",
                    Resolution = "720x 180",
                    ScreenSize = 3.1d,
                    Size = 6,
                    Storage = 32,
                    System = "ios",
                    Weight = 1.1d,
                    Price = 200,
                    Img = "data:image/jpeg;base64,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"
                });

                context.Phones.Add(new Phone
                {
                    Firm = "Apple",
                    Model = "Iphone X",
                    Processor = "apple a50",
                    Resolution = "800x 1080",
                    ScreenSize = 5.5d,
                    Size = 6,
                    Storage = 64,
                    System = "ios",
                    Weight = 1.1d,
                    Price = 600,
                    Img = "https://res.cloudinary.com/spectrumobile/image/fetch/e_trim/w_360,h_480,c_fit,f_auto,q_auto,fl_lossy/http%3A%2F%2Fres.cloudinary.com%2Fspectrumobile%2Fimage%2Fupload%2Fv1527810361%2FSpecturm%2520Mobile%2520Buy%2520Flow%2FApple%2FiPhone%2520X%2FMQA62LLA_HERO.png"
                });

                context.Phones.Add(new Phone
                {
                    Firm = "Samsung",
                    Model = "note 9",
                    Processor = "exynos 8885",
                    Resolution = "2000x 1080",
                    ScreenSize = 6.5d,
                    Size = 6,
                    Storage = 128,
                    System = "android",
                    Weight = 1.1d,
                    Price = 500,
                    Img = "https://cdn.eglobalcentraluk.com/images/detailed/70/samsung-galaxy-note-9-n960fd-dual-sim-6gb-128gb-blue.jpg",
                    Video = "https://www.youtube.com/embed/IZMA3G3HSoM?autoplay=0"
                });

                context.SaveChanges();
            }
        }
    }
}