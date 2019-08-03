namespace abstractClass_taxPayer.Entities
{
    internal class Company : TaxPayer
    {
        public int EmployeeNr { get; set; }

        public Company(string name, double anualIncome, int employeeNr)
            : base(name, anualIncome)
        {
            EmployeeNr = employeeNr;
        }

        public override double Tax()
        {
            if (EmployeeNr <= 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}
