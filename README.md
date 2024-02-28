# Итоговая контрольная работа по основному блоку

**Задача:** Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

```
Примеры: 
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] 
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
```

## Описание решения задачи

### Начальные данные

В качестве начальных данных обозначен массив ***arrayStart***

```
{"ехали", "медведи", "на", "велосипеде", "а", "за", "ними", "раки", "на", "хромой", "собаке", "вот", "и", "сказочке", "esc", "кто", "не", "понял", "F1"};
```

и пустой массив ***arrayResult*** для сохранения результатов, удовлетворяющих требованиям. На данном этапе длина массивов совпадает.

### Метод решения

Первым шагом мы вводим переменную **count**, которая будет являться счетчиком  элементов массива подходящим под условие задачи, а так же с целью корректировки длины массива в дальнейшем.

Далее, происходит перебор каждого элемента массива и с помощью условия определяется его соответствие заявленному заданию. В случае соблюдения условия, элемент начального массива присваивается элементу массива результата с индексом count. Финальным шагом переменная count увеличивается на единицу.

Вводим итоговый массив ***arrayItog*** длинной равной count. Переписываем элементы массива arrayResult в arrayItog удовлетворяющие требованиям задания.

### Вывод результата

Вывод массива результата осуществляется методом **string.Join**

```
на, а, за, на, вот, и, esc, кто, не, F1
```