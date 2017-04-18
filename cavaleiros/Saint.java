public class Saint {
    private String nome;
    private Armadura armadura;
    private boolean armaduraVestida;
    private Genero genero = Genero.NAO_INFORMADO;
    private Status status = Status.VIVO;
    private double vida = 100.;
    protected int qtdSentidosDespertados;

    public Saint(String nome, Armadura armadura) throws Exception {
        this.nome = nome;
        this.armadura = armadura;
        /*int valorCategoria = this.armadura.getCategoria().getValor();
        this.qtdSentidosDespertados += valorCategoria;*/
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

    public Status getStatus() {
        return this.status;
    }

    public double getVida() {
        return this.vida;
    }

    public void perderVida(double dano) throws Exception {
        //this.vida = this.vida - dano;
        if(dano<0){
            throw new Exception("Não são permitidos valores negativos em dano");
        }
        if (this.status != Status.MORTO) {
            this.vida -= dano;
            if (this.vida<=0){
                this.vida=0;
                this.status = Status.MORTO;
            }
        }
    }

    public Armadura getArmadura() {
        return this.armadura;
    }

    public int getQtdSentidosDespertados() {
        return this.qtdSentidosDespertados;
    }
    
    public Golpe getGolpes(){
        return this.getArmadura().getConstelacao().getGolpes();
    }
    
    public void aprenderGolpe(Golpe golpe){
        this.getArmadura().getConstelacao().adicionarGolpe(golpe);
    }
    
    public Golpe getProximoGolpe(){
        return this.getArmadura().getConstelacao().getGolpes();
    }

}

