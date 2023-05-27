using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HomeScene
{
    public class TextContentZHHK : TextContentBase
    {
        public TextContentZHHK()
        {
            #region Home Page

            homePage = new HomePage
            {
                oDEStartGameButton = new HomePage.ODEStartGameButton
                {
                    text001 = "�s���ȵ{",
                },
                oDEContinueGameButton = new HomePage.ODEContinueGameButton
                {
                    text001 = "�~��C��",
                },
                oDEGameSettingButton = new HomePage.ODEGameSettingButton
                {
                    text001 = "�C���ﶵ",
                },
                oDEQuitGameButton = new HomePage.ODEQuitGameButton
                {
                    text001 = "�h�X�C��",
                },
                oDESoloGameButton = new HomePage.ODESoloGameButton
                {
                    text001 = "��H�C��",
                },
                oDEMultiplayerGameButton = new HomePage.ODEMultiplayerGameButton
                {
                    text001 = "�h�H�C��",
                },
                oDEGameModeBackButton = new HomePage.ODEGameModeBackButton
                {
                    text001 = "��^",
                },
                oDENormalModeButton = new HomePage.ODENormalModeButton
                {
                    text001 = "���`�Ҧ�",
                },
                oDEHardModeButton = new HomePage.ODEHardModeButton
                {
                    text001 = "�x���Ҧ�",
                },
                oDELegendModeButton = new HomePage.ODELegendModeButton
                {
                    text001 = "�ǩ_�Ҧ�",
                },
                oDEDifficultyModeBackButton = new HomePage.ODEDifficultyModeBackButton
                {
                    text001 = "��^",
                },
            };

            #endregion

            /* ----- Scene Popup ----- */

            #region Load Game Popup

            loadGamePopup = new LoadGamePopup
            {
                uDETitle = new LoadGamePopup.UDETitle
                {
                    text001 = "Ū���s��",
                },
                oDESaveFileScrollViewSaveButton = new LoadGamePopup.ODESaveFileScrollViewSaveButton
                {
                    saveNameText001 = "{0}",
                    gameTimeHeaderText001 = "�ɶ�",
                    gameTimeContentText001 = "{0}",
                    saveDateHeaderText001 = "���",
                    saveDateContentText001 = "{0}",
                    gameVersionHeaderText001 = "����",
                    gameVersionContentText001 = "{0}",
                }
            };

            #endregion

            /* ----- Large Popup ----- */

            #region Normal Mode Popup

            normalModePopup = new GameManager.TextContentBase.LargePopup
            {
                uDETitle = new GameManager.TextContentBase.LargePopup.UDETitle
                {
                    text001 = "���q�Ҧ�",
                },
                uDEContent = new GameManager.TextContentBase.LargePopup.UDEContent
                {
                    text001 = "�A�T�w��ܴ��q�Ҧ��ܡH���Ҧ���²��A�A�X�Ĥ@���C��������@�������a�C\n�C���@���}�l�A�K������C",
                },
                oDEPrimaryButton = new GameManager.TextContentBase.LargePopup.ODEPrimaryButton
                {
                    contentText001 = "�T�w",
                },
                oDESecondaryButton = new GameManager.TextContentBase.LargePopup.ODESecondaryButton
                {
                    contentText001 = "����",
                },
            };

            #endregion

            #region Hard Mode Popup

            hardModePopup = new GameManager.TextContentBase.LargePopup
            {
                uDETitle = new GameManager.TextContentBase.LargePopup.UDETitle
                {
                    text001 = "�x���Ҧ�",
                },
                uDEContent = new GameManager.TextContentBase.LargePopup.UDEContent
                {
                    text001 = "�A�T�w��ܧx���Ҧ��ܡH���Ҧ����x���A�A�X���w�D�Ԫ����a�C\n�C���@���}�l�A�K������C",
                },
                oDEPrimaryButton = new GameManager.TextContentBase.LargePopup.ODEPrimaryButton
                {
                    contentText001 = "�T�w",
                },
                oDESecondaryButton = new GameManager.TextContentBase.LargePopup.ODESecondaryButton
                {
                    contentText001 = "����",
                },
            };       

            #endregion

            #region Legend Mode Popup

            legendModePopup = new GameManager.TextContentBase.LargePopup
            {
                uDETitle = new GameManager.TextContentBase.LargePopup.UDETitle
                {
                    text001 = "�ǩ_�Ҧ�",
                },
                uDEContent = new GameManager.TextContentBase.LargePopup.UDEContent
                {
                    text001 = "�A�T�w��ܶǩ_�Ҧ��ܡH���Ҧ����קx���A�u��֦��@�Ӧs�ɡC\n��Ҧ����⦺�`�ɡA�s�ɥ�|�����C\n�C���@���}�l�A�K������C",
                },
                oDEPrimaryButton = new GameManager.TextContentBase.LargePopup.ODEPrimaryButton
                {
                    contentText001 = "�T�w",
                },
                oDESecondaryButton = new GameManager.TextContentBase.LargePopup.ODESecondaryButton
                {
                    contentText001 = "����",
                },
            };

            #endregion

            /* ----- Middle Popup ----- */

            #region Delete Save Popup

            deleteSavePopup = new GameManager.TextContentBase.MiddlePopup
            {
                uDETitle = new GameManager.TextContentBase.MiddlePopup.UDETitle
                {
                    text001 = "�R���s��",
                },
                uDEContent = new GameManager.TextContentBase.MiddlePopup.UDEContent
                {
                    text001 = "�O�_�T�{�R���s�ɡH\n�@���R���A�N�L�k�_��I",
                },
                oDEPrimaryButton = new GameManager.TextContentBase.MiddlePopup.ODEPrimaryButton
                {
                    contentText001 = "�T�w",
                },
                oDESecondaryButton = new GameManager.TextContentBase.MiddlePopup.ODESecondaryButton
                {
                    contentText001 = "����",
                },
            };

            #endregion

            /* ----- Small Popup ----- */

            #region Quit Game Popup

            quitGamePopup = new GameManager.TextContentBase.SmallPopup
            {
                uDETitle = new GameManager.TextContentBase.SmallPopup.UDETitle
                {
                    text001 = "�T�w���}�C���H",
                },
                oDEPrimaryButton = new GameManager.TextContentBase.SmallPopup.ODEPrimaryButton
                {
                    contentText001 = "�T�w",
                },
                oDESecondaryButton = new GameManager.TextContentBase.SmallPopup.ODESecondaryButton
                {
                    contentText001 = "����",
                },
            };

            #endregion

            #region Coming Soon Popup

            comingSoonPopup = new GameManager.TextContentBase.SmallPopup
            {
                uDETitle = new GameManager.TextContentBase.SmallPopup.UDETitle
                {
                    text001 = "�|���}��I"
                },
                oDEPrimaryButton = new GameManager.TextContentBase.SmallPopup.ODEPrimaryButton
                {
                    contentText001 = "�T�w",
                },                
            };

            #endregion

        }
    }
}