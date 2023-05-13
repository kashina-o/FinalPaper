# Итоговая работа по основному блоку
## **Условия задачи**

1. Создать репозиторий на __GitHub__
2. Нарисовать блок-схему алгоритма _(можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)_
3. Снабдить репозиторий оформленным текстовым описанием решения _(файл __README.md__)_
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом _(не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)_

**Задача:**

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**
```
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
```
***

## **Описание алгоритма решения**
1. Создаем строковый массив и заполняем его пользователем с клавиатуры. 
2. Выводим массив. 
3. В методе ResultArray при помощи цикла for сначала задаем размер результирующего массива равный количеству элементов первоначального масива, размер которых удовлетворяет условию >=3. 
4. При помощи второго цикла for заполняем результирующий массив соответсвующими элементами первоначального массива.
5. Выводим результирующий массив. 

Графическое представление алгоритма представлено в блок-схеме FlowChart.png
Реализация алгоритма в файле Task.cs 