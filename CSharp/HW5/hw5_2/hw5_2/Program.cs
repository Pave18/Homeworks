using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5_2
{
    enum ArticleType { Small = -1, Medium = 0, Large }
    enum ClientType { Ordinary = 0, VIP = 1 }
    enum PayType { Cashless = 0, Cash = 1 }

    class Program
    {

        static void Main(string[] args)
        {
            Article A = new Article(101, "Prod_A", 1025.52, ArticleType.Large);
            Client C = new Client(1901, "Ivan Ivanovich Ivanov", "Belarus ul.Oktiabr'skaia 88-14", "+37529-___-__-__",0,0, ClientType.VIP);
            RequestItem RI = new RequestItem(A, 20);
            Request R = new Request(01, C, DateTime.Now,PayType.Cashless);

            A.ShowArticle();
            Console.WriteLine();

            C.ShowClient();
            Console.WriteLine();

            RI.ShowRequestItem();
            Console.WriteLine();

            R.ShowRequest();
            Console.WriteLine();
        }
    }

    struct Article
    {
        public int PoductCode;
        public string ProductName;
        public double ProductPrice;
        ArticleType aType;

        public double ArticlePrice { get { return ProductPrice; } }

        public Article(int code = 0, string name = null, double price = 0.0, ArticleType articleType=ArticleType.Medium)
        {
            this.PoductCode = code;
            this.ProductName = name;
            this.ProductPrice = price;
            this.aType = articleType;
        }

        public void ShowArticle()
        {
            Console.WriteLine($" Article_Code: {this.PoductCode}\n\t Name: { this.ProductName}\n\t Price: { this.ProductPrice}\n\t Type: {aType}");
        }
    }

    struct Client
    {
        public int ClientCode;
        public string ClientName;
        public string ClientAddress;
        public string ClientPhone;
        public int NumOrders;
        public double SumOrders;
        ClientType cType;

        public Client(int code = 0, string name = null, string address = null, string phone = null, int num = 0, double sum = 0.0, ClientType clientType= ClientType.Ordinary)
        {
            this.ClientCode = code;
            this.ClientName = name;
            this.ClientAddress = address;
            this.ClientPhone = phone;
            this.NumOrders = num;
            this.SumOrders = sum;
            this.cType = clientType;
        }

        public void ShowClient()
        {
            Console.WriteLine($" Client_Code: {this.ClientCode}\n\t Name: {this.ClientName}\n\t Address: {this.ClientAddress}\n\t Phone: {this.ClientPhone}\n\t Num: {this.NumOrders}\n\t Sum: {this.SumOrders}\n\t Type: {cType}");
        }
    }

    struct RequestItem
    {
        public Article Product;
        public int NumProduct;

        public int RequestItemNum { get { return NumProduct; } }
        public Article RequestItemProduct { get { return Product; } }

        public RequestItem(Article product, int num)
        {
            this.Product = product;
            this.NumProduct = num;
        }

        public void ShowRequestItem()
        {
            Console.WriteLine($" RequestItem_Num: {NumProduct} \n ___Info product___");
            Product.ShowArticle();
        }
    }

    struct Request
    {
        public int RequestCode;
        public Client RequestClient;
        public DateTime RequestDate;
        public List<RequestItem> RequestOrderedProducts;
        PayType pType;
        public double SumRequest()
        {
            double sum = 0;
            foreach (RequestItem ri in RequestOrderedProducts)
                sum += ri.Product.ProductPrice * ri.NumProduct;
            return sum;
        }

        public void ShowSumRequest() { Console.WriteLine(" \t SumRequest: " + SumRequest()); }

        public Request(int code, Client client, DateTime DateTime_, PayType payType)
        {
            this.RequestCode = code;
            this.RequestClient = client;
            this.RequestDate = DateTime_;
            this.RequestOrderedProducts = new List<RequestItem>();
            this.pType = payType;
        }

        public void ShowRequest()
        {
            Console.Write($" Request_Code: {RequestCode}\n\t ");
            RequestClient.ShowClient();
            Console.WriteLine($"\t Data: {RequestDate}");
            foreach (RequestItem ri in RequestOrderedProducts)
                ri.ShowRequestItem();
            ShowSumRequest(); 
        }

    }
}
