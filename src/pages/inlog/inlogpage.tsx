import React, { FunctionComponent, useState, CSSProperties, useContext } from "react";
import { Input, Button } from "@nextui-org/react";
import { EyeFilledIcon } from "./EyeFilledIcon";
import { EyeSlashFilledIcon } from "./EyeSlashFilledIcon";
import {userNameContext} from "../../context";
import { themeContext } from "../../context";
import { LoginContext } from "../../context";
import { useNavigate } from "react-router-dom";

const style: CSSProperties = {
  display: "flex",
  justifyContent: "center",
  alignItems: "center",

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
  color: '#BA9238',
};

const buttonStyle: CSSProperties = {
  width: "100%",
  marginTop: "10px",
};

const headingStyle: CSSProperties = {
  fontSize: "2.2rem",
  marginTop: "100%",
  marginBottom: "20%",
  color: '#BA9238',
};

const Login: FunctionComponent = () => {
  const [userName] = useState<string>("");
  const [valuepas, setValuepas] = useState("");
  const [isVisible, setIsVisible] = useState(false);
  const {theme} = useContext(themeContext)
  const { setLogdin } = useContext(LoginContext);
  const navigate = useNavigate();

  const toggleVisibility = () => setIsVisible(!isVisible);

  const validateEmail = (value) =>
    value.match(/^[A-Z0-9._%+-]+@[A-Z0-9.-]+.[A-Z]{2,4}$/i);

  const isInvalid = React.useMemo(() => {
    if (userName === "") return false;

    return validateEmail(userName) ? false : true;
  }, [userName]);

 const submitForm = (e) => {
    e.preventDefault();
    setLogdin(true);
    navigate('/mainpage');
  };

const {name, setName} = useContext(userNameContext)

  return (
    <div className={theme === 'light' ? 'light-mode' : 'dark-mode'}>
      <div style={style}>
        <div style={containerStyle}>
           <p style={headingStyle}>
            Welcome to Meme-It
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
            > Login         
            </Button>
          </form>
        </div>
      </div>
    </div>
  );
};

export default Login;
