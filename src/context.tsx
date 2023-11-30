import { createContext, useState, FunctionComponent, ReactNode, useEffect } from "react";

interface userNameContextProps {
  children?: ReactNode;
}

const LOCAL_STORAGE_THEME_KEY = "appTheme";
const LOCAL_STORAGE_COLOR_KEY = "appColor";
const LOCAL_STORAGE_LAYOUT_KEY = "appLayout";

export const userNameContext = createContext({
  name: "",
  setName: (name: string) => {},
});

export const memeContext = createContext({
  meme: "",
  setMeme: (meme: string) => {},
});

export const themeContext = createContext({
  theme: "",
  setTheme: (theme: string) => {},
});

export const colorContext = createContext({
  color: "",
  setColor: (color: string) => {},
});

export const layoutContext = createContext({
  layout: "",
  setLayout: (layout: string) => {},
});

export const slideContext = createContext({
  slide: 0,
  setSlide: (slide: number) => {},
});

const UserNameContext: FunctionComponent<userNameContextProps> = ({ children }) => {
  const [NameValue, setName] = useState("");
  const [MemeValue, setMeme] = useState("");
  const [SlideValue, setSlide] = useState(600);
  const [ThemeValue, setThemeState] = useState<string>(
    localStorage.getItem(LOCAL_STORAGE_THEME_KEY) ?? "dark"
  );
  const [ColorValue, setColorState] = useState<string>(
    localStorage.getItem(LOCAL_STORAGE_COLOR_KEY) ?? "warning"
  );
  const [LayoutValue, setLayoutState] = useState<string>(
    localStorage.getItem(LOCAL_STORAGE_LAYOUT_KEY) ?? "list"
  );

  const setTheme = (theme: string) => {
    setThemeState(theme);
    localStorage.setItem(LOCAL_STORAGE_THEME_KEY, theme);
  };

  const setColor = (color: string) => {
    setColorState(color);
    localStorage.setItem(LOCAL_STORAGE_COLOR_KEY, color);
  };

  const setLayout = (layout: string) => {
    setLayoutState(layout);
    localStorage.setItem(LOCAL_STORAGE_LAYOUT_KEY, layout);
  };

  useEffect(() => {
    const storedTheme = localStorage.getItem(LOCAL_STORAGE_THEME_KEY);
    const storedColor = localStorage.getItem(LOCAL_STORAGE_COLOR_KEY);
    const storedLayout = localStorage.getItem(LOCAL_STORAGE_LAYOUT_KEY);

    if (storedTheme) setThemeState(storedTheme);
    if (storedColor) setColorState(storedColor);
    if (storedLayout) setLayoutState(storedLayout);
  }, []);

  return (
    <userNameContext.Provider value={{ name: NameValue, setName }}>
      <memeContext.Provider value={{ meme: MemeValue, setMeme }}>
        <themeContext.Provider value={{ theme: ThemeValue, setTheme }}>
          <colorContext.Provider value={{ color: ColorValue, setColor }}>
            <layoutContext.Provider value={{ layout: LayoutValue, setLayout }}>
              <slideContext.Provider value={{ slide: SlideValue, setSlide }}>
                {children}
              </slideContext.Provider>
            </layoutContext.Provider>
          </colorContext.Provider>
        </themeContext.Provider>
      </memeContext.Provider>
    </userNameContext.Provider>
  );
};

export default UserNameContext;
