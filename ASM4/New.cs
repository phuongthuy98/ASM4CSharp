using System;
using System.Collections.Generic;
using System.Text;
using ASM4;

namespace ASM4
{
    class New:INews
    {
        int Id;
        String Title;
        String PublishDate;
        String Author;
        String Content;
        float AverageRate;
        int[] RateList = new int[3];

        public New(int id, string title, string publishDate, string author, string content, float averageRate, int[] rateList)
        {
            Id = id;
            Title = title;
            PublishDate = publishDate;
            Author = author;
            Content = content;
            AverageRate = averageRate;
            RateList = rateList;
        }

        public New()
        {
        }

        public void Display()
        {
            Console.WriteLine("Title:" +this.Title +"PublishDate: "+this.PublishDate+" Author: "+this.Author+" Content: "+this.Content+" AverageRate :"+this.AverageRate);
        }
        public double Calculate()
        {
            foreach (var item in RateList)
            {
                this.AverageRate += item;
            }
            return this.AverageRate;
        }

        internal void add(New @new)
        {
            throw new NotImplementedException();
        }

        internal void add(int id, string title, string publishDate, string author, string content, float diemTBcong, object p)
        {
            throw new NotImplementedException();
        }
    }
}