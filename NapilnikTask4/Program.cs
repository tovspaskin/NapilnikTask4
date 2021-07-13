﻿namespace NapilnikTask4
{
    public enum Result
    {
        success,
        error,
    }

    internal class Program
    {
        private static void Main()
        {
            Pathfinder pathfinderFlie = new Pathfinder(new FileLogWritter());
            Pathfinder pathfinderConsole = new Pathfinder(new ConsoleLogWritter());

            ILogger loggerSecureFile = ChainOfLog.Create(new SecureConsoleLogWritter(), new FileLogWritter());
            Pathfinder pathfinderFlieOnFriday = new Pathfinder(loggerSecureFile);
            ILogger loggerSecureConsole = ChainOfLog.Create(new SecureConsoleLogWritter(), new ConsoleLogWritter());
            Pathfinder pathfinderConsoleOnFriday = new Pathfinder(loggerSecureConsole);
            ILogger loggerConsoleSecureFile = ChainOfLog.Create(new ConsoleLogWritter(), new SecureConsoleLogWritter(), new FileLogWritter());
            Pathfinder pathfinderConsoleAndFlieOnFriday = new Pathfinder(loggerConsoleSecureFile);
        }
    }
}

/*
 Есть такая реализация логирования - https://pastebin.com/7xL6S4vV

Защищённый логер даёт функционал, что логер пишется только по пятницам (такая условность).

Представьте класс Pathfinder у которого есть зависимость от условного ILogger, в процессе своей работы он что-то пишет в лог.
Что не принципиально. Сделайте в нём один метод Find который только пишет в лог через своего логера.

Перепроектируйте систему логирования так, что бы у меня было 5 объектов класса Pathfinder.
1) Пишет лог в файл.
2) Пишет лог в консоль.
3) Пишет лог в файл по пятницам.
4) Пишет лог в консоль по пятницам.
5) Пишет лог в консоль а по пятницам ещё и в файл.
 */
