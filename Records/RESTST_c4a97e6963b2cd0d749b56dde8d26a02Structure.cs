using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Z01_READ_TEXTReq
public class RESTST_c4a97e6963b2cd0d749b56dde8d26a02Structure : AbstractRESTStructure<ST_c4a97e6963b2cd0d749b56dde8d26a02Structure> {
[JsonProperty("ID")]
public string AttrID;

[JsonProperty("NAME")]
public string AttrNAME;

[JsonProperty("OBJECT")]
public string AttrOBJECT;

public RESTST_c4a97e6963b2cd0d749b56dde8d26a02Structure() { }

public RESTST_c4a97e6963b2cd0d749b56dde8d26a02Structure (ST_c4a97e6963b2cd0d749b56dde8d26a02Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrID = s.ssID;
AttrNAME = s.ssNAME;
AttrOBJECT = s.ssOBJECT;
  } else {
AttrID = s.ssID;
AttrNAME = s.ssNAME;
AttrOBJECT = s.ssOBJECT;
  }
}

public static ST_c4a97e6963b2cd0d749b56dde8d26a02Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_c4a97e6963b2cd0d749b56dde8d26a02Structure obj) { 
  ST_c4a97e6963b2cd0d749b56dde8d26a02Structure s = new ST_c4a97e6963b2cd0d749b56dde8d26a02Structure();
  if(obj != null) {
  s.ssID = obj.AttrID == null ? "" : obj.AttrID;
  s.ssNAME = obj.AttrNAME == null ? "" : obj.AttrNAME;
  s.ssOBJECT = obj.AttrOBJECT == null ? "" : obj.AttrOBJECT;
  }
  return s;
}

public static Func<ST_c4a97e6963b2cd0d749b56dde8d26a02Structure, ssConectaProveedores.RestRecords.RESTST_c4a97e6963b2cd0d749b56dde8d26a02Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_c4a97e6963b2cd0d749b56dde8d26a02Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_c4a97e6963b2cd0d749b56dde8d26a02Structure FromStructure(ST_c4a97e6963b2cd0d749b56dde8d26a02Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_c4a97e6963b2cd0d749b56dde8d26a02Structure(s, config);
}

}


