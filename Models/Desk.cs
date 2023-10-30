namespace MegaDesk_ASP.NET_Core_Razor_Web_Application.Models
{
    public class Desk
    {
        public int Id { get; set;}
        public string? name { get; set;}
        public int ? drawers { get; set;}
        public string? material { get; set;}
        public float price { get; set;} 
        public int? height { get; set;} 

        public int? width { get; set;}  
        public int? surface { get; set;}

    }
}
