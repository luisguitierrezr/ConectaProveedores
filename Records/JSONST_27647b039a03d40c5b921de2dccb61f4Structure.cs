using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// T_FAC_PAG_CAB_Out
public class JSONST_27647b039a03d40c5b921de2dccb61f4Structure : AbstractRESTStructure<ST_27647b039a03d40c5b921de2dccb61f4Structure> {
[JsonProperty("KURSF")]
[JsonPropertyName("KURSF")]
public decimal? AttrKURSF;

[JsonProperty("AUGBL")]
[JsonPropertyName("AUGBL")]
public string AttrAUGBL;

public JSONST_27647b039a03d40c5b921de2dccb61f4Structure() { }

public JSONST_27647b039a03d40c5b921de2dccb61f4Structure (ST_27647b039a03d40c5b921de2dccb61f4Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrKURSF = ConvertToRestWithoutDefaults(s.ssKURSF, -79228162514264337593543950335m);
AttrAUGBL = ConvertToRestWithoutDefaults(s.ssAUGBL, "");
  } else {
AttrKURSF = (decimal?) s.ssKURSF;
AttrAUGBL = s.ssAUGBL;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_27647b039a03d40c5b921de2dccb61f4Structure, ST_27647b039a03d40c5b921de2dccb61f4Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_27647b039a03d40c5b921de2dccb61f4Structure s) => ToStructure(s, config);
}
public static ST_27647b039a03d40c5b921de2dccb61f4Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_27647b039a03d40c5b921de2dccb61f4Structure obj, IBehaviorsConfiguration config) { 
  ST_27647b039a03d40c5b921de2dccb61f4Structure s = new ST_27647b039a03d40c5b921de2dccb61f4Structure();
  if(obj != null) {
  s.ssKURSF = obj.AttrKURSF == null ? -79228162514264337593543950335m : obj.AttrKURSF.Value;
  s.ssAUGBL = obj.AttrAUGBL == null ? "" : obj.AttrAUGBL;
  }
  return s;
}

public static Func<ST_27647b039a03d40c5b921de2dccb61f4Structure, ssConectaProveedores.RestRecords.JSONST_27647b039a03d40c5b921de2dccb61f4Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_27647b039a03d40c5b921de2dccb61f4Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_27647b039a03d40c5b921de2dccb61f4Structure FromStructure(ST_27647b039a03d40c5b921de2dccb61f4Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_27647b039a03d40c5b921de2dccb61f4Structure(s, config);
}

}


