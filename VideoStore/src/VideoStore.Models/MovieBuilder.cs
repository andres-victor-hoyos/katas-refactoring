using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace VideoStore.Models
{
    public class MovieBuilder
    {
        private string title;
        Price price;
        public MovieBuilder()
        {
            this.title = string.Empty;
            this.price = new RegularPrice();
        }
        public MovieBuilder Title(string title)
        {
            this.title = title;
            return this;
        }

        public MovieBuilder Regular()
        {
            this.price = new RegularPrice();
            return this;
        }

        public MovieBuilder NewRelease()
        {
            this.price = new NewReleasePrice();
            return this;
        }

        public MovieBuilder Children()
        {
            this.price = new ChildrenPrice();
            return this;
        }

        public Movie Build()
        {
            return new Movie(this.title, this.price);
        }
    }
}