using System;

namespace dz7_4
{
    enum Colortype
    {
        Red,
        Blue,
        Yellow,
        Black
    };
    enum SizeType
    {
        X,
        XL,
        L,
        M
    };
    interface itemApply
    {
        void ApplyDiscount(String discount);
        void ApplyPromocode(String promocode);
    }

    interface itemColor
    {
        void SetColor(byte color);
    }

    interface iteSize
    {
        void SetSize(byte size);
    }

    interface iTemPrice
    {
        void SetPrice(double price);
    }

    class Book : itemApply, iTemPrice
    {
        private String _discount;
        private String _promocode;
        private double _price;

        public void ApplyDiscount(String discount)
        {
            _discount = discount;
        }

       public  void ApplyPromocode(String promocode)
        {
            if (promocode != string.Empty)
            {
                _promocode = promocode;

            }
            else _promocode = "You dont have promocode";
        }
        
        public void SetPrice(double price)
        {
            _price = price;
        }

        public void Count()
        {
            
            if (_promocode == "You dont have promocode")
            {
                Console.WriteLine("{0} Your discount is {1} so your price is {2}", _promocode, _discount, _price);
            }
            else Console.WriteLine("Your promocode is {0}, your discount is {1} + 5% so your price is {2}", _promocode, _discount, _price);

        }

    }
    class Clothes  : itemColor, iteSize, iTemPrice, itemApply
    {
        private String _discount;
        private String _promocode;
        private double _price;
        private SizeType type1;
        private Colortype type2;
        

        public void ApplyDiscount(String discount)
        {
            _discount = discount;
        }

        public void ApplyPromocode(String promocode)
        {
            if (promocode != string.Empty)
            {
                _promocode = promocode;

            }
            else _promocode = "You dont have promocode";
        }

        public void SetPrice(double price)
        {
            _price = price;
        }
        public void SetSize(byte size)
        {
            switch (size)
            {
                case 0:
                    type1 = SizeType.X;
                    break;
                case 1:
                    type1 = SizeType.XL;
                    break;
                case 2:
                    type1 = SizeType.L;
                    break;
                case 3:
                    type1 = SizeType.M;
                    break;
                default:
                    type1 = SizeType.L;
                    break;
            }
               
            
        }
        public void SetColor(byte color)
        {
            switch (color)
            {
                case 0:
                    type2 =Colortype.Red;
                    break;
                case 1:
                    type2 = Colortype.Blue;
                    break;
                case 2:
                    type2 = Colortype.Yellow;
                    break;
                case 3:
                    type2 = Colortype.Black;
                    break;
                default:
                    type2= Colortype.Black;
                    break;
            }
        }

        public void Count()
        {

            if (_promocode == "You dont have promocode")
            {
                Console.WriteLine("Clothes with {3} color, and {4} size,{0} Your discount is {1} so your price is {2}"
                                        , _promocode, _discount, _price, type2, type1);
            }
            else Console.WriteLine("Clothes with {3} color, and {4} size. Your promocode is {0}, your discount is {1} + 10% so your price is {2}"
                                        , _promocode, _discount, _price, type2, type1);

        }

    }
    class Test
    {
        public void BookClass()
        {
            Book book = new Book();
            book.ApplyDiscount("15%");
            book.ApplyPromocode("Pre");
            book.SetPrice(565);
            book.Count();
            Clothes shirts = new Clothes();
            shirts.ApplyDiscount("20");
            shirts.ApplyPromocode("Predict");
            shirts.SetPrice(1200);
            shirts.SetColor(1);
            shirts.SetSize(2);
            shirts.Count();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Test test = new Test();
            test.BookClass();




        }
    }

}
