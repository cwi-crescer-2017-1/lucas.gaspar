import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

public class SaintTest {
    @Test
    public void vestirArmaduraDeixaArmaduraVestida() throws Exception {
        // AAA
        // 1. Arrange - Montagem dos dados de teste
        Constelacao Escorpiao = new Constelacao("Escorpião");
        Armadura escorpiao = new Armadura(Escorpiao, Categoria.OURO);
        Saint milo = new Saint("Milo", escorpiao);
        // 2. Act - Invocar a ação a ser testada
        milo.vestirArmadura();
        // 3. Assert - Verificação dos resultados do teste
        boolean resultado = milo.getArmaduraVestida();
        assertEquals(true, resultado);
    }

    @Test
    public void naoVestirArmaduraDeixaArmaduraNaoVestida() throws Exception {
        Constelacao Cisne = new Constelacao("Cisne");
        Saint hyoga = new Saint("Hyoga", new Armadura(Cisne, Categoria.BRONZE));
        assertEquals(false, hyoga.getArmaduraVestida());
    }

    @Test
    public void aoCriarSaintGeneroENaoInformado() throws Exception {
        Constelacao Virgem = new Constelacao("Virgem");
        Armadura virgem = new Armadura(Virgem, Categoria.OURO);
        Saint shaka = new Saint("Shaka", virgem);
        assertEquals(Genero.NAO_INFORMADO, shaka.getGenero());
    }

    @Test
    public void deveSerPossivelAlterarOGenero() throws Exception {
        Constelacao unicornio = new Constelacao("Unicórnio");
        Saint jabu = new Saint("Jabu", new Armadura(unicornio, Categoria.BRONZE));
        jabu.setGenero(Genero.MASCULINO);
        assertEquals(Genero.MASCULINO, jabu.getGenero());
        jabu.setGenero(Genero.FEMININO);
        assertEquals(Genero.FEMININO, jabu.getGenero());
    }

    @Test
    public void statusInicialDeveSerVivo() throws Exception {
        Constelacao dragao = new Constelacao("Dragão");
        Saint shiryu = new Saint("Shiryu", new Armadura(dragao, Categoria.BRONZE));
        assertEquals(Status.VIVO, shiryu.getStatus());
    }

    @Test
    public void vidaInicialDeveSer100() throws Exception {
        Constelacao dragao = new Constelacao("Dragão");
        Saint shiryu = new Saint("Shiryu", new Armadura(dragao, Categoria.BRONZE));
        assertEquals(100.0, shiryu.getVida(), 0.01);
    }

    @Test
    public void perderDanoComValor10() throws Exception {
        // Arrange
        Constelacao dragao = new Constelacao("Dragão");
        Saint shiryu = new Saint("Shiryu", new Armadura(dragao, Categoria.BRONZE));
        // Act
        shiryu.perderVida(10);
        // Assert
        assertEquals(90, shiryu.getVida(), 0.01);
    }

    @Test
    public void perderDanoComValor100() throws Exception {
        // Arrange
        Constelacao dragao = new Constelacao("Dragão");
        Saint shiryu = new Saint("Shiryu", new Armadura(dragao, Categoria.BRONZE));
        // Act
        shiryu.perderVida(100);
        // Assert
        assertEquals(0, shiryu.getVida(), 0.01);
    }

    @Test
    public void perderDanoComValor1000() throws Exception {
        // Arrange
        Constelacao dragao = new Constelacao("Dragão");
        Saint shiryu = new Saint("Shiryu", new Armadura(dragao, Categoria.BRONZE));
        // Act
        shiryu.perderVida(1000);
        // Assert
        assertEquals(0, shiryu.getVida(), 0.01);
    }

    @Test
    public void perderDanoComValorMenos1000() throws Exception { // verificar como testar
        // Arrange
        Constelacao dragao = new Constelacao("Dragão");
        Saint shiryu = new Saint("Shiryu", new Armadura(dragao, Categoria.BRONZE));
        // Act
        //shiryu.perderVida(-1000);
        // Assert
        //assertEquals(1100, shiryu.getVida(), 0.01);
    }

