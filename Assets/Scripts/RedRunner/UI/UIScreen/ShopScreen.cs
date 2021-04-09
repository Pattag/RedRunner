using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RedRunner.UI
{
    public class ShopScreen : UIScreen
    {
        [SerializeField]
        protected Button ShopButton = null;

        private void Start()
        {
            ShopButton.SetButtonAction(() =>
            {
                var shopScreen = UIManager.Singleton.UISCREENS.Find(el => el.ScreenInfo == UIScreenInfo.SHOP_SCREEN);
                UIManager.Singleton.OpenScreen(shopScreen);
            });
        }

        public override void UpdateScreenStatus(bool open)
        {
            base.UpdateScreenStatus(open);
        }
    }
}
