// This is written in C#

using System;
using System.IO;
using System.Reflection;
using ICities;
using UnityEngine;


namespace NoPurplePollution
{

    public class NoPurplePollutionMod : IUserMod 
    {

        public string Name 
        {
            get { return "No Purple Ground Pollution"; }
        }

        public string Description 
        {
            get { return "Removes the ugly discoloration that pollution adds to the ground."; }
        }
    }

  // Load extension
	public class PollutionChanger : LoadingExtensionBase
	{
		/*
		* When the level is loaded replace the existing value with the new one we assigned
		*/
		public override void OnLevelLoaded (LoadMode mode)
		{
            /* The value m_GrassPollutionColorOffset is accessed through a getter titled _GrassPollutionColorOffset */
            Shader.SetGlobalColor("_WaterColorDirty", new Vector4(0f, 0f, 0f));
            Shader.SetGlobalVector("_GrassPollutionColorOffset", new Vector4(0f, 0f, 0f));
		}
	}
}
