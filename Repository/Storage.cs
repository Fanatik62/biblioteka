namespace biblioteka.Repository
{
    public static class Storage
    {
        public static readonly BookStorage BookStorage = new();
        public static readonly ClientStorage ClientStorage = new();
        public static readonly LibrarianStorage LibrarianStorage = new();
        public static readonly OrderStorage OrderdStorage = new();
        public static readonly PaymentStorage PaymentStorage = new();
    }
}