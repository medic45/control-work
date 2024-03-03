# Control-work
1. Программа запускается с отображения сообщения, в котором пользователю предлагается ввести строки, разделенные запятой и пробелом.
2. Введенные пользователем данные считываются с помощью Console.ReadLine() и сохраняются в переменной 'input'.
3. Затем входная строка разбивается на массив подстрок с помощью метода Split с разделителем ", ".
4. Вызывается метод FilterShortStrings с массивом inputArray в качестве аргумента для отсеивания строк длиной более 3 символов.
5. Внутри метода FilterShortStrings:
- Сначала подсчитывается количество строк, удовлетворяющих условию (длина <= 3).
- Затем создается новый массив 'resultArray' для хранения отфильтрованных строк на основе подсчета.
- Он выполняет итерации по массиву inputArray, проверяет длину каждой строки и добавляет отфильтрованные строки в resultArray.
- Наконец, возвращается массив resultArray, содержащий отфильтрованные строки.
6. В методе Main отфильтрованные строки из массива resultArray выводятся на экран, соединяясь запятой и пробелом и заключаясь в квадратные скобки.

# Блок-схема
