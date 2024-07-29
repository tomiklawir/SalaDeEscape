class Escape
{
    private static string[] incognitasSalas = new string[2];
    private static int estadoJuego;

    public Escape(){
        string[] incognitasSalas; 
        estadoJuego = 1;
    }

    private static void InicializarJuego(){
        string[] incognitasSalas = {"2586", "MAGNATE", "LUMOS", "914221441"};
    }

    public static int GetEstadoJuego(){
        return estadoJuego;
    }

    public static bool ResolverSala(int Sala, string Incognita){
        if(Sala == estadoJuego)
        {
            if(Incognita == incognitasSalas[Sala]){
                estadoJuego++;
                return true;
            }
            else {
                return false;
            }
        }
        else{
            return false;
        }
    }
}