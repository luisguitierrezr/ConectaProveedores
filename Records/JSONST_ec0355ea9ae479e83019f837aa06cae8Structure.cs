using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EmailsNotifString
public class JSONST_ec0355ea9ae479e83019f837aa06cae8Structure : AbstractRESTStructure<ST_ec0355ea9ae479e83019f837aa06cae8Structure> {
[JsonProperty("Value")]
[JsonPropertyName("Value")]
public string AttrValue;

[JsonProperty("UserIds")]
[JsonPropertyName("UserIds")]
public string AttrUserIds;

public JSONST_ec0355ea9ae479e83019f837aa06cae8Structure() { }

public JSONST_ec0355ea9ae479e83019f837aa06cae8Structure (ST_ec0355ea9ae479e83019f837aa06cae8Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValue = ConvertToRestWithoutDefaults(s.ssValue, "");
AttrUserIds = ConvertToRestWithoutDefaults(s.ssUserIds, "");
  } else {
AttrValue = s.ssValue;
AttrUserIds = s.ssUserIds;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_ec0355ea9ae479e83019f837aa06cae8Structure, ST_ec0355ea9ae479e83019f837aa06cae8Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_ec0355ea9ae479e83019f837aa06cae8Structure s) => ToStructure(s, config);
}
public static ST_ec0355ea9ae479e83019f837aa06cae8Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_ec0355ea9ae479e83019f837aa06cae8Structure obj, IBehaviorsConfiguration config) { 
  ST_ec0355ea9ae479e83019f837aa06cae8Structure s = new ST_ec0355ea9ae479e83019f837aa06cae8Structure();
  if(obj != null) {
  s.ssValue = obj.AttrValue == null ? "" : obj.AttrValue;
  s.ssUserIds = obj.AttrUserIds == null ? "" : obj.AttrUserIds;
  }
  return s;
}

public static Func<ST_ec0355ea9ae479e83019f837aa06cae8Structure, ssConectaProveedores.RestRecords.JSONST_ec0355ea9ae479e83019f837aa06cae8Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ec0355ea9ae479e83019f837aa06cae8Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_ec0355ea9ae479e83019f837aa06cae8Structure FromStructure(ST_ec0355ea9ae479e83019f837aa06cae8Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_ec0355ea9ae479e83019f837aa06cae8Structure(s, config);
}

}


