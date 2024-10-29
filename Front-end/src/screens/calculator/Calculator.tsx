import { useState } from 'react';

const Calculator = () => {
    const [electricity, setElectricity] = useState('');
    const [gas, setGas] = useState('');
    const [fuel, setFuel] = useState('');
    const [fuelEfficiency, setFuelEfficiency] = useState('');
    const [publicTransport, setPublicTransport] = useState('');
    const [recycling, setRecycling] = useState('');

    const handleSubmitCalculator = (event: React.FormEvent<HTMLFormElement>) => {
        event.preventDefault();
        console.log('Formulário enviado');
        console.log({
            electricity,
            gas,
            fuel,
            fuelEfficiency,
            publicTransport,
            recycling
        });
    };

    return (
        <div>
            <h1>Calculadora</h1>
            
            <form className="flex flex-col items-center" onSubmit={handleSubmitCalculator}>
                <p className="mt-2">Insira seu consumo MENSAL de energia elétrica em kWh. Veja onde encontrar essa informação na sua conta de energia elétrica</p>
                <input 
                    type="number" 
                    placeholder="0" 
                    value={electricity} 
                    onChange={(e) => setElectricity(e.target.value)} 
                />

                <p className="mt-2">Insira seu consumo MENSAL de gás em m³. Veja onde encontrar essa informação na sua conta de gás.</p>
                <input 
                    type="number" 
                    placeholder="0" 
                    value={gas} 
                    onChange={(e) => setGas(e.target.value)} 
                />

                <p className="mt-2">Insira quantos litros de combustível você usa no mês com seu carro/moto pessoal.</p>
                <input 
                    type="number" 
                    placeholder="0" 
                    value={fuel} 
                    onChange={(e) => setFuel(e.target.value)} 
                />

                <p className="mt-2">Insira quantos km/l seu carro/moto costuma fazer em média.</p>
                <input 
                    type="number" 
                    placeholder="0" 
                    value={fuelEfficiency} 
                    onChange={(e) => setFuelEfficiency(e.target.value)} 
                />

                <p className="mt-2">Insira quantos quilômetros você costuma andar de transporte público no mês.</p>
                <input 
                    type="number" 
                    placeholder="0" 
                    value={publicTransport} 
                    onChange={(e) => setPublicTransport(e.target.value)} 
                />

                <p className="mt-2">Insira quantas vezes por mês você costuma reciclar.</p>
                <input 
                    type="number" 
                    placeholder="0" 
                    value={recycling} 
                    onChange={(e) => setRecycling(e.target.value)} 
                />
                
                <button className="mt-2" type="submit">
                    Calcular
                </button>
            </form>
        </div>
    );
};

export default Calculator;