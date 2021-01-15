# Unity.Globalization.Localization

# Описание
Простая, но в то же время эффективная и оптимизированная реализация локализации игры через JSON файлы.

**Ключевые особенности:**
* используется универсальный формат JSON
* каждый язык в отдельном файле (удобно для перевода разными людьми)
* возможность создавать любое количество экземпляров (например перевод интерфейса, перевод диалогов, субтитров и т.д)

# Установка
Внимание! Необходима библиотека Newtonsoft.Json (https://github.com/jilleJr/Newtonsoft.Json-for-Unity, инструкция установки https://biba.dev/ru/tutorial-install-github-package-via-unity-package-manager)

* скопируйте все файлы в папку проекта (Assets)
* в папке `Resources/Localization/` у вас должна быть папка `General` в которой каждый перевод в отдельном файле (например en.json, ru.json)
* вызовите инициализацию (должна быть вызвана РАНЬШЕ всех, до запроса перевода), передав текущий язык (наименование / код языка должено сооствествовать имени файла перевода)
`Localization.Init("en"); // = en.json`

# Принцип работы
При вызове `Localization.Init("en");` заполняются статические данные и создается статический экземпляр `Localization.General` который вы можете использовать в любом месте проекта.

# Формат файла перевода JSON
```
{
  "key1": "Valueeeeeeeee e e ee e ee ee e e",
  "key2": "Valueeeeeeeee e e ee e ee ee e e 2",
  "key3": "Valueeeeeeeee e e ee e ee ee e e"3
}
```

# Использование
* в любом месте проекта для получения перевода по ключу (из папки General) используйте `var value = Localization.General.Get("key");`
* вы можете создать дополнительно отдельный экземпляр (указав отдельную папку с переводами)
```
private static Localization _localization;

...

_localization = new Localization("Localization/Dialogs");
            
...  

_label.text = _localization.Get(dialog_key);
```
