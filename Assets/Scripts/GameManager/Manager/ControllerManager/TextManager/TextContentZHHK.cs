using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameManager
{
    public class TextContentZHHK : TextContentBase
    {
        public TextContentZHHK()
        {
            #region Loading Popup

            loadingPopup = new LoadingPopup
            {
                uDETitle = new LoadingPopup.UDETitle
                {
                    text001 = "�[����"
                },
            };

            #endregion

            #region Game Setting Popup

            gameSettingPopup = new GameSettingPopup
            {
                uDETitle = new GameSettingPopup.UDETitle
                {
                    text001 = "�t�γ]�m",
                },
                oDEBasicSettingHeader = new GameSettingPopup.ODEBasicSettingHeader
                {
                    text001 = "��¦�]�m",
                },
                oDEWindowSize = new GameSettingPopup.ODEWindowSize
                {
                    headerText001 = "�����ؤo�G",
                },
                oDEIsFullScreen = new GameSettingPopup.ODEIsFullScreen
                {
                    headerText001 = "������ܡG",
                },
                oDEMusicVolume = new GameSettingPopup.ODEMusicVolume
                {
                    headerText001 = "���֭��q�G",
                    sliderFillAreaFillText001 = "{0}%",
                },
                oDESFXVolume = new GameSettingPopup.ODESFXVolume
                {
                    headerText001 = "���ĭ��q�G",
                    sliderFillAreaFillText001 = "{0}%",
                },
            };

            #endregion

            /* ----- Middle Popup ----- */

            #region Restore Setting Popup

            restoreSettingPopup = new MiddlePopup
            {
                uDETitle = new MiddlePopup.UDETitle
                {
                    text001 = "��_�q�{",
                },
                uDEContent = new MiddlePopup.UDEContent
                {
                    text001 = "�O�_��_�q�{��¦�]�m�H",
                },
                oDEPrimaryButton = new MiddlePopup.ODEPrimaryButton
                {
                    contentText001 = "�T�w",
                },
                oDESecondaryButton = new MiddlePopup.ODESecondaryButton
                {
                    contentText001 = "����",
                },
            };

            #endregion

            indexToWindowSizeDictionary = new Dictionary<int, string>
            {
                { 0, "2560 x 1440" },
                { 1, "1920 x 1080" },
                { 2, "1600 x 900" },
                { 3, "1360 x 768" },
                { 4, "1280 x 720" },
            };

        }
    }
}