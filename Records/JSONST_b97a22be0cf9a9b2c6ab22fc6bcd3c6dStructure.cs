using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EmailNotifTesoraria
public class JSONST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure : AbstractRESTStructure<ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure> {
[JsonProperty("ApprovedCount")]
[JsonPropertyName("ApprovedCount")]
public int? AttrApprovedCount;

[JsonProperty("ApprovedNames")]
[JsonPropertyName("ApprovedNames")]
public string AttrApprovedNames;

[JsonProperty("BeingPaidCount")]
[JsonPropertyName("BeingPaidCount")]
public int? AttrBeingPaidCount;

[JsonProperty("BeingPaidNames")]
[JsonPropertyName("BeingPaidNames")]
public string AttrBeingPaidNames;

public JSONST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure() { }

public JSONST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure (ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovedCount = ConvertToRestWithoutDefaults(s.ssApprovedCount, 0);
AttrApprovedNames = ConvertToRestWithoutDefaults(s.ssApprovedNames, "");
AttrBeingPaidCount = ConvertToRestWithoutDefaults(s.ssBeingPaidCount, 0);
AttrBeingPaidNames = ConvertToRestWithoutDefaults(s.ssBeingPaidNames, "");
  } else {
AttrApprovedCount = (int?) s.ssApprovedCount;
AttrApprovedNames = s.ssApprovedNames;
AttrBeingPaidCount = (int?) s.ssBeingPaidCount;
AttrBeingPaidNames = s.ssBeingPaidNames;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure, ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure s) => ToStructure(s, config);
}
public static ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure obj, IBehaviorsConfiguration config) { 
  ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure s = new ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure();
  if(obj != null) {
  s.ssApprovedCount = obj.AttrApprovedCount == null ? 0 : obj.AttrApprovedCount.Value;
  s.ssApprovedNames = obj.AttrApprovedNames == null ? "" : obj.AttrApprovedNames;
  s.ssBeingPaidCount = obj.AttrBeingPaidCount == null ? 0 : obj.AttrBeingPaidCount.Value;
  s.ssBeingPaidNames = obj.AttrBeingPaidNames == null ? "" : obj.AttrBeingPaidNames;
  }
  return s;
}

public static Func<ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure, ssConectaProveedores.RestRecords.JSONST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure FromStructure(ST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_b97a22be0cf9a9b2c6ab22fc6bcd3c6dStructure(s, config);
}

}


