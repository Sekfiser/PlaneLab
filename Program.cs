//Запуск приложения, создание самолёта
Plane plane = new Plane();

plane.NewDestination("Paris"); //Задаём пункт назначения
plane.CurrentDestination(); //Получаем пункт назначения
plane.NewDestination("Moscow"); //Задаём пункт назначения
plane.PrintDestinations(); //Получаем все пункты назначения
plane.Fly(); //Летим в пункт назначения
plane.CurrentDestination(); //Получаем пункт назначения