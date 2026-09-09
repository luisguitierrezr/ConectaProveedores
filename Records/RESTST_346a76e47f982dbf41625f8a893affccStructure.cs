using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Output2
public class RESTST_346a76e47f982dbf41625f8a893affccStructure : AbstractRESTStructure<ST_346a76e47f982dbf41625f8a893affccStructure> {
[JsonProperty("IsSuccess")]
public bool? AttrIsSuccess;

[JsonProperty("Message")]
public string AttrMessage;

public RESTST_346a76e47f982dbf41625f8a893affccStructure() { }

public RESTST_346a76e47f982dbf41625f8a893affccStructure (ST_346a76e47f982dbf41625f8a893affccStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIsSuccess = ConvertToRestWithoutDefaults(s.ssIsSuccess, false);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrIsSuccess = (bool?) s.ssIsSuccess;
AttrMessage = s.ssMessage;
  }
}

public static ST_346a76e47f982dbf41625f8a893affccStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_346a76e47f982dbf41625f8a893affccStructure obj) { 
  ST_346a76e47f982dbf41625f8a893affccStructure s = new ST_346a76e47f982dbf41625f8a893affccStructure();
  if(obj != null) {
  s.ssIsSuccess = obj.AttrIsSuccess == null ? false : obj.AttrIsSuccess.Value;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<ST_346a76e47f982dbf41625f8a893affccStructure, ssConectaProveedores.RestRecords.RESTST_346a76e47f982dbf41625f8a893affccStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_346a76e47f982dbf41625f8a893affccStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_346a76e47f982dbf41625f8a893affccStructure FromStructure(ST_346a76e47f982dbf41625f8a893affccStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_346a76e47f982dbf41625f8a893affccStructure(s, config);
}

}


