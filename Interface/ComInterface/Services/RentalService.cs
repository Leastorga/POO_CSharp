using ComInterface.Entities;


namespace ComInterface.Services
{
    class RentalService
    {

        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService _taxService;
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        // Método para processar minha fatura e adicionar o valor do imposto a fatura. Então primeiro eu vejo quanto tempo o veículo foi alugado, depois baseado nisso decido a fatura de acordo com o valor por hora ou diário. Após a fatura estar definida, chamo o método de imposto dentro do serviço de imposto do brasil para adicionar o valor do imposto baseado em seu total. 
        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            
            double tax = _taxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);

        }
    }
}