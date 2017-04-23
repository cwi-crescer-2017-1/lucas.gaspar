public class Batalha {

    private Saint saint1, saint2;

    public Batalha(Saint saint1, Saint saint2) {
        this.saint1 = saint1;
        this.saint2 = saint2;
    }

    // public void iniciar() {
    // int valor1 = this.saint1.getArmadura().getCategoria().getValor();
    // int valor2 = this.saint2.getArmadura().getCategoria().getValor();
    // final double dano = 10;

    // if (valor1 >= valor2) {
    // this.saint2.perderVida(dano);
    // } else {
    // this.saint1.perderVida(dano);
    // }

    // }

    public void iniciar() {
        int valor1 = this.saint1.getArmadura().getCategoria().getValor();
        int valor2 = this.saint2.getArmadura().getCategoria().getValor();
        Saint proximoAGolpear;
        Saint golpeado;

        if (valor1 >= valor2) {
            Golpear g1 = new Golpear(this.saint1, this.saint2);
            g1.executar();
            proximoAGolpear = this.saint2;
            if(this.saint2.getStatus().equals(Status.MORTO)){
                return;
            }
        } else {
            Golpear g1 = new Golpear(this.saint2, this.saint1);
            g1.executar();
            proximoAGolpear = this.saint1;
            if(this.saint1.getStatus().equals(Status.MORTO)){
                return;
            }
        }

        while(this.saint1.getStatus().equals(Status.VIVO) && this.saint2.getStatus().equals(Status.VIVO)){

            if(proximoAGolpear.equals(this.saint1)){
                golpeado = this.saint2;
            } else {
                golpeado = this.saint1;
            }

            Golpear g1 = new Golpear(proximoAGolpear,golpeado);
            g1.executar();

            if(proximoAGolpear.equals(this.saint1)){
                proximoAGolpear = this.saint2;
            }
            else{
                proximoAGolpear = this.saint1;
            }

        }
    }
}
