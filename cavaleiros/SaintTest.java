import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class SaintTest {
    @Test
    public void vestirArmaduraDeixaArmaduraVestida() {
        // AAA
        // 1. Arrange - Montagem dos dados de teste
        Armadura escorpiao = new Armadura("Escorpião", Categoria.OURO);
        Saint milo = new Saint("Milo", escorpiao);
        // 2. Act - Invocar a ação a ser testada
        milo.vestirArmadura();
        // 3. Assert - Verificação dos resultados do teste
        boolean resultado = milo.getArmaduraVestida();
        assertEquals(true, resultado);
    }
    
    @Test
    public void naoVestirArmaduraDeixaArmaduraNaoVestida() {
        Saint hyoga = new Saint("Hyoga", new Armadura("Cisne", Categoria.BRONZE));
        assertEquals(false, hyoga.getArmaduraVestida());
    }
    
    @Test
    public void aoCriarSaintGeneroENaoInformado() {
        Armadura virgem = new Armadura("Virgem", Categoria.OURO);
        Saint shaka = new Saint("Shaka", virgem);
        assertEquals(Genero.NAO_INFORMADO, shaka.getGenero());
    }
    
    @Test //testar se o saint nasce com Status: vivo
     public void saintNasceVivo() {
        Armadura virgem = new Armadura("Virgem", Categoria.OURO);
        Saint shaka = new Saint("Shaka", virgem);
        assertEquals(StatusSaint.VIVO, shaka.getStatus());
    }
    
    @Test //Testar se Saint perde vida na chamada do método perderVida() da classe Saint
    public void saintPerdeVidaQuandoChamaOMetodo(){
        Armadura virgem = new Armadura("Virgem", Categoria.OURO);
        Saint shaka = new Saint("Shaka", virgem);
        shaka.perderVida(10);
        assertEquals(90.0, shaka.getVida());
    }
    
    @Test // Testar se o saint com menor armadura perde vida
    public void saintCorretoPerdeVidaNaBatalha(){
        Armadura virgem = new Armadura("Virgem", Categoria.OURO);
        Saint shaka = new Saint("Shaka", virgem);
        Armadura dragao = new Armadura("Dragão", Categoria.PRATA);
        Saint shiryu = new Saint("Shiryu", dragao);
        Batalha batalhaepica = new Batalha(shaka, shiryu);
        batalhaepica.iniciar();
        assertEquals(90.0,shiryu.getVida());
    }
    
}




