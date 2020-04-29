using System;
using System.Collections.Generic;
using System.Text;

namespace Assault_Cube_Hack
{
    class Offsets
    {
        //local player
        //this 2 make the base
        public Int32 baseAddress { get; }
        public Int32 offsetLocalPlayer  {get;}
        public Int32 localPlayer { get; set; }

        public Int32 m_XPos  {get;}
        public Int32 m_YPos  {get;}
        public Int32 m_ZPos  {get;}

        public Int32 m_isPosMoving  {get;}
        public Int32 m_Speed  {get;}
        public Int32 m_Health  {get;}
        public Int32 m_Vest  {get;}
        public Int32 m_AmmoMags  {get;}
        public Int32 m_Ammo  {get;}
        public Int32 m_SecAmmo  {get;}
        public Int32 m_Flashbangs  {get;}
        public Int32 m_WeaponTimer  {get;}
        public Int32 m_ShotsFired  {get;}

        //visuals
        public Int32 sv_GetMode  {get;}
        public Int32 sv_ClientNumber  {get;}
        public Int32 sv_name  {get;}
        public Int32 p_MaxRoll  {get;}
        public Int32 p_AutoReload  {get;}
        public Int32 o_Paused  {get;}
        public Int32 o_GameSpeed   {get;}
        public Int32 m_MouseShotSensitivity  {get;}
        public Int32 m_InvertMouse  {get;}
        public Int32 h_ToggleConsole  {get;}
        public Int32 h_ShowTarget  {get;}
        public Int32 h_ShowSpeed  {get;}
        public Int32 h_ShowScoreOnDeath  {get;}
        public Int32 h_ShowRadarValues  {get;}
        public Int32 h_ShowMap  {get;}
        public Int32 h_Righthanded  {get;}
        public Int32 h_RadarHeight  {get;}
        public Int32 h_RadarEntSize  {get;}
        public Int32 h_OldAmmoHUD  {get;}
        public Int32 h_HideRadar  {get;}
        public Int32 h_HideHudMessages  {get;}
        public Int32 h_HideHudEquipment  {get;}
        public Int32 h_HideDamageIndicator  {get;}
        public Int32 h_HideCompass  {get;}
        public Int32 h_DrawGun  {get;}
        public Int32 h_DrawFPS  {get;}
        public Int32 h_DbgPos  {get;}
        public Int32 h_DamageScreenFade  {get;}
        public Int32 h_DamageScreenFactor  {get;}
        public Int32 h_DamageScreenAlpha  {get;}
        public Int32 h_DamageScreen  {get;}
        public Int32 h_CrosshairSize  {get;}
        public Int32 g_GameVersion  {get;}
        public Int32 dbg_FlySpeed  {get;}
        public Int32 EngineState_Test  {get;}


        public Offsets()
        {
            baseAddress = 0x400000;
            offsetLocalPlayer = 0x10F4F4;
            localPlayer = 0;

            m_XPos = 0x38;
            m_YPos = 0x3C;
            m_ZPos = 0x40;

            m_isPosMoving = 0x70;
            m_Speed = 0x80;
            m_Health = 0xF8;
            m_Vest = 0xFC;
            m_AmmoMags = 0x128;
            m_Ammo = 0x150;
            m_SecAmmo = 0x13C;
            m_Flashbangs = 0x158;
            m_WeaponTimer = 0x178;
            m_ShotsFired = 0x1A0;


            sv_GetMode = 0x50F49C;
            sv_ClientNumber = 0x510198;
            sv_name = 0x51019C;
            p_MaxRoll = 0x510144;
            p_AutoReload = 0x5101D0;
            o_Paused = 0x510CE0;
            o_GameSpeed = 0x510CDC;
            m_MouseShotSensitivity = 0x4EE444;
            m_InvertMouse = 0x51016C;
            h_ToggleConsole = 0x4FEC10;
            h_ShowTarget = 0x50F284;
            h_ShowSpeed = 0x50F288;
            h_ShowScoreOnDeath = 0x50F514;
            h_ShowRadarValues = 0x50F268;
            h_ShowMap = 0x50F240;
            h_Righthanded = 0x510A4C;
            h_RadarHeight = 0x50F264;
            h_RadarEntSize = 0x50F208;
            h_OldAmmoHUD = 0x510A48;
            h_HideRadar = 0x50F21C;
            h_HideHudMessages = 0x50F230;
            h_HideHudEquipment = 0x50F234;
            h_HideDamageIndicator = 0x50F248;
            h_HideCompass = 0x50F220;
            h_DrawGun = 0x50F200;
            h_DrawFPS = 0x50F210;
            h_DbgPos = 0x50F280;
            h_DamageScreenFade = 0x50F278;
            h_DamageScreenFactor = 0x50F270;
            h_DamageScreenAlpha = 0x50F274;
            h_DamageScreen = 0x50F26C;
            h_CrosshairSize = 0x50F20C;
            g_GameVersion = 0x510CF4;
            dbg_FlySpeed = 0x510148;
            EngineState_Test = 0x509BD8;
        }
    }
}
