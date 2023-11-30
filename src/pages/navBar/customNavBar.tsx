import { FunctionComponent, useState, CSSProperties, useContext } from "react";
import { Navbar, NavbarBrand, NavbarMenuToggle, NavbarMenuItem, NavbarMenu, NavbarContent, NavbarItem, Link, Avatar} from "@nextui-org/react";
import { AcmeLogo } from "./AcmeLogo.js";
import { NavLink } from "react-router-dom";
import logo from '../../assets/icons8-authentication-48.png';
import { userNameContext } from "../../context";

const style: CSSProperties = {
  backgroundColor: 'black',
};

const CustomNavBar: FunctionComponent = () => {
    const [isMenuOpen, setIsMenuOpen] = useState(false);
    const { name } = useContext(userNameContext);
    
  const menuItems = [
      <NavLink to="/Privacy">Privacy</NavLink>,
      <NavLink to="/">Logout</NavLink>,
  ];

  return (
    
    <Navbar style={style}
      isBordered
      isMenuOpen={isMenuOpen}
      onMenuOpenChange={setIsMenuOpen}
    >
      <NavbarContent className="sm:hidden" justify="start">
        <NavbarMenuToggle aria-label={isMenuOpen ? "Close menu" : "Open menu"} />
      </NavbarContent>

      <NavbarContent className="sm:hidden pr-3" justify="center">
        <NavbarBrand>
          <AcmeLogo />
          <p style={{fontSize: '30px'}} className="font-bold text-inherit">Meme-It</p>      
        </NavbarBrand>
      </NavbarContent>

      <NavbarContent className="hidden sm:flex gap-4" justify="center">
        <NavbarBrand>
          <AcmeLogo />
          <p style={{fontSize: '30px'}} className="font-bold text-inherit">Meme-It</p>
        </NavbarBrand>
      </NavbarContent>

      <NavbarContent justify="end">
        <NavbarItem className="hidden lg:flex text-black">
          <Link href="MainPage">Meme page</Link>
        </NavbarItem>
      </NavbarContent>

       <NavbarContent justify="end">
        <NavbarItem className="hidden lg:flex text-black">
          <Link href="Privacy">Privacy</Link>
        </NavbarItem>
      </NavbarContent>
      
      <NavbarContent justify="end">
        <NavbarItem className="hidden lg:flex text-black">
          <Link href="/">Logout</Link>
        </NavbarItem>
      </NavbarContent>

      <NavbarMenu>
        {menuItems.map((item, index) => (
          <NavbarMenuItem key={`${item}-${index}`}>
            <Link
              className="w-full"
              color="foreground"
              href="#"
              size="lg"
            >
              {item}
            </Link>
          </NavbarMenuItem>
        ))}
      </NavbarMenu>        
            <Avatar
              isBordered
              as="button"
              className="transition-transform"
              color="warning"
              name="Jason Hughes"
              size="sm"
              src={logo}
            />       
      <p style={{color: 'black'}}>{name}</p>
    </Navbar>
  );
}

export default CustomNavBar;
