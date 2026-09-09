using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioAccDataRecord
public class RESTRC_6acf2565530fd56605391a00cf9e3b1e : AbstractRESTStructure<RC_6acf2565530fd56605391a00cf9e3b1e> {
[JsonProperty("FolioAccData")]
public ssConectaProveedores.RestRecords.RESTST_6dc39d329f4b959722daa75bc2f62c1fStructure AttrFolioAccData;

public RESTRC_6acf2565530fd56605391a00cf9e3b1e() { }

public RESTRC_6acf2565530fd56605391a00cf9e3b1e (RC_6acf2565530fd56605391a00cf9e3b1e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioAccData = ConvertToRestWithoutDefaults(s.ssSTFolioAccData, new ST_6dc39d329f4b959722daa75bc2f62c1fStructure(), ssConectaProveedores.RestRecords.RESTST_6dc39d329f4b959722daa75bc2f62c1fStructure.FromStructure, config);
  } else {
AttrFolioAccData = ssConectaProveedores.RestRecords.RESTST_6dc39d329f4b959722daa75bc2f62c1fStructure.FromStructure(s.ssSTFolioAccData, config);
  }
}

public static RC_6acf2565530fd56605391a00cf9e3b1e ToStructure(ssConectaProveedores.RestRecords.RESTRC_6acf2565530fd56605391a00cf9e3b1e obj) { 
  RC_6acf2565530fd56605391a00cf9e3b1e s = new RC_6acf2565530fd56605391a00cf9e3b1e();
  if(obj != null) {
  s.ssSTFolioAccData = ssConectaProveedores.RestRecords.RESTST_6dc39d329f4b959722daa75bc2f62c1fStructure.ToStructure(obj.AttrFolioAccData);
  }
  return s;
}

public static Func<RC_6acf2565530fd56605391a00cf9e3b1e, ssConectaProveedores.RestRecords.RESTRC_6acf2565530fd56605391a00cf9e3b1e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6acf2565530fd56605391a00cf9e3b1e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_6acf2565530fd56605391a00cf9e3b1e FromStructure(RC_6acf2565530fd56605391a00cf9e3b1e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_6acf2565530fd56605391a00cf9e3b1e(s, config);
}

}


