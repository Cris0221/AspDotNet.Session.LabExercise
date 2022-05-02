using ToyData.Models;
using System.Collections.Generic;

namespace ToyWeb.Models
{
    public class ToyPage
    {
        ///<summary>
        /// Gets or sets Toy.
        ///</summary>
        public List<Toy> ToyList { get; set; }

        ///<summary>
        /// Gets or sets CurrentPageIndex.
        ///</summary>
        public int CurrentPageIndex { get; set; }

        ///<summary>
        /// Gets or sets PageCount.
        ///</summary>
        public int PageCount { get; set; }
    }
}
