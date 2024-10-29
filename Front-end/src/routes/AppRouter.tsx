import { Route, Routes } from 'react-router-dom';
import Home from '@/screens/home/Home';
import Calculator from '@/screens/calculator/Calculator';
import Results from '@/screens/results/Results';
import Ranking from '@/screens/ranking/Ranking';
import About from '@/screens/about/About';

const AppRouter = () => {
    return (
        <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/calculadora" element={<Calculator />} />
            <Route path="/resultados" element={<Results />} />
            <Route path="/ranking" element={<Ranking />} />
            <Route path="/sobre" element={<About />} />
        </Routes>
    );
};

export default AppRouter;