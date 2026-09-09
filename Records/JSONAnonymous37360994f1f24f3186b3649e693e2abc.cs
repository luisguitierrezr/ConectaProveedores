using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainTabNumberTelcelDirectionRegionRecord
public class JSONRC_0d0a8c249b32cb294d6fd424b17f5c4d : AbstractRESTStructure<RC_0d0a8c249b32cb294d6fd424b17f5c4d> {
[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("TabNumber")]
[JsonPropertyName("TabNumber")]
public int? AttrTabNumber;

[JsonProperty("TelcelDirection")]
[JsonPropertyName("TelcelDirection")]
public ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord AttrTelcelDirection;

[JsonProperty("Region")]
[JsonPropertyName("Region")]
public ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public JSONRC_0d0a8c249b32cb294d6fd424b17f5c4d() { }

public JSONRC_0d0a8c249b32cb294d6fd424b17f5c4d (RC_0d0a8c249b32cb294d6fd424b17f5c4d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrTabNumber = ConvertToRestWithoutDefaults(s.ssTabNumber, 0);
AttrTelcelDirection = ConvertToRestWithoutDefaults(s.ssENTelcelDirection, new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrTabNumber = (int?) s.ssTabNumber;
AttrTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure(s.ssENTelcelDirection, config);
AttrRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0d0a8c249b32cb294d6fd424b17f5c4d, RC_0d0a8c249b32cb294d6fd424b17f5c4d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0d0a8c249b32cb294d6fd424b17f5c4d s) => ToStructure(s, config);
}
public static RC_0d0a8c249b32cb294d6fd424b17f5c4d ToStructure(ssConectaProveedores.RestRecords.JSONRC_0d0a8c249b32cb294d6fd424b17f5c4d obj, IBehaviorsConfiguration config) { 
  RC_0d0a8c249b32cb294d6fd424b17f5c4d s = new RC_0d0a8c249b32cb294d6fd424b17f5c4d();
  if(obj != null) {
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssTabNumber = obj.AttrTabNumber == null ? 0 : obj.AttrTabNumber.Value;
  s.ssENTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.ToStructure(obj.AttrTelcelDirection, config);
  s.ssENRegion = ssConectaProveedores.RestRecords.JSONEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion, config);
  }
  return s;
}

public static Func<RC_0d0a8c249b32cb294d6fd424b17f5c4d, ssConectaProveedores.RestRecords.JSONRC_0d0a8c249b32cb294d6fd424b17f5c4d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0d0a8c249b32cb294d6fd424b17f5c4d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0d0a8c249b32cb294d6fd424b17f5c4d FromStructure(RC_0d0a8c249b32cb294d6fd424b17f5c4d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0d0a8c249b32cb294d6fd424b17f5c4d(s, config);
}

}


