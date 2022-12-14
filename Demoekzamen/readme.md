<h1>Лекции</h1>
<h2>UseCase</h2>
UML (англ. Unified Modeling Language — унифицированный язык моделирования) — язык графического описания для объектного моделирования в области разработки программного обеспечения, для моделирования бизнес-процессов, системного проектирования и отображения организационных структур.
UML является международным языком рисования схем.

Use case
![image](https://user-images.githubusercontent.com/39220694/188564290-416fd327-489f-4188-a20b-9d3805217473.png)
![image](https://user-images.githubusercontent.com/39220694/188564397-a07758bc-2e25-4d07-9390-d2df67624214.png)

Use case строится на анализе предметной области

Отношение - линия: сплошная и пунктирная
пунктирные: include - если без него нельзя выполнить основное действие, extend - дополнительное
Сплошная линия - ассоциация=использует - отражает возможность использования актером прецедента
![image](https://user-images.githubusercontent.com/39220694/188565367-7be3b074-368c-4dba-b9a2-d9c13b0f26f4.png)


<h2>ER - диаграммы</h2>
ER - entity relationship - сущность и связь <br> 
Концептуальные и физические диаграммы <br>
Концептуальная - visio<br>
Физические - отображаются типы данных, автоматическая, обязательность/необязательность полей, english<br>
*Отдельную таблицу со связью многие-ко-многим не создают<br>
НФ - нормальная форма:<br>
<table>
 <tr>
  <th>Модель</td><td>Марка</th>
 </tr>
  <tr>
     <td>BMW</td>
     <td>M5; M3</td>
  </tr>
  <tr>
     <td>Nissan</td>
     <td>Skyline R32 GT-R</td>
  </tr>
</table>
1НФ - одна ячейка - одно значение
Пример:
<table>
 <tr>
  <th>Модель</td><td>Марка</th>
 </tr>
 <tr>
    <td>BMW</td>
    <td>M5</td>
 </tr>
  <tr>
    <td>BMW</td>
    <td>M3</td>
 </tr>
 <tr>
    <td>Nissan</td>
    <td>Skyline R32 GT-R</td>
 </tr>
</table>

2НФ укорачиваем повротяющиеся элементы<br>
3НФ взаимосвязи столбцов. если не зависят - выносим в разные таблицы<br>
![image](https://user-images.githubusercontent.com/39220694/189847462-101a36f8-33bf-4a1a-8f04-38f7742343b2.png)
![image](https://user-images.githubusercontent.com/39220694/189849436-2a454724-715a-408f-8139-870fb3de6955.png)

![image](https://user-images.githubusercontent.com/39220694/189851195-7b0161c7-1561-4e52-81e1-2710eda1e81a.png)
![image](https://user-images.githubusercontent.com/39220694/189851696-85c2b19c-edc7-4957-83b8-4b4ddfce50a9.png)
![image](https://user-images.githubusercontent.com/39220694/189853031-a441041d-3b02-43c6-b8a4-ca06c028e8a5.png)
отключать если первичные ключи - паспортные данные

<h4>Создание базы данных</h4>
Создание скрипта:
<ol>
<li>Создать бд
<li>пкм - создать запрос
<li>вставить скрипт
<li>запустить
</ol>
![image](https://user-images.githubusercontent.com/39220694/189850302-7f019380-faee-487b-9201-85dd527ed30d.png)
![image](https://user-images.githubusercontent.com/39220694/189865658-f46f0b9d-a3ed-45fc-b32d-0a30fd37a0a5.png)

 
<h4>Связи:</h4>
один-ко-многим = внешний ключ. в таблице, в которой слово "один" ставится первичный ключ, ведем связь к столбцу таблицы "много" (В одной **стране** много **отелей**)<br>
многие-ко-многим = отдельная таблица с двумя первичными ключами (несколько книг нравятся нескольким людям)

<h4>Типы данных: </h4>
<ul>
<li> числовые:  int, char, varchar, nvarchar(255), money, varbinary(50)<br>
<li> логические:  bool<br>
<li> символьные: text<br>
<li> дата: date, datetime<br>
</ul>

![image](https://user-images.githubusercontent.com/39220694/189868313-2bd24f35-e698-412c-a163-1ef57b39e9b0.png)

Создавть новый файл excel, в котором разные листы - это данные для импорта, чтобы не испортить входные данные

Перевод в единое время:  
 1.разделить данные по столбцам, чтобы воспользоваться формулой перевода все в единое время
 ![image](https://user-images.githubusercontent.com/40539112/195325069-993e913f-0108-48aa-9597-aa7ed7039d08.png)
 <br>
 =ЕСЛИ(J2="минут";I2/60;I2) <br>
  Функция ВПР. Справа указываются ключи <br>
 ![image](https://user-images.githubusercontent.com/40539112/195328235-0172edfa-8920-456a-848c-3ce18f95c403.png)

![image](https://user-images.githubusercontent.com/40539112/195329692-f78609b0-6a1f-409b-b502-918b7085c763.png)
<br>
 =ВПР(G2;$N$2:$O$4;2;ЛОЖЬ)

</ol>

![image](https://user-images.githubusercontent.com/40539112/196673290-cca52eeb-566a-40c3-8d1b-024279767d8b.png)

![image](https://user-images.githubusercontent.com/40539112/196673926-bbb0ddc9-6bce-4f92-bc49-6fa6b5597dcd.png)

![image](https://user-images.githubusercontent.com/40539112/196679278-24920869-1633-4d81-bf8f-c22ef09a64b6.png)

![image](https://user-images.githubusercontent.com/40539112/196682702-9fa456ed-b4e9-43a2-ba68-f6bfbc66f3f7.png)


## программные решения для бизнеса esat
https://esat.worldskills.ru/competencies/dac59f20-134b-4aa4-94e5-518c488ccc9e/categories/d747aed4-5204-4ab4-a3f1-dec61f99735d
## подготовка
https://docs.google.com/document/d/17dkgRFIxEAdOvFsUuCD5TGeWHCqcC7U-Ha5MJ0EfdtI/edit#
![image](https://user-images.githubusercontent.com/39220694/188390968-a3e0d586-5bc2-4793-aa07-3dcd178ebf63.png)
```
Модуль 1: Анализ и проектирование требований, бизнеспроцессов - UML-диаграммы
Модуль 2: Проектирование реляционного хранилища данных - ER-модель БД
Модуль 3: Разработка баз данных, объектов баз данных и импорт - Создание таблиц, распределение полей int char. 
Модуль 4: Разработка desktop-приложений - WPF
Модуль 6: Создание инсталляторов - 
Модуль 7: Тестирование программных решений
```
```
Модуль 9: Общий профессионализм решения
  Возможность развития информационной системы другими разработчиками.
  Соответствие руководству по стилю заказчика
  Обратная связь системы с пользователем
  Стабильная работа всех разработанных программ
  Стиль кода на протяжении разработки всей системы
  Организация файловой структуры проекта
  Соблюдение культуры кодирования
  Комментарии к коду
  Умение работать с системой контроля версий.
  Умение работать с readme.md
```
локальный гит http://192.168.1.20:3000/
задания: https://github.com/Julia-Zhirnova/Demoekzamen
