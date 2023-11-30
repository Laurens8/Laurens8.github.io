import { FunctionComponent, useContext, ReactNode, useState } from "react";
import { userNameContext } from "./context";
import CustomNavBar from "./pages/navBar/customNavBar";


interface AppProps {
   children: ReactNode;
}

const App: FunctionComponent<AppProps> = ({children}) => {
    const { name } = useContext(userNameContext);
    const [NameValue, setName] = useState('');
    setName(name);
  
  return (
    <CustomNavBar name={NameValue}>
        {children}
    </CustomNavBar>
  );
}

export default App;