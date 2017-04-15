public class Saint {
    private String nome;
    private Armadura armadura;
    private boolean armaduraVestida;
    private Genero genero = Genero.NAO_INFORMADO;
    private StatusSaint status = StatusSaint.VIVO;
    private double vida=100.0;
    
    public Saint(String nome, Armadura armadura) {
        this.nome = nome;
        this.armadura = armadura;
    }
    
    public void vestirArmadura() {
        this.armaduraVestida = true;
    }
    
    // camelCase
    public boolean getArmaduraVestida() {
        return this.armaduraVestida;
    }
    
    public Genero getGenero() {
        return this.genero;
    }
    
    public void setGenero(Genero genero) {
        this.genero = genero;
    }
      
    public StatusSaint getStatus() {
        return this.status;
    }
    
    public double perderVida(double quantidadeVidaPerdida){
        this.vida = this.vida - quantidadeVidaPerdida;
        return this.vida;
    }
    
    public double getVida() {
        return this.vida;
    }
    
    public Categoria getCategoriaArmadura(){
        return armadura.getCategoria();
    }
    
}










