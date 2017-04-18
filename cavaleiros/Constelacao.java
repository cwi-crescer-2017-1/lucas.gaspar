public class Constelacao
{
    private String nome;
    private Golpe[] golpe = new Golpe[3];
    
    public Constelacao(String nome){
        this.nome = nome;
    }
    
    public void adicionarGolpe(Golpe golpe){
        for(int i=0; i<this.golpe.length; i++){
            if(this.golpe[i] == null ){
                this.golpe[i] = golpe;
                break;
            }
        }
    }
    
    public Golpe getGolpes(){
        return golpe[0];
    }
    
    public String getNome(){
        return this.nome;
    }

}
