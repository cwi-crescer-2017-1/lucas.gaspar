package br.com.crescer.tema1;

import java.math.BigDecimal;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.HashMap;
import java.util.Map;

public class MeuParcelator implements Parcelator {
    
    private static final SimpleDateFormat FORMAT = new SimpleDateFormat("dd/MM/yyyy");

    public Map<String, BigDecimal> calcular(BigDecimal valorParcelar, int numeroParcelas, double taxaJuros, Date dataPrimeiroVencimento) {
        Map<String, BigDecimal> mapaParcelas = new HashMap<String, BigDecimal>();
        Calendar calendar = Calendar.getInstance();
        calendar.setTime(dataPrimeiroVencimento);
        
        BigDecimal valorParcela;
        
        valorParcela = new BigDecimal((valorParcelar.doubleValue() + ((valorParcelar.doubleValue() * taxaJuros)/100))/numeroParcelas);
        
        for(int i=0; i<numeroParcelas; i++){
            mapaParcelas.put(FORMAT.format(calendar.getTime()), valorParcela);
            calendar.add(calendar.MONTH,1);
        }
        
        return mapaParcelas;
    }
    
}
