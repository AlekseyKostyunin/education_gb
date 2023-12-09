package education_gb.Java.Lesson_2;

import java.util.Scanner;

class Calculator {
  public static void main(String[] args) {
    int a; int b; int ans; char op;
    try (Scanner reader = new Scanner(System.in)) {
      System.out.print("Введите первое число: ");
      a = reader.nextInt();
      System.out.print("\nВведите оператор (+, -, *, /): ");
      op = reader.next().charAt(0);
      System.out.print("Введите второе число: ");
      b = reader.nextInt();
    }
    switch(op) {
      case '+': ans = a + b; break;
      case '-': ans = a - b; break;
      case '*': ans = a * b; break;
      case '/': ans = a / b; break;
      default: System.out.printf("Ошибка! Введите правильный оператор"); return; }
      //  System.out.print("\nРезультат:\n");
      //  System.out.printf(a + " " + op + " " + b + " = " + ans);
      System.out.print(ans);
    }
}