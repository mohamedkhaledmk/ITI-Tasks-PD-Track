using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Entities
{
    public class Title : EntityBase
    {

		public Title() => this.State = EntitySate.Added;

        public string? TitleID { get; set; }
		public required string TitleName
		{
			get;
			set
			{
				if (field != value)
				{
					field = value;
					if (State != EntitySate.Added)
						this.State = EntitySate.Modified;
				}
			}
		}
		public string? Type { get; set; }
        public string? PubID { get; set; }
		public decimal? Price
		{
			get;
			set
			{
				if (field != value)
				{
					field = value;
					if (State != EntitySate.Added)
						this.State = EntitySate.Modified;
				}
			}
		}
		public decimal? Advance { get; set; }
		public int? Royalty { get; set; }
        public int? YTD_Sales { get; set; }
        public string? Notes { get; set; }
		public DateTime? Pubdate { get; set; }
    }
}
