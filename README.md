# Unity.Globalization.Localization

[РУССКАЯ ВЕРСИЯ](README_RU.md)

# Description
Simple, but at the same time effective and optimized implementation of localization of the game via JSON files.

**Warning!** The translation language is specified at the moment of initialization and you CANNOT change the language later. I'm against changing the language dynamically. You can let the user select the language in the game settings and restart game, then the new language will be applied.

You can support me and my projects https://biba.dev/donation

**Key features:**
* uses a universal JSON format
* each language in a separate file (convenient for translation by different people)
* you can create any number of instances (e.g. translation of the interface, dialogs, subtitles, etc.)

# Installing
Warning! Newtonsoft.Json library is required (https://github.com/jilleJr/Newtonsoft.Json-for-Unity, installation tutorial https://biba.dev/en/tutorial-install-github-package-via-unity-package-manager)

* copy all files into the project folder `Assets`
* in the folder  `Resources/Localization/` you must have a folder `General` where each translation is in a separate file (e.g. en.json, ru.json)
* call the initialization (to be called BEFORE all, before the translation request), passing the current language (the name / language code must match the name of the translation file)
`Localization.Init("en"); // = en.json`

# Working principle
Calling `Localization.Init("en");` fills static data and creates a static instance of `Localization.General` which you can use anywhere in the project.

# JSON translation file format
```
{
  "key1": "Valueeeeeeeee e e ee e ee ee e e",
  "key2": "Valueeeeeeeee e e ee e ee ee e e 2",
  "key3": "Valueeeeeeeee e e ee e ee ee e e"3
}
```

# Using
* anywhere in the project, use `var value = Localization.General.Get("key");` to get the translation by key (from the General folder).
* to translate the component `UnityEngine.UI.Text` there is a class `TextLocalizer`, you can add it by selecting `GameObject` and clicking `Add Component -> BibaDev/Localization/TextLocalizer`, specify the key.
* you can additionally create a separate copy (by specifying a separate folder with translations)
```
private Localization _localization;

...

_localization = new Localization("Localization/Dialogs");
            
...  

_label.text = _localization.Get(dialog_key);
```

# Compatibility
Tested on Unity 2020.1.17
