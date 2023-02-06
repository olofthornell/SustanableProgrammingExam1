package se.hkr.readFromFileWithStream;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.stream.Stream;

public class Main {
    public static void main(String[] args) {

        try (Stream<String> stream = Files.lines(Paths.get("src/se/hkr/readFromFileWithStream/numbers.txt"))) {
                int sum = stream.mapToInt(Integer::parseInt)
                        .filter(x -> x % 2 == 0)
                        .sum();
            System.out.println(sum);

        }catch(IOException e){
            System.out.println("Error...");
        }


    }
}