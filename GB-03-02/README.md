Добавить метод в контроллер агентов проекта менеджера метрик позволяющий получить список зарегистрированных в системе объектов.
В проект агента сбора метрик добавить контроллеры для сбора метрик, аналогичные менеджеру сбора метрик.
Добавить методы для получения метрик с агента, доступные по следующим путям
api/metrics/cpu/from/{fromTime}/to/{toTime}
api/metrics/dotnet/errors-count/from/{fromTime}/to/{toTime}
api/metrics/network/from/{fromTime}/to/{toTime}
api/metrics/hdd/left/from/{fromTime}/to/{toTime}
api/metrics/ram/available/from/{fromTime}/to/{toTime}

Добавить проект с тестами для агента сбора метрик. Написать простые юнит-тесты на каждый метод каждого контроллера в обоих тестовых проектах. 
