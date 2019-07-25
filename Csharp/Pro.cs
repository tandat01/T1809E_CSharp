using System;

namespace T1809E_CSharp
{
    public class Pro
    {
        public static void Main(String[] args)
        {
            Product d=new Product();
            d.id = 1;
            d.name = "Nguyen van A";
            d.price = 12000;
            d.qty = 7;
            d.image = "dasad.jpg";
            d.desc = "Ádsadsd";
            d.gallery.Add("iasd.jpg");
            d.gallery.Add("iinc.jpg");
            
            d.getInfo();
            d.Thongbao();
            d.Them();
            d.getInfo();
            d.Xoa();
            d.getInfo();
        }
    }
}