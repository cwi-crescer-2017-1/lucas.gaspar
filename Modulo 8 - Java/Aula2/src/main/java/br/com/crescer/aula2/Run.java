package br.com.crescer.aula2;

import java.io.File;
import java.io.IOException;

/**
 *
 * @author lucas.gaspar
 */
public class Run {
    public static void main(String[] args) throws IOException {
        final File file = new File("aula2.txt");
        file.createNewFile();
    }
}
