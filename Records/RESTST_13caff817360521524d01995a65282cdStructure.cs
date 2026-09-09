using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PostValidacfdiprovResponseWrapper
public class RESTST_13caff817360521524d01995a65282cdStructure : AbstractRESTStructure<ST_13caff817360521524d01995a65282cdStructure> {
[JsonProperty("Code")]
public long? AttrCode;

[JsonProperty("Message")]
public string AttrMessage;

[JsonProperty("ValidaCfdResultWrapper")]
public ssConectaProveedores.RestRecords.RESTST_b861b971a77239711f72752e074dae26Structure AttrValidaCfdResultWrapper;

public RESTST_13caff817360521524d01995a65282cdStructure() { }

public RESTST_13caff817360521524d01995a65282cdStructure (ST_13caff817360521524d01995a65282cdStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCode = ConvertToRestWithoutDefaults(s.ssCode, 0L);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
AttrValidaCfdResultWrapper = ConvertToRestWithoutDefaults(s.ssValidaCfdResultWrapper, new ST_b861b971a77239711f72752e074dae26Structure(), ssConectaProveedores.RestRecords.RESTST_b861b971a77239711f72752e074dae26Structure.FromStructure, config);
  } else {
AttrCode = (long?) s.ssCode;
AttrMessage = s.ssMessage;
AttrValidaCfdResultWrapper = ssConectaProveedores.RestRecords.RESTST_b861b971a77239711f72752e074dae26Structure.FromStructure(s.ssValidaCfdResultWrapper, config);
  }
}

public static ST_13caff817360521524d01995a65282cdStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_13caff817360521524d01995a65282cdStructure obj) { 
  ST_13caff817360521524d01995a65282cdStructure s = new ST_13caff817360521524d01995a65282cdStructure();
  if(obj != null) {
  s.ssCode = obj.AttrCode == null ? 0L : obj.AttrCode.Value;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssValidaCfdResultWrapper = ssConectaProveedores.RestRecords.RESTST_b861b971a77239711f72752e074dae26Structure.ToStructure(obj.AttrValidaCfdResultWrapper);
  }
  return s;
}

public static Func<ST_13caff817360521524d01995a65282cdStructure, ssConectaProveedores.RestRecords.RESTST_13caff817360521524d01995a65282cdStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_13caff817360521524d01995a65282cdStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_13caff817360521524d01995a65282cdStructure FromStructure(ST_13caff817360521524d01995a65282cdStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_13caff817360521524d01995a65282cdStructure(s, config);
}

}


