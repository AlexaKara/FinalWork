System.Console.WriteLine("Из N элементов массива A формируется новый массив размер элементов которого меньше либо равна 3");
System.Console.Write("Введите количество N: ");
int num = Convert.ToInt32(Console.ReadLine());

string[] array = new string[num];
for (int i = 0; i < num; i++) {
    System.Console.Write($"Введите {i + 1} элемент массива A: ");
    array[i] = Console.ReadLine();
}

int count_elements = 0;
string elements = String.Empty;

for (int i = 0; i < array.Length; i++) {
    if (array[i].Length <= 3) {
        elements = elements + Convert.ToString(i);
        count_elements += 1;
    }
}

string[] result = new string[count_elements];

for (int i = 0; i < count_elements; i++) {
    int j = Convert.ToInt32(Convert.ToString(elements[i]));
    result[i] = array[j];
}

System.Console.WriteLine("[" + string.Join(", ", result) + "]");