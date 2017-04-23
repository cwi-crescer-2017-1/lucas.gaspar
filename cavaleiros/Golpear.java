public class Golpear implements Movimento {
   private Saint golpeador;
   private Saint golpeado;
    
   public Golpear(Saint golpeador, Saint golpeado){
       this.golpeador = golpeador;
       this.golpeado = golpeado;
   }
    
   public void executar() {
       double dano = this.golpeador.getProximoGolpe().getFatorDano();
       if(golpeador.getArmaduraVestida() == true){
           int multiplicar = this.golpeador.getArmadura().getCategoria().getValor();
           dano = dano*(multiplicar + 1);
       } 
       golpeado.perderVida(dano);
   }
}
