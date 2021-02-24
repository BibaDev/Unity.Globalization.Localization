using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

/*
 * Created by BibaDev: (https://biba.dev)
 * Support me (donation): https://biba.dev/donation
 * Contact me: https://biba.dev/feedback
 * Follow me: https://twitter.com/BibaDev_
 * GitHub: https://github.com/BibaDev/Unity.Globalization.Localization
 */

namespace BibaDev.Globalization
{

    public class Localization
    {

        public static bool Initialized { get; private set; }
        public static string Language { get; private set; }
        public static Localization General { get; private set; }

        private readonly Dictionary<string, string> _table;

        public static void Init(string language, string generalPath = "Localization/General")
        {

            Language = language;
            Initialized = true;

            General = new Localization(generalPath);
            
        }
        
        public Localization(string path)
        {
            
            if (!Initialized)
                throw new NullReferenceException("Localization not initialized! Call Localization.Init");

            var asset = Resources.Load<TextAsset>(Path.Combine(path, Language));
            
            if (!asset)
                throw new FileNotFoundException($"Asset '{Path.Combine(path, Language)}' not found!");
            
            #if UNITY_EDITOR || TEST
                Debug.Log($"Localization loaded! Language: {Language}, path: {path}");
            #endif

            _table = JsonConvert.DeserializeObject<Dictionary<string, string>>(asset.text);

        }

        public string Get(in string key) 
            => _table.TryGetValue(key, out var value) ? value : $"{{{key}}}" ;
        
    }
    
}
