import React, { FunctionComponent, useState, CSSProperties, useContext } from "react";
import { Input, Button } from "@nextui-org/react";
import { EyeFilledIcon } from "./EyeFilledIcon";
import { EyeSlashFilledIcon } from "./EyeSlashFilledIcon";
import { NavLink } from "react-router-dom";
import CustomNavBar from "../navBar/customNavBar";
import {userNameContext} from "../../context";
import { themeContext } from "../../context";

const style: CSSProperties = {
  display: "flex",
  justifyContent: "center",
  alignItems: "center",
  minHeight: "100vh",
};

const containerStyle: CSSProperties = {
  width: "100%",
  maxWidth: "400px",
  padding: "20px",
  borderRadius: "8px",
  boxShadow: "0 4px 6px rgba(0, 0, 0, 0.1)",
  textAlign: "center",
};

const formGroupStyle: CSSProperties = {
  marginBottom: "20px",
  color: 'white'
};

const buttonStyle: CSSProperties = {
  width: "100%",
};

const Login: FunctionComponent = () => {
  const [userName] = useState<string>("");
  const [valuepas, setValuepas] = useState("");
  const [isVisible, setIsVisible] = useState(false);
  const {theme} = useContext(themeContext)

  const toggleVisibility = () => setIsVisible(!isVisible);

  const validateEmail = (value) =>
    value.match(/^[A-Z0-9._%+-]+@[A-Z0-9.-]+.[A-Z]{2,4}$/i);

  const isInvalid = React.useMemo(() => {
    if (userName === "") return false;

    return validateEmail(userName) ? false : true;
  }, [userName]);

  const submitForm = (e) => {
    e.preventDefault();
    
  };

const {name, setName} = useContext(userNameContext)

  return (
    <>
          <CustomNavBar />   
      <div className={theme === 'light' ? 'light-mode' : 'dark-mode'} style={style}>
        <div style={containerStyle}>
           <p style={{ fontSize: "1.2rem", marginBottom: "20px", color: 'white' }}>
            Welcome to Our Platform
          </p>
          <form className={theme === 'light' ? 'light-mode' : 'dark-mode'} onSubmit={submitForm}>
            <div style={formGroupStyle}>
              <Input
                value={name}
                type="email"
                label="Email"
                placeholder="Enter your email"
                variant="bordered"
                isInvalid={isInvalid}
                color={isInvalid ? "danger" : "warning"}
                errorMessage={isInvalid && "Please enter a valid email"}
                onValueChange={setName}
              />
            </div>
            <div  style={formGroupStyle}>
              <Input
                value={valuepas}
                label="Password"
                variant="bordered"
                placeholder="Enter your password"
                isInvalid={isInvalid}
                color={isInvalid ? "danger" : "warning"}
                errorMessage={isInvalid && "Please enter a valid password"}
                onValueChange={setValuepas}
                endContent={
                  <button
                    className="focus:outline-none"
                    type="button"
                    onClick={toggleVisibility}
                  >
                    {isVisible ? (
                      <EyeSlashFilledIcon className="text-2xl text-default-400 pointer-events-none" />
                    ) : (
                      <EyeFilledIcon className="text-2xl text-default-400 pointer-events-none" />
                    )}
                  </button>
                }
                type={isVisible ? "text" : "password"}
              />
            </div>
            <Button
              type="submit"
              color="warning"
              variant="bordered"
              style={buttonStyle}
            >
              <NavLink to="/mainpage" style={{ color: "inherit", textDecoration: "none" }}>
                Login
              </NavLink>
            </Button>
          </form>
        </div>
      </div>
    </>
  );
};

export default Login;
