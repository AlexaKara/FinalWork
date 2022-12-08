Console.Write("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = new string[num];
for (int i = 0; i < num; i++) {
    Console.Write($"Введите {i + 1} элемент массива: ");
    array[i] = Console.ReadLine()!;
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

Console.WriteLine("[" + string.Join(", ", result) + "]");