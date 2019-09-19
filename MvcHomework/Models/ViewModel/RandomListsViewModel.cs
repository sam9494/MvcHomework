using System;

namespace MvcHomework.Models.ViewModel
{
    public class RandomListsViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime DateTime { get; set; }
        public double Money { get; set; }

        public RandomListsViewModel(int id, string type, DateTime date, int money)
        {
            Id = id;
            Type = type;
            DateTime = date;
            Money = money;
        }
    }
}