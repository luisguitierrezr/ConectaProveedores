using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderStatusOrderMainRecord
public class RESTRC_04c362ab7ba29f051f4f0e5fa0df3577 : AbstractRESTStructure<RC_04c362ab7ba29f051f4f0e5fa0df3577> {
[JsonProperty("OrderStatus")]
public ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord AttrOrderStatus;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public RESTRC_04c362ab7ba29f051f4f0e5fa0df3577() { }

public RESTRC_04c362ab7ba29f051f4f0e5fa0df3577 (RC_04c362ab7ba29f051f4f0e5fa0df3577 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssENOrderStatus, new EN_5eda60810da752f579e01795bb7e0de0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrOrderStatus = ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure(s.ssENOrderStatus, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static RC_04c362ab7ba29f051f4f0e5fa0df3577 ToStructure(ssConectaProveedores.RestRecords.RESTRC_04c362ab7ba29f051f4f0e5fa0df3577 obj) { 
  RC_04c362ab7ba29f051f4f0e5fa0df3577 s = new RC_04c362ab7ba29f051f4f0e5fa0df3577();
  if(obj != null) {
  s.ssENOrderStatus = ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.ToStructure(obj.AttrOrderStatus);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  }
  return s;
}

public static Func<RC_04c362ab7ba29f051f4f0e5fa0df3577, ssConectaProveedores.RestRecords.RESTRC_04c362ab7ba29f051f4f0e5fa0df3577> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_04c362ab7ba29f051f4f0e5fa0df3577 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_04c362ab7ba29f051f4f0e5fa0df3577 FromStructure(RC_04c362ab7ba29f051f4f0e5fa0df3577 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_04c362ab7ba29f051f4f0e5fa0df3577(s, config);
}

}


