using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ErrorMessage
public class RESTST_b7d405ca4407e572da091e54d07e3bd1Structure : AbstractRESTStructure<ST_b7d405ca4407e572da091e54d07e3bd1Structure> {
[JsonProperty("Code")]
public string AttrCode;

[JsonProperty("Message")]
public string AttrMessage;

public RESTST_b7d405ca4407e572da091e54d07e3bd1Structure() { }

public RESTST_b7d405ca4407e572da091e54d07e3bd1Structure (ST_b7d405ca4407e572da091e54d07e3bd1Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, "");
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
  } else {
AttrCode = s.ssCode;
AttrMessage = s.ssMessage;
  }
}

public static ST_b7d405ca4407e572da091e54d07e3bd1Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_b7d405ca4407e572da091e54d07e3bd1Structure obj) { 
  ST_b7d405ca4407e572da091e54d07e3bd1Structure s = new ST_b7d405ca4407e572da091e54d07e3bd1Structure();
  if(obj != null) {
  s.ssCode = obj.AttrCode == null ? "" : obj.AttrCode;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  }
  return s;
}

public static Func<ST_b7d405ca4407e572da091e54d07e3bd1Structure, ssConectaProveedores.RestRecords.RESTST_b7d405ca4407e572da091e54d07e3bd1Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b7d405ca4407e572da091e54d07e3bd1Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_b7d405ca4407e572da091e54d07e3bd1Structure FromStructure(ST_b7d405ca4407e572da091e54d07e3bd1Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_b7d405ca4407e572da091e54d07e3bd1Structure(s, config);
}

}


