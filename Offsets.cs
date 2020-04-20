using System;
using System.Collections.Generic;
using System.Text;

namespace Assault_Cube_Hack
{
    class Offsets
    {
        //local player
        public Int32 baseAddress = 0x400000;
        public Int32 offsetLocalPlayer = 0x10F4F4;
        public Int32 localPlayer;

        public UInt16 m_XPos = 0x0038;
        public UInt16 m_YPos = 0x003C;
        public UInt16 m_ZPos = 0x0040;

        public UInt16 m_isPosMoving = 0x0070;
        public UInt16 m_Speed = 0x0080;
        public UInt16 m_Health = 0x00F8;
        public UInt16 m_Vest = 0x00FC;
        public UInt16 m_AmmoMags = 0x0128;
        public UInt16 m_Ammo = 0x0150;
        public UInt16 m_SecAmmo = 0x013C;
        public UInt16 m_Flashbangs = 0x0158;
        public UInt16 m_WeaponTimer = 0x0178;
        public UInt16 m_ShotsFired = 0x01A0;

        //visuals
        public Int32 sv_GetMode = 0x50F49C;
        public Int32 sv_ClientNumber = 0x510198;
        public Int32 sv_name = 0x51019C;
        public Int32 p_MaxRoll = 0x510144;
        public Int32 p_AutoReload = 0x5101D0;
        public Int32 o_Paused = 0x510CE0;
        public Int32 o_GameSpeed = 0x510CDC;
        public Int32 m_MouseShotSensitivity = 0x4EE444; //CHANGE THIS TO 0 FOR NO RECOIL 
        public Int32 m_InvertMouse = 0x51016C;
        public Int32 h_ToggleConsole = 0x4FEC10;
        public Int32 h_ShowTarget = 0x50F284;
        public Int32 h_ShowSpeed = 0x50F288;
        public Int32 h_ShowScoreOnDeath = 0x50F514;
        public Int32 h_ShowRadarValues = 0x50F268;
        public Int32 h_ShowMap = 0x50F240;
        public Int32 h_Righthanded = 0x510A4C;
        public Int32 h_RadarHeight = 0x50F264;
        public Int32 h_RadarEntSize = 0x50F208;
        public Int32 h_OldAmmoHUD = 0x510A48;
        public Int32 h_HideRadar = 0x50F21C;
        public Int32 h_HideHudMessages = 0x50F230;
        public Int32 h_HideHudEquipment = 0x50F234;
        public Int32 h_HideDamageIndicator = 0x50F248;
        public Int32 h_HideCompass = 0x50F220;
        public Int32 h_DrawGun = 0x50F200;
        public Int32 h_DrawFPS = 0x50F210;
        public Int32 h_DbgPos = 0x50F280;
        public Int32 h_DamageScreenFade = 0x50F278;
        public Int32 h_DamageScreenFactor = 0x50F270;
        public Int32 h_DamageScreenAlpha = 0x50F274;
        public Int32 h_DamageScreen = 0x50F26C;
        public Int32 h_CrosshairSize = 0x50F20C;
        public Int32 g_GameVersion = 0x510CF4;
        public Int32 dbg_FlySpeed = 0x510148;
        public Int32 EngineState_Test = 0x509BD8;


        public Offsets()
        {
            localPlayer = baseAddress + offsetLocalPlayer;
        }

    }
}
