using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// T_FAC_PAG_CAB_In
public class RESTST_828ac715d3b2e46c74367f017543eab1Structure : AbstractRESTStructure<ST_828ac715d3b2e46c74367f017543eab1Structure> {
[JsonProperty("KURSF")]
public decimal? AttrKURSF;

[JsonProperty("AUGBL")]
public string AttrAUGBL;

public RESTST_828ac715d3b2e46c74367f017543eab1Structure() { }

public RESTST_828ac715d3b2e46c74367f017543eab1Structure (ST_828ac715d3b2e46c74367f017543eab1Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrKURSF = ConvertToRestWithoutDefaults(s.ssKURSF, -79228162514264337593543950335m);
AttrAUGBL = ConvertToRestWithoutDefaults(s.ssAUGBL, "");
  } else {
AttrKURSF = (decimal?) s.ssKURSF;
AttrAUGBL = s.ssAUGBL;
  }
}

public static ST_828ac715d3b2e46c74367f017543eab1Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_828ac715d3b2e46c74367f017543eab1Structure obj) { 
  ST_828ac715d3b2e46c74367f017543eab1Structure s = new ST_828ac715d3b2e46c74367f017543eab1Structure();
  if(obj != null) {
  s.ssKURSF = obj.AttrKURSF == null ? -79228162514264337593543950335m : obj.AttrKURSF.Value;
  s.ssAUGBL = obj.AttrAUGBL == null ? "" : obj.AttrAUGBL;
  }
  return s;
}

public static Func<ST_828ac715d3b2e46c74367f017543eab1Structure, ssConectaProveedores.RestRecords.RESTST_828ac715d3b2e46c74367f017543eab1Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_828ac715d3b2e46c74367f017543eab1Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_828ac715d3b2e46c74367f017543eab1Structure FromStructure(ST_828ac715d3b2e46c74367f017543eab1Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_828ac715d3b2e46c74367f017543eab1Structure(s, config);
}

}


