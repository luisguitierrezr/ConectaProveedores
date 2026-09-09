using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PostValidacfdiprovResponseWrapper
public class JSONST_13caff817360521524d01995a65282cdStructure : AbstractRESTStructure<ST_13caff817360521524d01995a65282cdStructure> {
[JsonProperty("code")]
[JsonPropertyName("code")]
public long? AttrCode;

[JsonProperty("message")]
[JsonPropertyName("message")]
public string AttrMessage;

[JsonProperty("validaCfdResult")]
[JsonPropertyName("validaCfdResult")]
public ssConectaProveedores.RestRecords.JSONST_b861b971a77239711f72752e074dae26Structure AttrValidaCfdResultWrapper;

public JSONST_13caff817360521524d01995a65282cdStructure() { }

public JSONST_13caff817360521524d01995a65282cdStructure (ST_13caff817360521524d01995a65282cdStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, 0L);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
AttrValidaCfdResultWrapper = ConvertToRestWithoutDefaults(s.ssValidaCfdResultWrapper, new ST_b861b971a77239711f72752e074dae26Structure(), ssConectaProveedores.RestRecords.JSONST_b861b971a77239711f72752e074dae26Structure.FromStructure, config);
  } else {
AttrCode = (long?) s.ssCode;
AttrMessage = s.ssMessage;
AttrValidaCfdResultWrapper = ssConectaProveedores.RestRecords.JSONST_b861b971a77239711f72752e074dae26Structure.FromStructure(s.ssValidaCfdResultWrapper, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_13caff817360521524d01995a65282cdStructure, ST_13caff817360521524d01995a65282cdStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_13caff817360521524d01995a65282cdStructure s) => ToStructure(s, config);
}
public static ST_13caff817360521524d01995a65282cdStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_13caff817360521524d01995a65282cdStructure obj, IBehaviorsConfiguration config) { 
  ST_13caff817360521524d01995a65282cdStructure s = new ST_13caff817360521524d01995a65282cdStructure();
  if(obj != null) {
  s.ssCode = obj.AttrCode == null ? 0L : obj.AttrCode.Value;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssValidaCfdResultWrapper = ssConectaProveedores.RestRecords.JSONST_b861b971a77239711f72752e074dae26Structure.ToStructure(obj.AttrValidaCfdResultWrapper, config);
  }
  return s;
}

public static Func<ST_13caff817360521524d01995a65282cdStructure, ssConectaProveedores.RestRecords.JSONST_13caff817360521524d01995a65282cdStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_13caff817360521524d01995a65282cdStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_13caff817360521524d01995a65282cdStructure FromStructure(ST_13caff817360521524d01995a65282cdStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_13caff817360521524d01995a65282cdStructure(s, config);
}

}


