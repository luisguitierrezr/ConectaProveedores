using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderStatusOrderMainRecord
public class JSONRC_04c362ab7ba29f051f4f0e5fa0df3577 : AbstractRESTStructure<RC_04c362ab7ba29f051f4f0e5fa0df3577> {
[JsonProperty("OrderStatus")]
[JsonPropertyName("OrderStatus")]
public ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord AttrOrderStatus;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public JSONRC_04c362ab7ba29f051f4f0e5fa0df3577() { }

public JSONRC_04c362ab7ba29f051f4f0e5fa0df3577 (RC_04c362ab7ba29f051f4f0e5fa0df3577 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssENOrderStatus, new EN_5eda60810da752f579e01795bb7e0de0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrOrderStatus = ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure(s.ssENOrderStatus, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_04c362ab7ba29f051f4f0e5fa0df3577, RC_04c362ab7ba29f051f4f0e5fa0df3577> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_04c362ab7ba29f051f4f0e5fa0df3577 s) => ToStructure(s, config);
}
public static RC_04c362ab7ba29f051f4f0e5fa0df3577 ToStructure(ssConectaProveedores.RestRecords.JSONRC_04c362ab7ba29f051f4f0e5fa0df3577 obj, IBehaviorsConfiguration config) { 
  RC_04c362ab7ba29f051f4f0e5fa0df3577 s = new RC_04c362ab7ba29f051f4f0e5fa0df3577();
  if(obj != null) {
  s.ssENOrderStatus = ssConectaProveedores.RestRecords.JSONEN_5eda60810da752f579e01795bb7e0de0EntityRecord.ToStructure(obj.AttrOrderStatus, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  }
  return s;
}

public static Func<RC_04c362ab7ba29f051f4f0e5fa0df3577, ssConectaProveedores.RestRecords.JSONRC_04c362ab7ba29f051f4f0e5fa0df3577> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_04c362ab7ba29f051f4f0e5fa0df3577 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_04c362ab7ba29f051f4f0e5fa0df3577 FromStructure(RC_04c362ab7ba29f051f4f0e5fa0df3577 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_04c362ab7ba29f051f4f0e5fa0df3577(s, config);
}

}


