using EcoImpacto.Application.UseCases.Calculator;
using EcoImpacto.Communication.Requests;
using EcoImpacto.Communication.Responses;
using Xunit;

namespace EcoImpacto.Tests
{
    public class RegisterCalculatorDataUseCaseTests
    {
        [Fact]
        public void Execute_DeveRetornarEmissaoCorreta()
        {
            
            var useCase = new RegisterCalculatorDataUseCase();
            var request = new RequestCalculatorResultJson
            {
                ConsumoEnergiaKWh = 100,
                ConsumoGasM3 = 50,
                ConsumoCombustivelLitros = 20,
                TransportePublicoKm = 10,
                PraticasReciclagem = 5,
            };

            
            var response = useCase.Execute(request);

            
            double expectedEmission = (100 * 0.223) + (50 * 2.1) + (20 * 2.3) + (10 * 0.1);
            Assert.Equal(expectedEmission, response.result, precision: 2); 
        }

        [Fact]
        public void Execute_DeveRetornarSetorComMaiorDiferencaRelativa_GasComConsumoElevado()
        {
            
            var useCase = new RegisterCalculatorDataUseCase();
            var request = new RequestCalculatorResultJson
            {
                ConsumoEnergiaKWh = 150,
                ConsumoGasM3 = 1000000000000,  
                ConsumoCombustivelLitros = 100000,
                TransportePublicoKm = 0,
                PraticasReciclagem = 4,
            };

            
            var response = useCase.Execute(request);

            
            Assert.Equal("Gás", response.worstSector); 
        }

        [Fact]
        public void Execute_DeveRetornarSetorComMaiorDiferencaRelativa_Reciclagem()
        {
            
            var useCase = new RegisterCalculatorDataUseCase();
            var request = new RequestCalculatorResultJson
            {
                ConsumoEnergiaKWh = 150,
                ConsumoGasM3 = 80,
                ConsumoCombustivelLitros = 40,
                TransportePublicoKm = 10,
                PraticasReciclagem = 0, 
            };

            
            var response = useCase.Execute(request);

            
            Assert.Equal("Reciclagem", response.worstSector); 
        }

        [Fact]
        public void Execute_DeveRetornarSetorComMaiorDiferencaRelativa_EnergiaComConsumoElevado()
        {
            
            var useCase = new RegisterCalculatorDataUseCase();
            var request = new RequestCalculatorResultJson
            {
                ConsumoEnergiaKWh = 100000000,  
                ConsumoGasM3 = 100,
                ConsumoCombustivelLitros = 100,
                TransportePublicoKm = 0,
                PraticasReciclagem = 4,
            };

            
            var response = useCase.Execute(request);

            
            Assert.Equal("Energia", response.worstSector); 
        }
    }
}
