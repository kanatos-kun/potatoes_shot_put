using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class fontUse : MonoBehaviour {

    public Sprite[] spriteList;
    public float spaceWord;
    public float sizeFont = 1;
    public GameObject ImageToScreen; 
    private Text textContent;

    struct customFont
    {
        public static Sprite a;
        public static Sprite b;
        public static Sprite c;
        public static Sprite d;
        public static Sprite e;
        public static Sprite f;
        public static Sprite g;
        public static Sprite h;
        public static Sprite i;
        public static Sprite j;
        public static Sprite k;
        public static Sprite l;
        public static Sprite m;
        public static Sprite n;
        public static Sprite o;
        public static Sprite p;
        public static Sprite q;
        public static Sprite r;
        public static Sprite s;
        public static Sprite t;
        public static Sprite u;
        public static Sprite v;
        public static Sprite w;
        public static Sprite x;
        public static Sprite y;
        public static Sprite z;
        public static Sprite A;
        public static Sprite B;
        public static Sprite C;
        public static Sprite D;
        public static Sprite E;
        public static Sprite F;
        public static Sprite G;
        public static Sprite H;
        public static Sprite I;
        public static Sprite J;
        public static Sprite K;
        public static Sprite L;
        public static Sprite M;
        public static Sprite N;
        public static Sprite O;
        public static Sprite P;
        public static Sprite Q;
        public static Sprite R;
        public static Sprite S;
        public static Sprite T;
        public static Sprite U;
        public static Sprite V;
        public static Sprite W;
        public static Sprite X;
        public static Sprite Y;
        public static Sprite Z;
        public static Sprite NUM0;
        public static Sprite NUM1;
        public static Sprite NUM2;
        public static Sprite NUM3;
        public static Sprite NUM4;
        public static Sprite NUM5;
        public static Sprite NUM6;
        public static Sprite NUM7;
        public static Sprite NUM8;
        public static Sprite NUM9;
        public static Sprite special_01;
        public static Sprite special_02;
        public static Sprite special_03;
        public static Sprite special_04;
        public static Sprite special_05;
        public static Sprite special_06;
        public static Sprite special_07;
        public static Sprite special_08;
        public static Sprite special_09;
        public static Sprite special_10;
        public static Sprite special_11;
        public static Sprite special_12;
        public static Sprite special_13;
        public static Sprite special_14;
        public static Sprite special_15;
        public static Sprite special_16;
        public static Sprite special_17;
        public static Sprite special_18;
        public static Sprite special_19;
        public static Sprite special_20;
        public static Sprite special_21;
        public static Sprite special_22;
        public static Sprite special_23;
        public static Sprite special_24;
        public static Sprite special_25;
        public static Sprite special_26;
        public static Sprite special_27;
        public static Sprite special_28;
        public static Sprite special_29;
        public static Sprite special_30;
        public static Sprite special_31;
        public static Sprite special_32;
        public static Sprite special_33;
        public static Sprite special_34;
        public static Sprite special_35;
    }


    // Use this for initialization
    void Start () {
        for(int i =0; i < spriteList.Length; ++i)
        {
            Debug.Log(spriteList[i].name);
            switch (spriteList[i].name)
            {
                case "a":
                    customFont.a = spriteList[i];
                    break;
                case "b":
                    customFont.b = spriteList[i];
                    break;
                case "c":
                    customFont.c = spriteList[i];
                    break;
                case "d":
                    customFont.d = spriteList[i];
                    break;
                case "e":
                    customFont.e = spriteList[i];
                    break;
                case "f":
                    customFont.f = spriteList[i];
                    break;
                case "g":
                    customFont.g = spriteList[i];
                    break;
                case "h":
                    customFont.h = spriteList[i];
                    break;
                case "i":
                    customFont.i = spriteList[i];
                    break;
                case "j":
                    customFont.j = spriteList[i];
                    break;
                case "k":
                    customFont.k = spriteList[i];
                    break;
                case "l":
                    customFont.l = spriteList[i];
                    break;
                case "m":
                    customFont.m = spriteList[i];
                    break;
                case "n":
                    customFont.n = spriteList[i];
                    break;
                case "o":
                    customFont.o = spriteList[i];
                    break;
                case "p":
                    customFont.p = spriteList[i];
                    break;
                case "q":
                    customFont.q = spriteList[i];
                    break;
                case "r":
                    customFont.r = spriteList[i];
                    break;
                case "s":
                    customFont.s = spriteList[i];
                    break;
                case "t":
                    customFont.t = spriteList[i];
                    break;
                case "u":
                    customFont.u = spriteList[i];
                    break;
                case "v":
                    customFont.v = spriteList[i];
                    break;
                case "w":
                    customFont.w = spriteList[i];
                    break;
                case "x":
                    customFont.x = spriteList[i];
                    break;
                case "y":
                    customFont.y = spriteList[i];
                    break;
                case "z":
                    customFont.z = spriteList[i];
                    break;
                case "A":
                    customFont.A = spriteList[i];
                    break;
                case "B":
                    customFont.B = spriteList[i];
                    break;
                case "C":
                    customFont.C = spriteList[i];
                    break;
                case "D":
                    customFont.D = spriteList[i];
                    break;
                case "E":
                    customFont.E = spriteList[i];
                    break;
                case "F":
                    customFont.F = spriteList[i];
                    break;
                case "G":
                    customFont.G = spriteList[i];
                    break;
                case "H":
                    customFont.H = spriteList[i];
                    break;
                case "I":
                    customFont.I = spriteList[i];
                    break;
                case "J":
                    customFont.J = spriteList[i];
                    break;
                case "K":
                    customFont.K = spriteList[i];
                    break;
                case "L":
                    customFont.L = spriteList[i];
                    break;
                case "M":
                    customFont.M = spriteList[i];
                    break;
                case "N":
                    customFont.N = spriteList[i];
                    break;
                case "O":
                    customFont.O = spriteList[i];
                    break;
                case "P":
                    customFont.P = spriteList[i];
                    break;
                case "Q":
                    customFont.Q = spriteList[i];
                    break;
                case "R":
                    customFont.R = spriteList[i];
                    break;
                case "S":
                    customFont.S = spriteList[i];
                    break;
                case "T":
                    customFont.T = spriteList[i];
                    break;
                case "U":
                    customFont.U = spriteList[i];
                    break;
                case "V":
                    customFont.V = spriteList[i];
                    break;
                case "W":
                    customFont.W = spriteList[i];
                    break;
                case "X":
                    customFont.X = spriteList[i];
                    break;
                case "Y":
                    customFont.Y = spriteList[i];
                    break;
                case "Z":
                    customFont.Z = spriteList[i];
                    break;
                case "NUM0":
                    customFont.NUM0 = spriteList[i];
                    break;
                case "NUM1":
                    customFont.NUM1 = spriteList[i];
                    break;
                case "NUM2":
                    customFont.NUM2 = spriteList[i];
                    break;
                case "NUM3":
                    customFont.NUM3 = spriteList[i];
                    break;
                case "NUM4":
                    customFont.NUM4 = spriteList[i];
                    break;
                case "NUM5":
                    customFont.NUM5 = spriteList[i];
                    break;
                case "NUM6":
                    customFont.NUM6 = spriteList[i];
                    break;
                case "NUM7":
                    customFont.NUM7 = spriteList[i];
                    break;
                case "NUM8":
                    customFont.NUM8 = spriteList[i];
                    break;
                case "NUM9":
                    customFont.NUM9 = spriteList[i];
                    break;
                case "special_1":
                    customFont.special_01 = spriteList[i];
                    break;
                case "special_2":
                    customFont.special_02 = spriteList[i];
                    break;
                case "special_3":
                    customFont.special_03 = spriteList[i];
                    break;
                case "special_4":
                    customFont.special_04 = spriteList[i];
                    break;
                case "special_5":
                    customFont.special_05 = spriteList[i];
                    break;
                case "special_6":
                    customFont.special_06 = spriteList[i];
                    break;
                case "special_7":
                    customFont.special_07 = spriteList[i];
                    break;
                case "special_8":
                    customFont.special_08 = spriteList[i];
                    break;
                case "special_9":
                    customFont.special_09 = spriteList[i];
                    break;
                case "special_10":
                    customFont.special_10 = spriteList[i];
                    break;
                case "special_11":
                    customFont.special_11 = spriteList[i];
                    break;
                case "special_12":
                    customFont.special_12 = spriteList[i];
                    break;
                case "special_13":
                    customFont.special_13 = spriteList[i];
                    break;
                case "special_14":
                    customFont.special_14 = spriteList[i];
                    break;
                case "special_15":
                    customFont.special_15 = spriteList[i];
                    break;
                case "special_16":
                    customFont.special_16 = spriteList[i];
                    break;
                case "special_17":
                    customFont.special_17 = spriteList[i];
                    break;
                case "special_18":
                    customFont.special_18 = spriteList[i];
                    break;
                case "special_19":
                    customFont.special_19 = spriteList[i];
                    break;
                case "special_20":
                    customFont.special_20 = spriteList[i];
                    break;
                case "special_21":
                    customFont.special_21 = spriteList[i];
                    break;
                case "special_22":
                    customFont.special_22 = spriteList[i];
                    break;
                case "special_23":
                    customFont.special_23 = spriteList[i];
                    break;
                case "special_24":
                    customFont.special_24 = spriteList[i];
                    break;
                case "special_25":
                    customFont.special_25 = spriteList[i];
                    break;
                case "special_26":
                    customFont.special_26 = spriteList[i];
                    break;
                case "special_27":
                    customFont.special_27 = spriteList[i];
                    break;
                case "special_28":
                    customFont.special_28 = spriteList[i];
                    break;
                case "special_29":
                    customFont.special_29 = spriteList[i];
                    break;
                case "special_30":
                    customFont.special_30 = spriteList[i];
                    break;
                case "special_31":
                    customFont.special_31 = spriteList[i];
                    break;
                case "special_32":
                    customFont.special_32 = spriteList[i];
                    break;
                case "special_33":
                    customFont.special_33 = spriteList[i];
                    break;
                case "special_34":
                    customFont.special_34 = spriteList[i];
                    break;
                case "special_35":
                    customFont.special_35 = spriteList[i];
                    break;
                default:
                    break;
            }
        }

        textContent = GetComponent<Text>();
        //parseString(textContent.text);
        RenderedFontInScreen(parseString(textContent.text));
	}

    void RenderedFontInScreen(List<char> charList)
    {
        float x=0f;
        for (int i = 0; i < charList.Count - 1; ++i)
        {
            string a = charList[i].ToString();
            x += spaceWord;
            Image instanceImage = Instantiate(ImageToScreen).GetComponent<Image>();
            instanceImage.gameObject.transform.SetParent(transform);

            instanceImage.gameObject.transform.position = transform.position + new Vector3(x,0,0);
            instanceImage.gameObject.transform.localScale *= sizeFont; 
            switch (a)
            {
                case "a":
                    instanceImage.sprite = customFont.a;
                    instanceImage.name = "a";
                    break;
                case "b":
                    instanceImage.sprite = customFont.b;
                    instanceImage.name = "b";
                    break;
                case "c":
                    instanceImage.sprite = customFont.c;
                    instanceImage.name = "c";
                    break;
                case "d":
                    instanceImage.sprite = customFont.d;
                    instanceImage.name = "d";
                    break;
                case "e":
                    instanceImage.sprite = customFont.e;
                    instanceImage.name = "e";
                    break;
                case "f":
                    instanceImage.sprite = customFont.f;
                    instanceImage.name = "f";
                    break;
                case "g":
                    instanceImage.sprite = customFont.g;
                    break;
                case "h":
                    instanceImage.sprite = customFont.h;
                    instanceImage.name = "h";
                    break;
                case "i":
                    instanceImage.sprite = customFont.i;
                    instanceImage.name = "i";
                    break;
                case "j":
                    instanceImage.sprite = customFont.j;
                    instanceImage.name = "j";
                    break;
                case "k":
                    instanceImage.sprite = customFont.k;
                    instanceImage.name = "k";
                    break;
                case "l":
                    instanceImage.sprite = customFont.l;
                    instanceImage.name = "l";
                    break;
                case "m":
                    instanceImage.sprite = customFont.m;
                    instanceImage.name = "m";
                    break;
                case "n":
                    instanceImage.sprite = customFont.n;
                    instanceImage.name = "n";
                    break;
                case "o":
                    instanceImage.sprite = customFont.o;
                    instanceImage.name = "o";
                    break;
                case "p":
                    instanceImage.sprite = customFont.p;
                    instanceImage.name = "p";
                    break;
                case "q":
                    instanceImage.sprite = customFont.q;
                    instanceImage.name = "q";
                    break;
                case "r":
                    instanceImage.sprite = customFont.r;
                    instanceImage.name = "r";
                    break;
                case "s":
                    instanceImage.sprite = customFont.s;
                    instanceImage.name = "s";
                    break;
                case "t":
                    instanceImage.sprite = customFont.t;
                    instanceImage.name = "t";
                    break;
                case "u":
                    instanceImage.sprite = customFont.u;
                    instanceImage.name = "u";
                    break;
                case "v":
                    instanceImage.sprite = customFont.v;
                    instanceImage.name = "v";
                    break;
                case "w":
                    instanceImage.sprite = customFont.w;
                    instanceImage.name = "w";
                    break;
                case "x":
                    instanceImage.sprite = customFont.x;
                    instanceImage.name = "x";
                    break;
                case "y":
                    instanceImage.sprite = customFont.y;
                    instanceImage.name = "y";
                    break;
                case "z":
                    instanceImage.sprite = customFont.z;
                    instanceImage.name = "z";
                    break;
                case "A":
                    instanceImage.sprite = customFont.A;
                    instanceImage.name = "A";
                    break;
                case "B":
                    instanceImage.sprite = customFont.B;
                    instanceImage.name = "B";
                    break;
                case "C":
                    instanceImage.sprite = customFont.C;
                    instanceImage.name = "C";
                    break;
                case "D":
                    instanceImage.sprite = customFont.D;
                    instanceImage.name = "D";
                    break;
                case "E":
                    instanceImage.sprite = customFont.E;
                    instanceImage.name = "E";
                    break;
                case "F":
                    instanceImage.sprite = customFont.F;
                    instanceImage.name = "F";
                    break;
                case "G":
                    instanceImage.sprite = customFont.G;
                    instanceImage.name = "G";
                    break;
                case "H":
                    instanceImage.sprite = customFont.H;
                    instanceImage.name = "H";
                    break;
                case "I":
                    instanceImage.sprite = customFont.I;
                    instanceImage.name = "I";
                    break;
                case "J":
                    instanceImage.sprite = customFont.J;
                    instanceImage.name = "J";
                    break;
                case "K":
                    instanceImage.sprite = customFont.K;
                    instanceImage.name = "K";
                    break;
                case "L":
                    instanceImage.sprite = customFont.L;
                    instanceImage.name = "L";
                    break;
                case "M":
                    instanceImage.sprite = customFont.M;
                    instanceImage.name = "M";
                    break;
                case "N":
                    instanceImage.sprite = customFont.N;
                    instanceImage.name = "N";
                    break;
                case "O":
                    instanceImage.sprite = customFont.O;
                    instanceImage.name = "O";
                    break;
                case "P":
                    instanceImage.sprite = customFont.P;
                    instanceImage.name = "P";
                    break;
                case "Q":
                    instanceImage.sprite = customFont.Q;
                    instanceImage.name = "Q";
                    break;
                case "R":
                    instanceImage.sprite = customFont.R;
                    instanceImage.name = "R";
                    break;
                case "S":
                    instanceImage.sprite = customFont.S;
                    instanceImage.name = "S";
                    break;
                case "T":
                    instanceImage.sprite = customFont.T;
                    instanceImage.name = "T";
                    break;
                case "U":
                    instanceImage.sprite = customFont.U;
                    instanceImage.name = "U";
                    break;
                case "V":
                    instanceImage.sprite = customFont.V;
                    instanceImage.name = "V";
                    break;
                case "W":
                    instanceImage.sprite = customFont.W;
                    instanceImage.name = "W";
                    break;
                case "X":
                    instanceImage.sprite = customFont.X;
                    instanceImage.name = "X";
                    break;
                case "Y":
                    instanceImage.sprite = customFont.Y;
                    instanceImage.name = "Y";
                    break;
                case "Z":
                    instanceImage.sprite = customFont.Z;
                    instanceImage.name = "Z";
                    break;
                case "0":
                    instanceImage.sprite = customFont.NUM0;
                    instanceImage.name = "0";
                    break;
                case "1":
                    instanceImage.sprite = customFont.NUM1;
                    instanceImage.name = "1";
                    break;
                case "2":
                    instanceImage.sprite = customFont.NUM2;
                    instanceImage.name = "2";
                    break;
                case "3":
                    instanceImage.sprite = customFont.NUM3;
                    instanceImage.name = "3";
                    break;
                case "4":
                    instanceImage.sprite = customFont.NUM4;
                    instanceImage.name = "4";
                    break;
                case "5":
                    instanceImage.sprite = customFont.NUM5;
                    instanceImage.name = "5";
                    break;
                case "6":
                    instanceImage.sprite = customFont.NUM6;
                    instanceImage.name = "6";
                    break;
                case "7":
                    instanceImage.sprite = customFont.NUM7;
                    instanceImage.name = "7";
                    break;
                case "8":
                    instanceImage.sprite = customFont.NUM8;
                    instanceImage.name = "8";
                    break;
                case "9":
                    instanceImage.sprite = customFont.NUM9;
                    instanceImage.name = "9";
                    break;
                case "+":
                    instanceImage.sprite = customFont.special_16;
                    instanceImage.name = "+";
                    break;
                case "-":
                    instanceImage.sprite = customFont.special_17;
                    instanceImage.name = "-";
                    break;
                case "*":
                    instanceImage.sprite = customFont.special_19;
                    instanceImage.name = "*";
                    break;
                case "/":
                    instanceImage.sprite = customFont.special_18;
                    instanceImage.name = "/";
                    break;
                case "&":
                    break;
                case "é":
                    instanceImage.sprite = customFont.special_01;
                    instanceImage.name = "é";
                    break;
                case "~":
                    instanceImage.sprite = customFont.special_15;
                    instanceImage.name = "~";
                    break;
                case "\"":
                    instanceImage.sprite = customFont.special_02;
                    instanceImage.name = "\"";
                    break;
                case "'":
                    instanceImage.sprite = customFont.special_07;
                    instanceImage.name = "'";
                    break;
                case "(":
                    instanceImage.sprite = customFont.special_10;
                    instanceImage.name = "(";
                    break;
                case "{":
                    instanceImage.sprite = customFont.special_08;
                    instanceImage.name = "{";
                    break;
                case "[":
                    break;
                case "|":
                    break;
                case "è":
                    break;
                case "_":
                    instanceImage.sprite = customFont.special_28;
                    instanceImage.name = "_";
                    break;
                case "\\":
                    instanceImage.sprite = customFont.special_26;
                    instanceImage.name = "\\";
                    break;
                case "ç":
                    instanceImage.sprite = customFont.special_13;
                    instanceImage.name = "ç";
                    break;
                case "^":
                    instanceImage.sprite = customFont.special_32;
                    instanceImage.name = "^";
                    break;
                case "@":
                    instanceImage.sprite = customFont.special_12;
                    instanceImage.name = "@";
                    break;
                case ")":
                    break;
                case "=":
                    instanceImage.sprite = customFont.special_06;
                    instanceImage.name = "=";
                    break;
                case ",":
                    instanceImage.sprite = customFont.special_23;
                    instanceImage.name = ",";
                    break;
                case "?":
                    instanceImage.sprite = customFont.special_21;
                    instanceImage.name = "?";
                    break;
                case ";":
                    instanceImage.sprite = customFont.special_24;
                    instanceImage.name = ";";
                    break;
                case ".":
                    instanceImage.sprite = customFont.special_20;
                    instanceImage.name = ".";
                    break;
                case ":":
                    instanceImage.sprite = customFont.special_25;
                    instanceImage.name = ":";
                    break;
                case "!":
                    instanceImage.sprite = customFont.special_22;
                    instanceImage.name = "!";
                    break;
                case "$":
                    break;
                case "µ":
                    break;
                default:
                    Destroy(instanceImage.gameObject);
                    break;
            }
        }

    }

	// Update is called once per frame
	void Update () {
	}

    private List<char> parseString(string str)
    {
        List<char> list = new List<char>();
        for(int i = 0; i < str.Length; ++i)
        {
            list.Add(str[i]);
            if (list[i].ToString() == " ") { Debug.Log("espacement"); }
        }
        return list;
    }
}
