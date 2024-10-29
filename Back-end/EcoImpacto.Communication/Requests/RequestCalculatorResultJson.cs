
namespace EcoImpacto.Communication.Requests;

public class RequestCalculatorResultJson
{
    public double ConsumoEnergiaKWh { get; set; }  // Consumo de energia elétrica em kWh
    public double ConsumoGasM3 { get; set; }       // Consumo de gás natural em m³
    public double ConsumoCombustivelLitros { get; set; }  // Litros de combustível usado por mês
    public double ConsumoVeiculoKmPorLitro { get; set; }  // Km/l que o veículo faz
    public double TransportePublicoKm { get; set; }  // Km que o usuário anda de transporte público por mês
    public int PraticasReciclagem { get; set; }      // Número de práticas de reciclagem
    public string NomeUsuario { get; set; } = string.Empty;
    public string EmailUsuario { get; set; } = string.Empty;
}

