import java.util.ArrayList;
public class ListaSaints
{
    private ArrayList <Saint> lista = new ArrayList<>(); 
    
    public void adicionarSaint(Saint saint){
        this.lista.add(saint);
    }
    
    public ArrayList <Saint> todos(){
        return this.lista;
    }
    
    public Saint getIndice(int indice){
        return this.lista.get(indice);
    }
}
