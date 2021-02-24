using TMPro;
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
    
    [AddComponentMenu("BibaDev/Localization/TextMeshPro Localizer")]
    public class TextMeshProLocalizer : MonoBehaviour
    {

        [SerializeField] private string _key;
        [SerializeField] private TextMeshProUGUI _component;

        private void Start() => _component.text = Localization.General.Get(in _key);

#if UNITY_EDITOR
        private void OnValidate()
        {

            if (_component == null)
                _component = GetComponent<TextMeshProUGUI>();
            
        }
#endif
        
    }
    
}

