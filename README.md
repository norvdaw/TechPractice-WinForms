<h1 align="center">Tech Practice WinForms</h1>

Одна из специальных функций математической физики имеет следующий
вид:

<h3 align="center"><img src="https://github.com/norvdaw/TechPracticeWinForms/blob/main/images/Integral.PNG" height="72"/></h3>

Цель задания - изучить и сравнить различные способы приближенного
вычисления данной функции.

## Task 1.

Необходимо протабулировать 𝐶(𝑥) на отрезке [𝑎, 𝑏] с шагом ℎ и
точностью 𝜀, основываясь на ряде Тейлора:

<h3 align="center"><img src="https://github.com/norvdaw/TechPracticeWinForms/blob/main/images/Taylor.PNG" height="72"/></h3>

где 𝑎 = 0, 𝑏 = 1.5, ℎ = 0.15, e = 10<sup>-5</sup>. 

 Получить таким образом таблицу следующего вида:
 
<h3 align="left"><img src="https://github.com/norvdaw/TechPracticeWinForms/blob/main/images/TableTask1.PNG" height="72"/></h3>
 
 где 𝑥 = 𝑎 + 𝑖 * ℎ, 𝑖 = 0... 𝑛 - точки на отрезке [a, b] с шагом h;
𝑓<sub>𝑖</sub> = 𝐶(𝑥<sub>𝑖</sub>) - значение ряда Тейлора в заданных точках;
𝑘<sub>𝑖</sub> – число слагаемых в ряде Тейлора в точке 𝑥<sub>𝑖</sub> для достижения точности 𝜀.

Построить график функции по полученной таблице.

## Task 2v1.

По таблице из Task 1 значений построить интерполяционный полином Ньютона, приближающий 𝐶(𝑥):

<h3 align="center"><img src="https://github.com/norvdaw/TechPracticeWinForms/blob/main/images/Newton1.PNG" height="40"/></h3>

<h3 align="center"><img src="https://github.com/norvdaw/TechPracticeWinForms/blob/main/images/Newton2.PNG" height="32"/></h3>

вычислить погрешность интерполирования:

<h3 align="center"><img src="https://github.com/norvdaw/TechPracticeWinForms/blob/main/images/NewtonError.PNG" height="40"/></h3>

В качестве узлов интерполяции взять:

 1. Равномерно распределенные узлы 
 2. Корни полинома Чебышева
  
  Построить графики и таблицы значений для разного количества узлов интерполяции и
  погрешности для равномерно распределенной и Чебышевской сетки узлов интерполирования.

## Task 2v2

 Выявить зависимость максимальной погрешности интерполирования от
числа узлов интерполяции для равномерно распределенных узлов и корней
полинома Чебышева. Построить график и таблицу зависимости максимальной погрешности и количества узлов интерполяции.

## Task 3

В точках 𝑥𝑖 из приближенной таблицы значений Task 1
построить таблицу приближенных значений 𝐶(𝑥)

<h3 align="center"><img src="https://github.com/norvdaw/TechPracticeWinForms/blob/main/images/Task3Formula.PNG" height="72"/></h3>

Где 𝑧<sub>𝑖</sub> = 𝑐 + 𝑖ℎ𝑁 − точки разбиения отрезка интегрирования на N частей

𝐶(𝑥) вычислить с помощью:

- Составной квадратурной формулы левых прямоугольников:

<h3 align="left"><img src="https://github.com/norvdaw/TechPracticeWinForms/blob/main/images/Task3FormulaLeft.PNG" height="40"/></h3>

- Составной квадратурной формулы центральных прямоугольников:

<h3 align="left"><img src="https://github.com/norvdaw/TechPracticeWinForms/blob/main/images/Task3FormulaCenter.PNG" height="48"/></h3>

- Составной квадратурной формулы трапеции:

<h3 align="left"><img src="https://github.com/norvdaw/TechPracticeWinForms/blob/main/images/Task3FormulaTrapez.PNG" height="52"/></h3>

- Составной квадратурной формулы Симпсона:

<h3 align="left"><img src="https://github.com/norvdaw/TechPracticeWinForms/blob/main/images/Task3FormulaSimpson.PNG" height="68"/></h3>

- Составной квадратурной формулы Гаусса:

<h3 align="left"><img src="https://github.com/norvdaw/TechPracticeWinForms/blob/main/images/Task3FormulaGauss.PNG" height="68"/></h3>

Интеграл вычисляется с точностью 𝜀. Точность вычисления интеграла
определяется сравнением результатов при различном числе разбиения отрезка
интегрирования.

Вычислить погрешности, принимая за точное значение таблицу из Task 1.
Построить таблицы для 𝜀1 и 𝜀2 по каждой квадратурной
формуле для точек 𝑥<sub>𝑖</sub>  из Task 1.

