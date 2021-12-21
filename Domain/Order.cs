namespace biblioteka.Domain
{

    public class Order
    {

        public int IDorder { get; set; }

        public string OrderNumber { get; set; }

        public string BookName { get; set; }

        public int OrderSum { get; set; }

        public DateTime DateofIssue { get; set; }

        public int OrderDiscount { get; set; }

        public int IDlibrarian { get; set; }

        public int IDclient { get; set; }

    }
}