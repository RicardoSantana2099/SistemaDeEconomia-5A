using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class CharacterItemUI : MonoBehaviour
{
    [SerializeField] Color itemNotSelectedColor;
    [SerializeField] Color itemSelectedColor;

    [Space(20f)]
    [SerializeField] Image characterImage;//Para tener referencia a la imagen del personaje.
    [SerializeField] TMP_Text characterNameText;//Para tener referencia al nombre del personaje.
    [SerializeField] Image characterSpeedFill;//Para tener referencia a la velocidad.
    [SerializeField] Image characterPowerFill;//Para tener referencia al poder.
    [SerializeField] TMP_Text characterPriceText;//Para tener referencia al precio.
    [SerializeField] Button characterPurchaseButton;//Para tener la referencia al boton de compra.

    [Space(20f)]
    [SerializeField] Button itemButton;//Para tener referencia del boton de compra.
    [SerializeField] Image itemImage;
    [SerializeField] Outline itemOutline;

    public void SetItemPosition(Vector2 pos)
    {
        GetComponent<RectTransform>().anchoredPosition += pos;

    }

    public void SetCharacterImage(Sprite sprite)
    {
        characterImage.sprite = sprite;
    }

    public void SetCharacterName(string Name)
    {
        characterNameText.text = name;
    }

    public void SetCharacterSpeed(float speed)
    {
        characterSpeedFill.fillAmount = speed / 100;
    }

    public void SetCharacterPower(float power)
    {
        characterPowerFill.fillAmount = power / 100;
    }

    public void SetCharacterPrice(int price)
    {
        characterPriceText.text = price.ToString();
    }

    public void SetCharacterAsPurchased()
    {
        characterPurchaseButton.gameObject.SetActive(false);
        itemButton.interactable = true;
        itemImage.color = itemNotSelectedColor;
    }

    public void OnItemPurchase(int itemIndex, UnityAction<int> action)
    {
        characterPurchaseButton.onClick.RemoveAllListeners();
        characterPurchaseButton.onClick.AddListener(() => action.Invoke(itemIndex));
    }

    public void OnItemSelect(int itemIndex, UnityAction<int> action)
    {
        itemButton.interactable = true;
        itemButton.onClick.RemoveAllListeners();
        itemButton.onClick.AddListener(() => action.Invoke(itemIndex));
    } 

    public void SelectItem()
    {
        itemOutline.enabled = true;
        itemImage.color = itemSelectedColor;
        itemButton.interactable = false;
    }

    public void DeselectItem()
    {
        itemOutline.enabled = false;
        itemImage.color = itemNotSelectedColor;
        itemButton.interactable = true;
    }
}
