using System;
using System.Collections;
using System.Collections.Generic;

namespace T1809E_CSharp
{
    public class Product
    {
        public int id;
        public string name;
        public float price;
        public int qty;
        public string image;
        public string desc;
        public List<string> gallery=new List<string>();

        public Product()
        {
        }

        public Product(int id, string name, float price, int qty, string image, string desc)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            
        }

        public void getInfo()
        {
            Console.WriteLine("Id: "+id);
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Price: "+price);
            Console.WriteLine("Qty: "+qty);
            Console.WriteLine("Image: "+image);
            Console.WriteLine("Desc: "+desc);
            Console.WriteLine("Gallery: ");
            foreach (var d in gallery)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();
            
        }

        public void Thongbao()
        {
            if (qty>0)
            {
                Console.WriteLine("Con hang voi so luong la: " + qty);
            }
            else
            {
                Console.WriteLine("Hang da het: "+qty);
            }
        }

        public void Them()
        {
            string n;
            Console.WriteLine("Nhap anh ");
            n = Console.ReadLine();
            gallery.Add(n);
            Console.WriteLine();
            if (gallery.Count>10)
            {
                Console.WriteLine("Khong duoc them nua vui long xoa anh ");
            }

        }

        public void Xoa()
        {
            string i;
            Console.WriteLine("Nhap anh muon xoa");
            i = Console.ReadLine();
            gallery.Remove(i);
            Console.WriteLine();
        }
    }
}