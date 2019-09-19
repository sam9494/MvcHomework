using System;
using System.Collections.Generic;
using MvcHomework.Models.ViewModel;

namespace MvcHomework.Models
{
    public static class DataGenerator
    {
        public static List<RandomListsViewModel> GenetareDataList()
        {
            int min = 300;
            int max = 30000;
            var typeList = new List<string>()
            {
                "支出",
                "收入"
            };
            DateTime date = DateTime.Today;
            Random random = new Random();
            List<RandomListsViewModel> listsViewModel = new List<RandomListsViewModel>();
            for (int i = 1; i <= 50; i++)
            {
                listsViewModel.Add(new RandomListsViewModel(i, typeList[random.Next(0, typeList.Count)], date, random.Next(min, max)));
            }
            return listsViewModel;
        }
    }
}