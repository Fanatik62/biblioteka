namespace biblioteka.Domain
{

    public class Payment
    {

        public int IDpayment { get; set; }

        public int IDorder { get; set; }

        public int OrderSum { get; set; }

        public int OrderDiscount { get; set; }

    }
}