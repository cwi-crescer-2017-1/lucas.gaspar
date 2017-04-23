public class BronzeSaint extends Saint {
    
    public BronzeSaint(String nome, String constelacao) throws Exception {
       super(nome, new Armadura(new Constelacao(constelacao), Categoria.BRONZE));
       this.qtdSentidosDespertados = 5;
    }
    
    // public BronzeSaint(String nome, Armadura armadura) throws Exception {
        // super(nome, armadura);
        // this.qtdSentidosDespertados = 5;
    // }
}