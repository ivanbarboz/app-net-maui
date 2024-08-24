
using System.Collections.Generic;


namespace EjemploNavegationPage
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            var products = new List<Product>
            {
                new Product { Name = "AUDIFONO GAMER CON MICROFONO", Price = 199.99m, ImageUrl = "https://i.blogs.es/3d1180/blackshark1/1366_2000.jpeg" },
                new Product { Name = "TECLADO GAMER RGB", Price = 159.99m, ImageUrl = "https://ae01.alicdn.com/kf/Sc4e781e4b64c4cf980d8073f8ad0355fn/Teclado-mec-nico-para-Gamer-Combo-de-teclado-y-rat-n-Led-RGB-para-Pc-con.jpg" },
                new Product { Name = "MOUSE GAMER RGB", Price = 109.99m, ImageUrl = "https://i5.walmartimages.com.mx/mg/gm/3pp/asr/3480ce01-a11e-4bd4-94a0-518b2a2646b1.c6c859bff8c935401064a5c81b79ebfe.jpeg?odnHeight=612&odnWidth=612&odnBg=FFFFFF" },
                new Product { Name = "CPU GAMER FULL RGB", Price = 1599.99m, ImageUrl = "https://tecnobits.net/wp-content/uploads/2020/11/pc-gama-extrema-2021-tecnobits-rtx-3090.jpg" },
                new Product { Name = "LAPTOP GAMER MSI", Price = 2899.99m, ImageUrl = "https://promart.vteximg.com.br/arquivos/ids/7344916-1000-1000/image-fa6f9cea17aa47a28ed6a6a1af3e5779.jpg?v=638254626690300000" },
                new Product { Name = "CPU + MONITOR GAMER", Price = 3599.99m, ImageUrl = "https://mipclista.com/6918-large_default/pc-gamer-ultra-hero-rgb-core-i9-12900f-12th.jpg" },
                new Product { Name = "LAPTOP TUF GAMER", Price = 2399.99m, ImageUrl = "https://www.lacuracao.pe/media/catalog/product/f/x/fx506hf-hn014w-1.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=700&width=700&canvas=700:700" },
                new Product { Name = "MICROFONO GAMER", Price = 599.99m, ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_965659-MLU71392725070_082023-O.webp" },
                new Product { Name = "MOUSE CLASICO", Price = 159.99m, ImageUrl = "https://dlcdnwebimgs.asus.com/gain/640C2121-97E6-4880-B56E-AAF63DAE53A6/w750/h470" },
            };

            ProductsCollectionView.ItemsSource = products;

        }
    }
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }


}