using System;
using System.Collections.Generic;
namespace AppT_Shirt
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            foreach (TShirt shirt in ListTShirt())
            {
                shoppingCart.AddTShirtToShoppingCart(shirt);
            }
            User jame = JameInformation(
            Address(),
            shoppingCart
            );
            Console.WriteLine("Total cost: {0}", jame.shoppingCart.TotalCost());
        }
        static List<TShirt> ListTShirt()
        {
            List<TShirt> listTShirt = new List<TShirt>();
            listTShirt.Add(new TShirt("L", "Red", 500.0f, "RedImage.png"));
            listTShirt.Add(new TShirt("M", "Black", 750.0f, "BlackImage.png"));
            listTShirt.Add(new TShirt("S", "Blue", 625.0f, "BlueImage.png"));
            return listTShirt;
        }
        static Address Address()
        {
            return new Address("131/75 พุทธมณฑล", "นครปฐม", "10180");
        }
        static User JameInformation(Address address, ShoppingCart shoppingCart)
        {
            return new User(
            "Jame Watson",
            "jame@gmail.com",
            address,
            shoppingCart
            );
        }
    }
    //    Step 1 ) ออกแบบ Class T-Shirt

    //วิเคราะห์การออกแบบ Class T-Shirt

    //คุณสมบัติ - size เป็น// String

    //- Priceเป็น Float


    //- Imageเป็น String
    class TShirt
    {
        public string size;
        public string color;
        public float price;
        public string image;

        public TShirt(string valueSize, string valueColor, float valuePrice, string valueImage)
        {
            size = valueSize;
            color = valueColor;
            price = valuePrice;
            image = valueImage;
        }

    }
//    Step 2 ) ออกแบบ Class Shopping Cart

//วิเคราะห์การออกแบบ Class Shopping Cart

//คุณสมบัติ

//- ListTShirt

//Class Shopping Cart

//Properties

//- ListTShirt

//ความสามารถ

//- AddTShirtToShoppingCart
//- TotalCost


class ShoppingCart
    {
        List<TShirt> listTShirt;

        public ShoppingCart()
        {
            listTShirt = new List<TShirt>();
        }

        public void AddTShirtToShoppingCart(TShirt tshirt)
        {
            listTShirt.Add(tshirt);
        }

        public float TotalCost()
        {
            float summary = 0.0f;

            foreach (TShirt shirt in listTShirt)
            {
                summary = summary + shirt.price;
            }

            return summary;
        }

    }
    //    Step 3 ) ออกแบบ Class Address

    //วิเคราะห์การออกแบบ Class Address

    //คุณสมบัติ - street - City - zipCode
    class Address
    {
        public string street;
        public string city;
        public string zipCode;

        public Address(string valueStreet, string valueCity, string valueZipCode)
        {
            street = valueStreet;
            city = valueCity;
            zipCode = valueZipCode;
        }

    }
    //    Step 4 ) ออกแบบ Class User

    //วิเคราะห์การออกแบบ Class User
    //คุณสมบัติ - Shopping cart
    //        -Name
    //        -Address
    //        -Email
    class User
    {
        public string name;
        public Address address;
        public string email;
        public ShoppingCart shoppingCart;

        public User(string valueName, string valueEmail, Address valueAddress, ShoppingCart valueShoppingCart)
        {
            name = valueName;
            email = valueEmail;
            address = valueAddress;
            shoppingCart = valueShoppingCart;
        }
    }
}
//โจทย์

//กําหนดให้ทํา app สําหรับ Support ร้านขายเสื้อผ้า โดยที่ระบบร้านที่สร้างขึ้นจะต้องเก็บข้อมูล
//ลูกค้าที่ได้มาทําการซื้อเสื้อโดยมีรายละเอียดดังต่อไปนี้

//1. T-shirt จะประกอบไปด้วยข้อมูลของ size เป็น String, color เป็น String ราคา เป็น float และ image
//เป็น String
//2. User คือข้อมูลของลูกค้าที่เข้ามาซื้อสินค้าที่ร้าน โดย ข้อมูลของ user จะประกอบไปด้วย name เป็น
//String, email เป็น String, และ ShoppingCart
//3. Address เป็นข้อมูลที่อยู่ในการจัดส่ง จะประกอบไปด้วยข้อมูลดังต่อไปนี้street เป็น String , city
//เป็น String และ zipCode เป็น String
//4. ShoppingCart จะเก็บข้อมูล orderTShirt เป็น array ของ Tshirt เก็บข้อมูล Total cost ของ T-shirt
//ที่ลูกค้าสั่งซื้อทั้งหมด และเก็บข้อมูล ของ Address เพื่อใช้ในการจัดส่ง

//นาย jame โทรเข้ามาที่ร้านค้าเพื่อซื้อเสื้อ 3 ตัว ประกอบไปด้วย size L สีแดง ราคา 500 บาท size M สีดํา
//ราคา 750 บาท และ size S ราคา 625 บาท นาย jame ได้ให้ข้อมูลกับร้านค้าไว้ดังต่อไปนี้ชื่อ jame
//watson, email jame@gmail.com ที่อยู่ 131 / 75, ถนนพุทธมณฑล จังหวัด นครปฐม zipCode
//10180 ดังนั้นจากข้อมูลดังกล่าวให้เขียนโปรแกรม กระบวนการซื้อสินค้าทั้งหมดของนายเจม และ แสดง
//Total cost ที่นายเจมจะต้องจ่ายทั้งหมด
//Step 5 ) สร้าง instance TShirt ออกมา 3 แบบ
//Step 6 ) สร้าง List เก็บ T shirt
//Step 7 ) สร้าง Instance Shopping Cart
//Step 8) เก็บ T-shirt เข้าใน Shopping cart
//Step 9) สร้าง Address
//Step 10 ) สร้าง instance jame เพื่อเก็บ Address และ ShoppingCart
//Steo 11 ) print ผลรวม เงินที่ต้องจ่ายออกมา
