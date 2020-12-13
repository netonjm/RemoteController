namespace RemoteController
{
    public enum KeyEvent
    {
        Down,
        Up
    }

    //
    // Resumen:
    //     Especifica los modificadores y códigos de tecla.
    public enum Keys
    {
        //
        // Resumen:
        //     La máscara de bits para extraer modificadores de un valor de clave.
        Modifiers = -65536,
        //
        // Resumen:
        //     Ninguna tecla presionada.
        None = 0,
        //
        // Resumen:
        //     El botón primario del mouse.
        LButton = 1,
        //
        // Resumen:
        //     El botón secundario del mouse.
        RButton = 2,
        //
        // Resumen:
        //     Tecla Cancelar.
        Cancel = 3,
        //
        // Resumen:
        //     El botón central del mouse (ratón de tres botones).
        MButton = 4,
        //
        // Resumen:
        //     El primer botón x del mouse (mouse de cinco botones).
        XButton1 = 5,
        //
        // Resumen:
        //     El segundo botón x del mouse (mouse de cinco botones).
        XButton2 = 6,
        //
        // Resumen:
        //     Tecla RETROCESO.
        Back = 8,
        //
        // Resumen:
        //     Tecla TAB.
        Tab = 9,
        //
        // Resumen:
        //     Tecla avance de línea.
        LineFeed = 10,
        //
        // Resumen:
        //     Tecla BORRAR.
        Clear = 12,
        //
        // Resumen:
        //     La tecla ENTRAR.
        Return = 13,
        //
        // Resumen:
        //     Tecla ENTRAR.
        Enter = 13,
        //
        // Resumen:
        //     La tecla MAYÚS.
        ShiftKey = 16,
        //
        // Resumen:
        //     La tecla CTRL.
        ControlKey = 17,
        //
        // Resumen:
        //     La tecla ALT.
        Menu = 18,
        //
        // Resumen:
        //     Tecla PAUSA.
        Pause = 19,
        //
        // Resumen:
        //     La tecla BLOQ MAYÚS.
        Capital = 20,
        //
        // Resumen:
        //     La tecla BLOQ MAYÚS.
        CapsLock = 20,
        //
        // Resumen:
        //     Tecla de modo Kana de IME.
        KanaMode = 21,
        //
        // Resumen:
        //     La clave de modo Hanguel de IME. (se mantiene por compatibilidad; use HangulMode)
        HanguelMode = 21,
        //
        // Resumen:
        //     Tecla de modo Hangul de IME.
        HangulMode = 21,
        //
        // Resumen:
        //     Tecla de modo Junja de IME.
        JunjaMode = 23,
        //
        // Resumen:
        //     La clave de modo final de IME.
        FinalMode = 24,
        //
        // Resumen:
        //     Tecla de modo Hanja de IME.
        HanjaMode = 25,
        //
        // Resumen:
        //     Tecla de modo Kanji de IME.
        KanjiMode = 25,
        //
        // Resumen:
        //     Tecla ESC.
        Escape = 27,
        //
        // Resumen:
        //     La clave de conversión IME.
        IMEConvert = 28,
        //
        // Resumen:
        //     La tecla no convertir IME.
        IMENonconvert = 29,
        //
        // Resumen:
        //     El IME acepte clave, reemplaza System.Windows.Forms.Keys.IMEAceept.
        IMEAccept = 30,
        //
        // Resumen:
        //     Tecla Aceptar de IME. Obsoleto, utilice System.Windows.Forms.Keys.IMEAccept en
        //     su lugar.
        IMEAceept = 30,
        //
        // Resumen:
        //     La clave de cambio del modo IME.
        IMEModeChange = 31,
        //
        // Resumen:
        //     Tecla BARRA ESPACIADORA.
        Space = 32,
        //
        // Resumen:
        //     Tecla RE PÁG.
        Prior = 33,
        //
        // Resumen:
        //     Tecla RE PÁG.
        PageUp = 33,
        //
        // Resumen:
        //     Tecla AV PÁG.
        Next = 34,
        //
        // Resumen:
        //     Tecla AV PÁG.
        PageDown = 34,
        //
        // Resumen:
        //     Tecla FIN.
        End = 35,
        //
        // Resumen:
        //     Tecla INICIO.
        Home = 36,
        //
        // Resumen:
        //     Tecla FLECHA IZQUIERDA.
        Left = 37,
        //
        // Resumen:
        //     Tecla FLECHA ARRIBA.
        Up = 38,
        //
        // Resumen:
        //     Tecla FLECHA DERECHA.
        Right = 39,
        //
        // Resumen:
        //     Tecla FLECHA ABAJO.
        Down = 40,
        //
        // Resumen:
        //     Tecla SELECCIONAR.
        Select = 41,
        //
        // Resumen:
        //     Tecla IMPRIMIR.
        Print = 42,
        //
        // Resumen:
        //     Tecla EJECUTAR.
        Execute = 43,
        //
        // Resumen:
        //     Tecla IMPRIMIR PANTALLA.
        Snapshot = 44,
        //
        // Resumen:
        //     Tecla IMPRIMIR PANTALLA.
        PrintScreen = 44,
        //
        // Resumen:
        //     La clave de complementos.
        Insert = 45,
        //
        // Resumen:
        //     La tecla SUPR.
        Delete = 46,
        //
        // Resumen:
        //     Tecla AYUDA.
        Help = 47,
        //
        // Resumen:
        //     Tecla 0.
        D0 = 48,
        //
        // Resumen:
        //     Tecla 1.
        D1 = 49,
        //
        // Resumen:
        //     Tecla 2.
        D2 = 50,
        //
        // Resumen:
        //     Tecla 3.
        D3 = 51,
        //
        // Resumen:
        //     Tecla 4.
        D4 = 52,
        //
        // Resumen:
        //     Tecla 5.
        D5 = 53,
        //
        // Resumen:
        //     Tecla 6.
        D6 = 54,
        //
        // Resumen:
        //     Tecla 7.
        D7 = 55,
        //
        // Resumen:
        //     Tecla 8.
        D8 = 56,
        //
        // Resumen:
        //     Tecla 9.
        D9 = 57,
        //
        // Resumen:
        //     Tecla A.
        A = 65,
        //
        // Resumen:
        //     Tecla B.
        B = 66,
        //
        // Resumen:
        //     Tecla C.
        C = 67,
        //
        // Resumen:
        //     Tecla D.
        D = 68,
        //
        // Resumen:
        //     Tecla E.
        E = 69,
        //
        // Resumen:
        //     Tecla F.
        F = 70,
        //
        // Resumen:
        //     Tecla G.
        G = 71,
        //
        // Resumen:
        //     Tecla H.
        H = 72,
        //
        // Resumen:
        //     Tecla I.
        I = 73,
        //
        // Resumen:
        //     Tecla J.
        J = 74,
        //
        // Resumen:
        //     Tecla K.
        K = 75,
        //
        // Resumen:
        //     Tecla L.
        L = 76,
        //
        // Resumen:
        //     Tecla M.
        M = 77,
        //
        // Resumen:
        //     Tecla N.
        N = 78,
        //
        // Resumen:
        //     Tecla O.
        O = 79,
        //
        // Resumen:
        //     Tecla P.
        P = 80,
        //
        // Resumen:
        //     Tecla Q.
        Q = 81,
        //
        // Resumen:
        //     Tecla R.
        R = 82,
        //
        // Resumen:
        //     Tecla S.
        S = 83,
        //
        // Resumen:
        //     Tecla T.
        T = 84,
        //
        // Resumen:
        //     Tecla U.
        U = 85,
        //
        // Resumen:
        //     Tecla V.
        V = 86,
        //
        // Resumen:
        //     Tecla W.
        W = 87,
        //
        // Resumen:
        //     Tecla X.
        X = 88,
        //
        // Resumen:
        //     Tecla Y.
        Y = 89,
        //
        // Resumen:
        //     Tecla Z.
        Z = 90,
        //
        // Resumen:
        //     Tecla del logotipo de Windows izquierda (Microsoft Natural Keyboard).
        LWin = 91,
        //
        // Resumen:
        //     Tecla del logotipo de Windows derecha (Microsoft Natural Keyboard).
        RWin = 92,
        //
        // Resumen:
        //     La clave de aplicación (Microsoft Natural Keyboard).
        Apps = 93,
        //
        // Resumen:
        //     La tecla de suspensión del equipo.
        Sleep = 95,
        //
        // Resumen:
        //     Tecla 0 del teclado numérico.
        NumPad0 = 96,
        //
        // Resumen:
        //     Tecla 1 del teclado numérico.
        NumPad1 = 97,
        //
        // Resumen:
        //     Tecla 2 del teclado numérico.
        NumPad2 = 98,
        //
        // Resumen:
        //     Tecla 3 del teclado numérico.
        NumPad3 = 99,
        //
        // Resumen:
        //     Tecla 4 del teclado numérico.
        NumPad4 = 100,
        //
        // Resumen:
        //     Tecla 5 del teclado numérico.
        NumPad5 = 101,
        //
        // Resumen:
        //     Tecla 6 del teclado numérico.
        NumPad6 = 102,
        //
        // Resumen:
        //     Tecla 7 del teclado numérico.
        NumPad7 = 103,
        //
        // Resumen:
        //     Tecla 8 del teclado numérico.
        NumPad8 = 104,
        //
        // Resumen:
        //     Tecla 9 del teclado numérico.
        NumPad9 = 105,
        //
        // Resumen:
        //     Tecla multiplicar.
        Multiply = 106,
        //
        // Resumen:
        //     Tecla agregar.
        Add = 107,
        //
        // Resumen:
        //     Tecla separador.
        Separator = 108,
        //
        // Resumen:
        //     Tecla restar.
        Subtract = 109,
        //
        // Resumen:
        //     Tecla decimal.
        Decimal = 110,
        //
        // Resumen:
        //     Tecla dividir.
        Divide = 111,
        //
        // Resumen:
        //     Tecla F1.
        F1 = 112,
        //
        // Resumen:
        //     Tecla F2.
        F2 = 113,
        //
        // Resumen:
        //     Tecla F3.
        F3 = 114,
        //
        // Resumen:
        //     Tecla F4.
        F4 = 115,
        //
        // Resumen:
        //     Tecla F5.
        F5 = 116,
        //
        // Resumen:
        //     Tecla F6.
        F6 = 117,
        //
        // Resumen:
        //     Tecla F7.
        F7 = 118,
        //
        // Resumen:
        //     Tecla F8.
        F8 = 119,
        //
        // Resumen:
        //     Tecla F9.
        F9 = 120,
        //
        // Resumen:
        //     Tecla F10.
        F10 = 121,
        //
        // Resumen:
        //     Tecla F11.
        F11 = 122,
        //
        // Resumen:
        //     Tecla F12.
        F12 = 123,
        //
        // Resumen:
        //     Tecla F13.
        F13 = 124,
        //
        // Resumen:
        //     Tecla F14.
        F14 = 125,
        //
        // Resumen:
        //     Tecla F15.
        F15 = 126,
        //
        // Resumen:
        //     Tecla F16.
        F16 = 127,
        //
        // Resumen:
        //     Tecla F17.
        F17 = 128,
        //
        // Resumen:
        //     Tecla F18.
        F18 = 129,
        //
        // Resumen:
        //     Tecla F19.
        F19 = 130,
        //
        // Resumen:
        //     Tecla F20.
        F20 = 131,
        //
        // Resumen:
        //     Tecla F21.
        F21 = 132,
        //
        // Resumen:
        //     Tecla F22.
        F22 = 133,
        //
        // Resumen:
        //     Tecla F23.
        F23 = 134,
        //
        // Resumen:
        //     Tecla F24.
        F24 = 135,
        //
        // Resumen:
        //     La tecla BLOQ NUM.
        NumLock = 144,
        //
        // Resumen:
        //     La tecla Bloq Despl.
        Scroll = 145,
        //
        // Resumen:
        //     Tecla MAYÚS izquierda.
        LShiftKey = 160,
        //
        // Resumen:
        //     La tecla MAYÚS derecha.
        RShiftKey = 161,
        //
        // Resumen:
        //     Tecla CTRL izquierda.
        LControlKey = 162,
        //
        // Resumen:
        //     Tecla CTRL derecha.
        RControlKey = 163,
        //
        // Resumen:
        //     Tecla ALT izquierda.
        LMenu = 164,
        //
        // Resumen:
        //     Tecla ALT derecha.
        RMenu = 165,
        //
        // Resumen:
        //     Tecla Atrás del explorador (Windows 2000 o posterior).
        BrowserBack = 166,
        //
        // Resumen:
        //     La clave de reenvíos de explorador (Windows 2000 o posterior).
        BrowserForward = 167,
        //
        // Resumen:
        //     Tecla Actualizar del explorador (Windows 2000 o posterior).
        BrowserRefresh = 168,
        //
        // Resumen:
        //     Tecla Detener del explorador (Windows 2000 o posterior).
        BrowserStop = 169,
        //
        // Resumen:
        //     La clave de búsqueda del explorador (Windows 2000 o posterior).
        BrowserSearch = 170,
        //
        // Resumen:
        //     Tecla Favoritos del explorador (Windows 2000 o posterior).
        BrowserFavorites = 171,
        //
        // Resumen:
        //     La tecla inicio del explorador (Windows 2000 o posterior).
        BrowserHome = 172,
        //
        // Resumen:
        //     La clave de silencio de volumen (Windows 2000 o posterior).
        VolumeMute = 173,
        //
        // Resumen:
        //     (Windows 2000 o posterior) de tecla bajar el volumen.
        VolumeDown = 174,
        //
        // Resumen:
        //     El volumen de la clave (Windows 2000 o posterior).
        VolumeUp = 175,
        //
        // Resumen:
        //     La tecla multimedia pista siguiente (Windows 2000 o posterior).
        MediaNextTrack = 176,
        //
        // Resumen:
        //     La media anterior tecla pista (Windows 2000 o posterior).
        MediaPreviousTrack = 177,
        //
        // Resumen:
        //     La clave de detención de medios (Windows 2000 o posterior).
        MediaStop = 178,
        //
        // Resumen:
        //     Tecla Pausa (Windows 2000 o posterior) de reproducción de multimedia.
        MediaPlayPause = 179,
        //
        // Resumen:
        //     La clave de correo electrónico de inicio (Windows 2000 o posterior).
        LaunchMail = 180,
        //
        // Resumen:
        //     La tecla Seleccionar reproducción de multimedia (Windows 2000 o posterior).
        SelectMedia = 181,
        //
        // Resumen:
        //     El inicio una clave de aplicación (Windows 2000 o posterior).
        LaunchApplication1 = 182,
        //
        // Resumen:
        //     La clave de aplicación dos inicio (Windows 2000 o posterior).
        LaunchApplication2 = 183,
        //
        // Resumen:
        //     La clave de punto y coma de OEM en un teclado estándar de Estados Unidos (Windows
        //     2000 o posterior).
        OemSemicolon = 186,
        //
        // Resumen:
        //     Tecla 1 de OEM.
        Oem1 = 186,
        //
        // Resumen:
        //     Los OEM además de clave en el teclado de cualquier país o región (Windows 2000
        //     o posterior).
        Oemplus = 187,
        //
        // Resumen:
        //     La clave de la coma de OEM en el teclado de cualquier país o región (Windows
        //     2000 o posterior).
        Oemcomma = 188,
        //
        // Resumen:
        //     La tecla menos OEM en el teclado de cualquier país o región (Windows 2000 o posterior).
        OemMinus = 189,
        //
        // Resumen:
        //     La clave de período de OEM en el teclado de cualquier país o región (Windows
        //     2000 o posterior).
        OemPeriod = 190,
        //
        // Resumen:
        //     Tecla de signo de interrogación OEM en un teclado estándar de Estados Unidos
        //     (Windows 2000 o posterior).
        OemQuestion = 191,
        //
        // Resumen:
        //     Tecla 2 de OEM.
        Oem2 = 191,
        //
        // Resumen:
        //     La clave de tilde de OEM en un teclado estándar de Estados Unidos (Windows 2000
        //     o posterior).
        Oemtilde = 192,
        //
        // Resumen:
        //     Tecla 3 de OEM.
        Oem3 = 192,
        //
        // Resumen:
        //     La tecla de corchete de apertura de OEM en un teclado estándar de Estados Unidos
        //     (Windows 2000 o posterior).
        OemOpenBrackets = 219,
        //
        // Resumen:
        //     Tecla 4 de OEM.
        Oem4 = 219,
        //
        // Resumen:
        //     La clave de la canalización de OEM en un teclado estándar de Estados Unidos (Windows
        //     2000 o posterior).
        OemPipe = 220,
        //
        // Resumen:
        //     Tecla 5 de OEM.
        Oem5 = 220,
        //
        // Resumen:
        //     La tecla de corchete de cierre de OEM en un teclado estándar de Estados Unidos
        //     (Windows 2000 o posterior).
        OemCloseBrackets = 221,
        //
        // Resumen:
        //     Tecla 6 de OEM.
        Oem6 = 221,
        //
        // Resumen:
        //     El OEM simples y dobles comillas clave en un teclado estándar de Estados Unidos
        //     (Windows 2000 o posterior).
        OemQuotes = 222,
        //
        // Resumen:
        //     Tecla 7 de OEM.
        Oem7 = 222,
        //
        // Resumen:
        //     Tecla 8 de OEM.
        Oem8 = 223,
        //
        // Resumen:
        //     El corchete angular de OEM o la clave de la barra diagonal inversa en el teclado
        //     de RT de 102 teclado (Windows 2000 o posterior).
        OemBackslash = 226,
        //
        // Resumen:
        //     Tecla 102 de OEM.
        Oem102 = 226,
        //
        // Resumen:
        //     La clave de proceso.
        ProcessKey = 229,
        //
        // Resumen:
        //     Se utiliza para pasar caracteres Unicode como si fueran pulsaciones de teclas.
        //     El valor de clave de paquete es la palabra baja de un valor de tecla virtual
        //     de 32 bits utilizado para los métodos de entrada de teclado no.
        Packet = 231,
        //
        // Resumen:
        //     Tecla ATTN.
        Attn = 246,
        //
        // Resumen:
        //     Tecla CRSEL.
        Crsel = 247,
        //
        // Resumen:
        //     Tecla EXSEL.
        Exsel = 248,
        //
        // Resumen:
        //     Tecla ERASE EOF.
        EraseEof = 249,
        //
        // Resumen:
        //     Tecla PLAY.
        Play = 250,
        //
        // Resumen:
        //     Tecla ZOOM.
        Zoom = 251,
        //
        // Resumen:
        //     Constante reservada para un uso futuro.
        NoName = 252,
        //
        // Resumen:
        //     Tecla PA1.
        Pa1 = 253,
        //
        // Resumen:
        //     Tecla BORRAR.
        OemClear = 254,
        //
        // Resumen:
        //     La máscara de bits para extraer un código de tecla de un valor de clave.
        KeyCode = 65535,
        //
        // Resumen:
        //     La tecla modificadora MAYÚS.
        Shift = 65536,
        //
        // Resumen:
        //     La tecla modificadora CTRL.
        Control = 131072,
        //
        // Resumen:
        //     La tecla modificadora ALT.
        Alt = 262144
    }
}
