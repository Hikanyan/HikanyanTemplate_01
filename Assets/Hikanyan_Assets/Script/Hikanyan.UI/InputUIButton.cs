using System;
using DG.Tweening;  
using UnityEngine;  
using UnityEngine.EventSystems;  
namespace Hikanyan.UI
{
    public class InputUIButton : MonoBehaviour,IPointerEnterHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler  
    {
        public Action onClickCallback;  
        private CanvasGroup _canvasGroup;

        private void Start()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
        }

        public void OnPointerClick(PointerEventData eventData)  
        {
            onClickCallback?.Invoke();  
        }

        public void OnPointerDown(PointerEventData eventData)  
        {
            transform.DOScale(0.95f, 0.24f).SetEase(Ease.OutCubic);  
            _canvasGroup.DOFade(0.8f, 0.24f).SetEase(Ease.OutCubic);  
        }

        public void OnPointerUp(PointerEventData eventData)  
        {
            transform.DOScale(1f, 0.24f).SetEase(Ease.OutCubic);  
            _canvasGroup.DOFade(1f, 0.24f).SetEase(Ease.OutCubic);  
        }
        // マウスが侵入した時
        public void OnPointerEnter(PointerEventData eventData) {
            Debug.Log ("マウスが侵入");
        }
    }
}