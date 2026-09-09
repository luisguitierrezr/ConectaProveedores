using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainOrderDetailRecord
public class JSONRC_64337b445a88908182ed34f64cf1399b : AbstractRESTStructure<RC_64337b445a88908182ed34f64cf1399b> {
[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderDetail")]
[JsonPropertyName("OrderDetail")]
public ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord AttrOrderDetail;

public JSONRC_64337b445a88908182ed34f64cf1399b() { }

public JSONRC_64337b445a88908182ed34f64cf1399b (RC_64337b445a88908182ed34f64cf1399b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderDetail = ConvertToRestWithoutDefaults(s.ssENOrderDetail, new EN_26f696e758428762fc617e811634d15dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure, config);
  } else {
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderDetail = ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure(s.ssENOrderDetail, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_64337b445a88908182ed34f64cf1399b, RC_64337b445a88908182ed34f64cf1399b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_64337b445a88908182ed34f64cf1399b s) => ToStructure(s, config);
}
public static RC_64337b445a88908182ed34f64cf1399b ToStructure(ssConectaProveedores.RestRecords.JSONRC_64337b445a88908182ed34f64cf1399b obj, IBehaviorsConfiguration config) { 
  RC_64337b445a88908182ed34f64cf1399b s = new RC_64337b445a88908182ed34f64cf1399b();
  if(obj != null) {
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENOrderDetail = ssConectaProveedores.RestRecords.JSONEN_26f696e758428762fc617e811634d15dEntityRecord.ToStructure(obj.AttrOrderDetail, config);
  }
  return s;
}

public static Func<RC_64337b445a88908182ed34f64cf1399b, ssConectaProveedores.RestRecords.JSONRC_64337b445a88908182ed34f64cf1399b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_64337b445a88908182ed34f64cf1399b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_64337b445a88908182ed34f64cf1399b FromStructure(RC_64337b445a88908182ed34f64cf1399b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_64337b445a88908182ed34f64cf1399b(s, config);
}

}


