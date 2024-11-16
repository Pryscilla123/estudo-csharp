using System.Xml.XPath;

namespace aula73;

class Calculator{
    public static void Triple(ref int x){
        x = x * 3;
    }

    //out significa que você vai guardar e devolver o valor para a variável
    // nesse caso eu quero triplicar o x e guardar o resultado em y
    public static void Triple(int x, out int y){
        y = x * 3;
    }
}