    @Test
    public void criarSaintNasceCom5SentidosDespertados() throws Exception {
        Constelacao dragao = new Constelacao("Dragão");
        BronzeSaint seiya = new BronzeSaint("Seiya", new Armadura(dragao, Categoria.BRONZE));
        assertEquals(5, seiya.getQtdSentidosDespertados());
    }

    @Test
    public void criarSaintPrataNasceCom6SentidosDespertados() throws Exception {
        Constelacao dragao = new Constelacao("Dragão");
        SilverSaint marin = new SilverSaint("Marin", new Armadura(dragao, Categoria.PRATA));
        assertEquals(6, marin.getQtdSentidosDespertados());
    }
    
    @Test
    public void criarSaintOuroNasceCom7SentidosDespertados() throws Exception {
        Constelacao peixes = new Constelacao("Peixes");
        GoldSaint afrodite = new GoldSaint("Afrodite", new Armadura(peixes, Categoria.OURO));
        assertEquals(7, afrodite.getQtdSentidosDespertados());
    }
    
    @Test(expected=Exception.class)
    public void constelacaoInvalidaDeOuroDeveLancarErro() throws Exception {
        Constelacao cafe = new Constelacao("Café");
        new GoldSaint("Bernardo", new Armadura(cafe, Categoria.OURO));
    }
    
    @Test
    public void saintSoPerdeVidaAte0() throws Exception {
        Constelacao peixes = new Constelacao("peixes");
        SilverSaint afrodite = new SilverSaint("Afrodite", new Armadura(peixes, Categoria.PRATA));
        afrodite.perderVida(1000);
        assertEquals(0, afrodite.getVida(), 0.01);
    }
    
    @Test
    public void saintTrocaStatusQuandoVidaForMenor0() throws Exception {
        Constelacao peixes = new Constelacao("peixes");
        SilverSaint afrodite = new SilverSaint("Afrodite", new Armadura(peixes, Categoria.PRATA));
        afrodite.perderVida(1000);
        assertEquals(Status.MORTO, afrodite.getStatus());
    }
    
    @Test
    public void naoEPossivelAtacarSaintMorto() throws Exception { //está funcionando porque foi visto com o breakpoint, usar um melhor assertEquals
        Constelacao peixes = new Constelacao("peixes");
        SilverSaint afrodite = new SilverSaint("Afrodite", new Armadura(peixes, Categoria.PRATA));
        afrodite.perderVida(1000);
        afrodite.perderVida(100);
        assertEquals(Status.MORTO, afrodite.getStatus());
    }
    
    @Test
    public void metodoAdicionarGolpeFunciona() throws Exception {
        Constelacao peixes = new Constelacao("peixes");
        SilverSaint afrodite = new SilverSaint("Afrodite", new Armadura(peixes, Categoria.PRATA));
        Golpe meteoro = new Golpe("Meteoro de Pégasus", 150);
        afrodite.aprenderGolpe(meteoro);
        assertEquals(meteoro, afrodite.getGolpes());
    }
    
    @Test
    public void getGolpesFunciona() throws Exception {
        Constelacao peixes = new Constelacao("peixes");
        Golpe meteoro = new Golpe("Meteoro de Pégasus", 150);
        peixes.adicionarGolpe(meteoro);
        peixes.getGolpes();
        assertEquals(meteoro, peixes.getGolpes());
    }
    
    @Test
    public void getGolpesNaClasseSaintRetornaOsGolpesDaConstelacao() throws Exception { 
        Constelacao peixes = new Constelacao("peixes");
        SilverSaint afrodite = new SilverSaint("Afrodite", new Armadura(peixes, Categoria.PRATA));
        Golpe meteoro = new Golpe("Meteoro de Pégasus", 150);
        peixes.adicionarGolpe(meteoro);
        afrodite.getGolpes();
        assertEquals(meteoro, afrodite.getGolpes());
    }
    

}








