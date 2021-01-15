using UnityEngine;
using UnityEngine.UI;

/*
 * Created by BibaDev: (https://biba.dev)
 * Support me (donation): https://biba.dev/donation
 * Contact me: https://biba.dev/feedback
 * GitHub: https://github.com/BibaDev/Unity.Globalization.Localization
 */

namespace BibaDev.Globalization
{
    
    [AddComponentMenu("BibaDev/Globalization/TextLocalizer")]
    public class TextLocalizer : MonoBehaviour
    {

        [SerializeField] private string _key;
        [SerializeField] private Text _component;

        private void Start() => _component.text = Localization.General.Get(in _key);

#if UNITY_EDITOR
        private void OnValidate()
        {

            if (_component == null)
                _component = GetComponent<Text>();
            
        }
#endif
        
    }

}
