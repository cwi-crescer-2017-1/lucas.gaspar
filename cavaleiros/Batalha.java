public class Batalha{
    private Saint saint1;
    private Saint saint2;
    private Categoria categoria1;
    private Categoria categoria2;
    private int valor1;
    private int valor2;
 
 
    public Batalha(Saint saint1, Saint saint2){
        this.saint1 = saint1;
        this.saint2 = saint2;
    }
    
    public void iniciar(){
        categoria1 = saint1.getCategoriaArmadura();
        categoria2 = saint2.getCategoriaArmadura();
        valor1 = categoria1.getValor();
        valor2 = categoria2.getValor();
        
        if(valor1>=valor2){
            saint2.perderVida(10);
        }
        else{
            saint1.perderVida(10);
        }
    }
}
