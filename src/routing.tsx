import {FunctionComponent} from 'react'
import {Outlet, Route, Routes} from 'react-router-dom'
import Login from './pages/inlog/inlogpage';
import MainPage from './pages/memePages/mainPage';
import Privacy from './pages/memePages/privacy';
import UserNameContext from './context';



const Routing: FunctionComponent = () => {
  return (
      <UserNameContext>
    <Routes>
      <Route path="/" element={<Login />} />
      <Route path="/mainpage" element={<MainPage />} />
      <Route path="/Privacy" element={<Privacy />} />
      <Route path="*" element={<Outlet />} />
    </Routes>
    </UserNameContext>
  )
}

export default Routing
