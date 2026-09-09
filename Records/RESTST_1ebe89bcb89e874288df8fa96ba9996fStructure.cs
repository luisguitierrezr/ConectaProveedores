using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// LINES
public class RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure : AbstractRESTStructure<ST_1ebe89bcb89e874288df8fa96ba9996fStructure> {
[JsonProperty("TDFORMAT")]
public string AttrTDFORMAT;

[JsonProperty("TDLINE")]
public string AttrTDLINE;

public RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure() { }

public RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure (ST_1ebe89bcb89e874288df8fa96ba9996fStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTDFORMAT = ConvertToRestWithoutDefaults(s.ssTDFORMAT, "");
AttrTDLINE = ConvertToRestWithoutDefaults(s.ssTDLINE, "");
  } else {
AttrTDFORMAT = s.ssTDFORMAT;
AttrTDLINE = s.ssTDLINE;
  }
}

public static ST_1ebe89bcb89e874288df8fa96ba9996fStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure obj) { 
  ST_1ebe89bcb89e874288df8fa96ba9996fStructure s = new ST_1ebe89bcb89e874288df8fa96ba9996fStructure();
  if(obj != null) {
  s.ssTDFORMAT = obj.AttrTDFORMAT == null ? "" : obj.AttrTDFORMAT;
  s.ssTDLINE = obj.AttrTDLINE == null ? "" : obj.AttrTDLINE;
  }
  return s;
}

public static Func<ST_1ebe89bcb89e874288df8fa96ba9996fStructure, ssConectaProveedores.RestRecords.RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1ebe89bcb89e874288df8fa96ba9996fStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure FromStructure(ST_1ebe89bcb89e874288df8fa96ba9996fStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_1ebe89bcb89e874288df8fa96ba9996fStructure(s, config);
}

}


