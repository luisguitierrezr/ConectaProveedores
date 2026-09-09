using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainOrderDetailRecord
public class RESTRC_64337b445a88908182ed34f64cf1399b : AbstractRESTStructure<RC_64337b445a88908182ed34f64cf1399b> {
[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderDetail")]
public ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord AttrOrderDetail;

public RESTRC_64337b445a88908182ed34f64cf1399b() { }

public RESTRC_64337b445a88908182ed34f64cf1399b (RC_64337b445a88908182ed34f64cf1399b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderDetail = ConvertToRestWithoutDefaults(s.ssENOrderDetail, new EN_26f696e758428762fc617e811634d15dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure, config);
  } else {
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderDetail = ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure(s.ssENOrderDetail, config);
  }
}

public static RC_64337b445a88908182ed34f64cf1399b ToStructure(ssConectaProveedores.RestRecords.RESTRC_64337b445a88908182ed34f64cf1399b obj) { 
  RC_64337b445a88908182ed34f64cf1399b s = new RC_64337b445a88908182ed34f64cf1399b();
  if(obj != null) {
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENOrderDetail = ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.ToStructure(obj.AttrOrderDetail);
  }
  return s;
}

public static Func<RC_64337b445a88908182ed34f64cf1399b, ssConectaProveedores.RestRecords.RESTRC_64337b445a88908182ed34f64cf1399b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_64337b445a88908182ed34f64cf1399b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_64337b445a88908182ed34f64cf1399b FromStructure(RC_64337b445a88908182ed34f64cf1399b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_64337b445a88908182ed34f64cf1399b(s, config);
}

}


