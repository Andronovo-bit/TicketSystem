import 'antd/dist/antd.css';
import './App.css';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Home from './pages/home';
import Result from './pages/result';

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route index element={<Home />} ></Route>
        <Route path='seferler' element={<Result />} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
